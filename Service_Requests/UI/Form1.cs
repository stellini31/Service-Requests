using Service_Rrequests;
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
    public partial class Form1 : Form
    {
        users_data ud = new users_data();

        public Form1()
        {
            InitializeComponent();
        }

        private void register_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterUser register = new RegisterUser();
            register.ShowDialog();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string username = username_text.Text;
            string password = password_text.Text;

            int state = ud.authorize(username, password);

            switch (state)
            {
                case 2:
                    status_label.Text = "Invalid username or password";
                    status_label.Visible = true;
                    break;
                case 3:
                    status_label.Text = "Account not verified";
                    status_label.Visible = true;
                    break;
                case 4:
                    status_label.Text = "Cannot connect to database";
                    status_label.Visible = true;
                    break;
                default:
                    SessionInfo.userName = username;
                    SessionInfo.timeLogged = DateTime.Now;
                    this.Hide();
                    var main = new MainApp();
                    main.Closed += (s, args) => this.Close();
                    main.Show();
                    break;
            }
        }
    }
}
