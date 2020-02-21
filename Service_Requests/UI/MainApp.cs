using Service_Requests.Database;
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
    public partial class MainApp : Form
    {
        public static List <issue> issues = new List<issue>();
        public static int chosenRow = -1;
        IssuesData id = new IssuesData();
        IssueType_Data itd = new IssueType_Data();
        //Boolean opened;

        public MainApp()
        {
            
            InitializeComponent();
        }

        private void MainApp_Load(object sender, EventArgs e)
        {
            this.LoadAllIssues();
        }

        public void LoadAllIssues(List <issue> iss = null)
        {

            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.Controls.Clear();
            chosenRow = -1;

            if(iss == null)
            {
                issues = id.getAllIssues();
                issues.Reverse();

                foreach (issue i in issues)
                {
                    this.AddItem(i.issue_title, i.issue_description, itd.getIssueTypeById(i.issue_type_id).issue_title, i.issue_date_created.ToString());
                }

                foreach (Label space in this.tableLayoutPanel1.Controls)
                {
                    space.MouseClick += new MouseEventHandler(clickOnSpace);
                }

                if (chosenRow != -1)
                {
                    int id = issues[chosenRow - 1].issue_id;
                    ManageIssue mi = new ManageIssue(id);
                    mi.ShowDialog();
                }
            }
            else
            {
                issues = iss;
                issues.Reverse();

                foreach (issue i in issues)
                {
                    this.AddItem(i.issue_title, i.issue_description, itd.getIssueTypeById(i.issue_type_id).issue_title, i.issue_date_created.ToString());
                }

                foreach (Label space in this.tableLayoutPanel1.Controls)
                {
                    space.MouseClick += new MouseEventHandler(clickOnSpace);
                }

                if (chosenRow != -1)
                {
                    int id = issues[chosenRow - 1].issue_id;
                    ManageIssue mi = new ManageIssue(id);
                    mi.ShowDialog();
                }
            }
        }

        private void AddItem(string title, string description, string type,  string dateCreated)
        {

            //get a reference to the previous existent 
            RowStyle temp = tableLayoutPanel1.RowStyles[tableLayoutPanel1.RowCount - 1];
            //increase panel rows count by one
            tableLayoutPanel1.RowCount++;
            //add a new RowStyle as a copy of the previous one
            tableLayoutPanel1.RowStyles.Add(new RowStyle(temp.SizeType, temp.Height));
            //add your three controls
            tableLayoutPanel1.Controls.Add(new Label() { Text = title, Cursor = Cursors.Hand }, 0, tableLayoutPanel1.RowCount - 1);
            tableLayoutPanel1.Controls.Add(new Label() { Text = description }, 1, tableLayoutPanel1.RowCount - 1);
            tableLayoutPanel1.Controls.Add(new Label() { Text = type }, 2, tableLayoutPanel1.RowCount - 1);
            tableLayoutPanel1.Controls.Add(new Label() { Text = dateCreated }, 3, tableLayoutPanel1.RowCount - 1);

            
        }

        public void clickOnSpace(object sender, MouseEventArgs e)
        {

            chosenRow = tableLayoutPanel1.GetRow((Label)sender);  

            if(chosenRow != 0)
            {
                int id = issues[chosenRow - 1].issue_id;
                ManageIssue mi = new ManageIssue(id);
                mi.ShowDialog();
                //opened = true;
            }
                             
        }

        private void create_issue_button_Click(object sender, EventArgs e)
        {
            AddIssue addIssue = new AddIssue();
            addIssue.Show();
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            
            this.LoadAllIssues();
        }

        /*private void search_text_TextChanged(object sender, EventArgs e)
        {
            this.search_text.Text = "";
        }*/

        private void search_button_Click(object sender, EventArgs e)
        {
            string searchText = this.search_text.Text;
            List<issue> isu = id.searchIssue(searchText);
            this.LoadAllIssues(isu);

        }
    }
}
