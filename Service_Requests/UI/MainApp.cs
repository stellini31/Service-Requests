using System;
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
        public MainApp()
        {
            InitializeComponent();
        }

        private void MainApp_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                this.AddItem("test", "test00", "test");
            }
        }

        private void AddItem(string address, string contactNum, string email)
        {
            //this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));

            //get a reference to the previous existent 
            RowStyle temp = tableLayoutPanel1.RowStyles[tableLayoutPanel1.RowCount - 1];
            //increase panel rows count by one
            tableLayoutPanel1.RowCount++;
            //add a new RowStyle as a copy of the previous one
            tableLayoutPanel1.RowStyles.Add(new RowStyle(temp.SizeType, temp.Height));
            //add your three controls
            tableLayoutPanel1.Controls.Add(new Label() { Text = address }, 0, tableLayoutPanel1.RowCount - 1);
            tableLayoutPanel1.Controls.Add(new Label() { Text = contactNum }, 1, tableLayoutPanel1.RowCount - 1);
            tableLayoutPanel1.Controls.Add(new Label() { Text = email }, 2, tableLayoutPanel1.RowCount - 1);
            tableLayoutPanel1.Controls.Add(new LinkLabel() { Text = "view" }, 3, tableLayoutPanel1.RowCount - 1);

        }

        private void create_issue_button_Click(object sender, EventArgs e)
        {
            AddIssue addIssue = new AddIssue();
            addIssue.Show();
        }
    }
}
