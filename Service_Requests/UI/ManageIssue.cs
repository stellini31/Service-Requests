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
        List<action> actions = new List<action>();
        issue i = MainApp.issues[MainApp.chosenRow - 1];
        IssuesData id = new IssuesData();
        IssueType_Data itd = new IssueType_Data();
        
        Actions_Data ad = new Actions_Data();
        public ManageIssue()
        {
            InitializeComponent();
        }


        private void ManageIssue_Load(object sender, EventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(5, 5, 17, 17);
            toggle_but.Region = new Region(gp);
            gp.Dispose();
           

            title_label.Text = i.issue_title;
            creator_text.Text = i.issue_creator_username;
            name_text.Text = i.issuer_name;
            id_text.Text = i.issuer_id;
            tel_text.Text = i.issuer_tel;
            description_text.Text = i.issue_description;
            date_text.Text = i.issue_date_created.ToString();

            List<issue_types> issue_types = itd.getAllIssues();

            foreach(issue_types it in issue_types)
            {
                issues_combo.Items.Add(it.issue_title);
            }
            issues_combo.SelectedIndex = i.issue_type_id - 1;

            actions = ad.getAllActionsForIssue(i.issue_id);
            string concatActions = "";

            foreach(action a in actions)
            {
                concatActions = concatActions + a.action_description + "\r\n\r\n";
            }
            actions_text.Text = concatActions;

            if (i.issue_ongoing)
            {
                toggle_but.BackColor = Color.Orange;
                statusShow_label.Text = "Ongoing";
            }
            else {
                toggle_but.BackColor = Color.Green;
                statusShow_label.Text = "Complete";
            }

            reminder_enable.Checked = false;
            dateTimePicker1.Enabled = false;
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

                actions = ad.getAllActionsForIssue(i.issue_id);
                string concatActions = "";

                foreach (action ac in actions)
                {
                    concatActions = concatActions + a.action_description + "\r\n\r\n";
                }
                actions_text.Text = concatActions;

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

                actions = ad.getAllActionsForIssue(i.issue_id);
                string concatActions = "";

                foreach (action ac in actions)
                {
                    concatActions = concatActions + ac.action_description + "\r\n\r\n";
                }
                actions_text.Text = concatActions;
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

            actions = ad.getAllActionsForIssue(i.issue_id);
            string concatActions = "";

            foreach (action ac in actions)
            {
                concatActions = concatActions + ac.action_description + "\r\n\r\n";
            }
            actions_text.Text = concatActions;
        }
    }
}
