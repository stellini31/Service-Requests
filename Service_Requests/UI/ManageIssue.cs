using Service_Requests.Database;
using Service_Rrequests;
using Service_Rrequests.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service_Requests.UI
{
    public partial class ManageIssue : Form
    {
        issue i;// = MainApp.issues[MainApp.chosenRow - 1];
        IssuesData id = new IssuesData();
        IssueType_Data itd = new IssueType_Data();
        Reminders_Data rd = new Reminders_Data();
        string nameOrigin;
        string idOrigin;
        string telOrigin;
        string descOrigin;
        int issueTypeOrigin;
        Actions_Data ad = new Actions_Data();

        public ManageIssue(int IssueId)
        {
            InitializeComponent();
            saved_label.Visible = false;
            i = id.getIssueById(IssueId);
        }


        private void ManageIssue_Load(object sender, EventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(5, 5, 17, 17);
            toggle_but.Region = new Region(gp);
            gp.Dispose();
           

            title_label.Text = i.issue_title;
            creator_text.Text = i.issue_creator_username;
            nameOrigin = name_text.Text = i.issuer_name;
            idOrigin = id_text.Text = i.issuer_id;
            telOrigin = tel_text.Text = i.issuer_tel;
            descOrigin = description_text.Text = i.issue_description;
            dateCreated_label.Text = i.issue_date_created.ToString();

            List<issue_types> issue_types = itd.getAllIssues();

            foreach(issue_types it in issue_types)
            {
                issues_combo.Items.Add(it.issue_title);
            }
            issueTypeOrigin = issues_combo.SelectedIndex = i.issue_type_id-1;

            this.populateActionsBox(i.issue_id);

            if (i.issue_ongoing)
            {
                toggle_but.BackColor = Color.Orange;
                statusShow_label.Text = "Ongoing";
            }
            else {
                toggle_but.BackColor = Color.Green;
                statusShow_label.Text = "Complete";
            }

            if (rd.reminderEnabled(i.issue_id, SessionInfo.userId))
            {
                reminder_enable.Checked = true;
                dateTimePicker1.Enabled = true;

                dateTimePicker1.Value = rd.getReminder(i.issue_id, SessionInfo.userId).remider_date;
            }
            else
            {
                reminder_enable.Checked = false;
                dateTimePicker1.Enabled = false;
            }
            
        }

        private void toggle_but_Click(object sender, EventArgs e)
        {
            action a = new action();
            if (i.issue_ongoing)
            {
                i.issue_ongoing = false;
                toggle_but.BackColor = Color.LightGreen;
                statusShow_label.Text = "Complete";
                id.toggleIssueStatusTo(false, i.issue_id);

                string desc = "changed Issue Status to Complete";
                a.action_description = desc;
                a.issue_id = i.issue_id;
                a.user_id = SessionInfo.userId;

                ad.addAction(a);

                this.populateActionsBox(i.issue_id);

            }
            else
            {
                i.issue_ongoing = true;
                toggle_but.BackColor = Color.Orange;
                statusShow_label.Text = "Ongoing";
                id.toggleIssueStatusTo(true, i.issue_id);

                string desc = "changed Issue Status to Ongoing";
                a.action_description = desc;
                a.issue_id = i.issue_id;
                a.user_id = SessionInfo.userId;

                ad.addAction(a);

                populateActionsBox(i.issue_id);
            }
        }

        private void reminder_enable_CheckedChanged(object sender, EventArgs e)
        {
            if (reminder_enable.Checked)
            {
                dateTimePicker1.Enabled = true;
            }
            else
            {
                dateTimePicker1.Enabled = false;
            }
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            action a = new action();
            a.action_description = actionSubmit_text.Text;
            a.user_id = SessionInfo.userId;
            a.issue_id = i.issue_id;

            ad.addAction(a);
            actionSubmit_text.Text = "";

            this.populateActionsBox(i.issue_id);
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (reminder_enable.Checked == true)
            {
                rd.saveReminder(i.issue_id, SessionInfo.userId, dateTimePicker1.Value.Date, true);
            }
            else
            {
                //update reminder enabled in db
                rd.updateReminder(i.issue_id, SessionInfo.userId, dateTimePicker1.Value.Date, false);
            }

            //Update Issue Changes in DB
            id.updateIssueData(i.issue_id, description_text.Text, name_text.Text, id_text.Text, tel_text.Text, itd.getIssueTypeByTitle(issues_combo.GetItemText(issues_combo.SelectedItem)).issue_type_id);

            saved_label.Visible = true;

            hide_success_label.Interval = 3000; // 3 seconds.
            hide_success_label.Tick += hide_success_label_Tick;
            hide_success_label.Start();

            string actionMsg = "updated ";
            Boolean changesMade = false;

            if (!description_text.Text.Equals(descOrigin)){
                actionMsg += "description, ";
                changesMade = true;
                descOrigin = description_text.Text;
            }
            if (!name_text.Text.Equals(nameOrigin))
            {
                actionMsg += "name, ";
                changesMade = true;
                nameOrigin = name_text.Text;
            }
            if (!id_text.Text.Equals(idOrigin))
            {
                actionMsg += "ID, ";
                changesMade = true;
                idOrigin = id_text.Text;
            }
            if (!tel_text.Text.Equals(telOrigin))
            {
                actionMsg += "telephone, ";
                changesMade = true;
                telOrigin = tel_text.Text;
            }
            if (issues_combo.SelectedIndex != issueTypeOrigin)
            {
                actionMsg += "issue type ";
                changesMade = true;
                issueTypeOrigin = issues_combo.SelectedIndex;
            }

            if (changesMade)
            {
                action a = new action();
                a.action_description = actionMsg;
                a.issue_id = i.issue_id;
                a.user_id = SessionInfo.userId;
                ad.addAction(a);
                actionMsg = "updated ";

                this.populateActionsBox(i.issue_id);
            }
        }

        private void hide_success_label_Tick(object sender, EventArgs e)
        {
            saved_label.Visible = false;
            hide_success_label.Stop();
        }

        public void populateActionsBox(int issueId)
        {
            List<action> actions = ad.getAllActionsForIssue(issueId);
            string concatActions = "";

            foreach (action ac in actions)
            {
                concatActions = concatActions + ac.action_description + "\r\n\r\n";
            }
            actions_text.Text = concatActions;
        }
    }
}
