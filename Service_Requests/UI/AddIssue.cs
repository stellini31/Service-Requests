using Service_Requests.Database;
using Service_Rrequests;
using Service_Rrequests.Database;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service_Requests.UI
{
    public partial class AddIssue : Form
    {
        public AddIssue()
        {
            InitializeComponent();
        }

        private void save_butoon_Click(object sender, EventArgs e)
        {
            if (!(title_text.Text == "") || !(comment_text.Text == "") || !(issuerID_text.Text == "") || !(issuerName_text.Text == "") || !(issuerTel_text.Text == ""))
            {
                issue i = new issue();
                IssuesData id = new IssuesData();
                DateTime date = DateTime.Now;
                IssueType_Data itd = new IssueType_Data();

                i.issue_title = title_text.Text;
                i.issue_description = comment_text.Text;
                i.issue_creator_username = SessionInfo.userName;
                i.issue_date_created = date;
                i.issue_ongoing = true;
                i.issuer_id = issuerID_text.Text;
                i.issuer_name = issuerName_text.Text;
                i.issuer_tel = issuerTel_text.Text;

                i.issue_type_id = itd.getIssueTypeIDbyTitle(issueType_combo.Text);

                id.saveIssue(i);

                title_text.Text = "";
                comment_text.Text = "";
                issuerID_text.Text = "";
                issuerName_text.Text = "";
                issuerTel_text.Text = "";
            }
        }

        private void AddIssue_Load(object sender, EventArgs e)
        {
            using (var dbContext = new Service_Requests_Data_GOVEntities())
            {
                ArrayList issues = new ArrayList();

                foreach (issue_types issue in dbContext.issue_types)
                {
                    issues.Add(issue.issue_title);
                    issueType_combo.Items.Add(issue.issue_title);
                }
            }
            issueType_combo.SelectedIndex = 0;
        }
    }
}
