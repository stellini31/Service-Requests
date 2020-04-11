using Service_Rrequests;
using Service_Rrequests.Tools;
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
    public partial class RegisterUser : Form
    {
        string PASSWORDKEY = "kkTT5c4mrKlN1nDGGLid";

        public RegisterUser()
        {
            InitializeComponent();
            success_label.Visible = false;
            connection_error_label.Visible = false;
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            DateTime currTime = DateTime.Now;
            var user = new user();
            users_data ud = new users_data();

            if (ud.db_connection_available())   //check connection with DB
            {
                if (!(username_text.Text.Equals("")) && !(name_text.Text.Equals("")) && !(email_text.Text.Equals("")) && !(password_text.Text.Equals("")) && !(confirm_text.Text.Equals("")))   //check if all fields contains text
                {
                    if (password_text.Text.Equals(confirm_text.Text))   //match passwords
                    {
                        String _password = Crypto.HashPassword(password_text.Text);

                        if (!ud.check_user_exists(username_text.Text))  //checking if username already exists in DB
                        {
                            user.user_name = name_text.Text;
                            user.user_email = email_text.Text;
                            user.user_last_password_change = DateTime.Now;
                            user.user_password = _password;
                            user.user_role_id = 1;
                            user.user_username = username_text.Text;
                            user.user_approved = false;

                            ud.saveUser(user);  //Save User to Database
                            success_label.Visible = true;   //Showing registration success message

                            //Clearing Text Fields
                            username_text.Text = "";
                            name_text.Text = "";
                            email_text.Text = "";
                            password_text.Text = "";
                            confirm_text.Text = "";

                            hide_success_label.Interval = 3000; // 3 seconds.
                            hide_success_label.Tick += hide_success_label_Tick;
                            hide_success_label.Start();
                        }
                        else
                        {
                            connection_error_label.Visible = true;
                            connection_error_label.Text = "This username already exists";

                            hide_error_label.Interval = 3000; // 3 seconds.
                            hide_error_label.Tick += hide_error_label_Tick;
                            hide_error_label.Start();
                        }
                    }
                    else
                    {
                        connection_error_label.Visible = true;
                        connection_error_label.Text = "The passwords does not match";

                        password_text.Text = "";
                        confirm_text.Text = "";

                        hide_error_label.Interval = 3000; // 3 seconds.
                        hide_error_label.Tick += hide_error_label_Tick;
                        hide_error_label.Start();
                    }
                }
                else
                {
                    connection_error_label.Visible = true;
                    connection_error_label.Text = "Please fill all fields";

                    hide_error_label.Interval = 3000; // 3 seconds.
                    hide_error_label.Tick += hide_error_label_Tick;
                    hide_error_label.Start();
                }
            }
            else
            {
                connection_error_label.Visible = true;
                connection_error_label.Text = "Unable to make connection to database";

                hide_error_label.Interval = 3000; // 3 seconds.
                hide_error_label.Tick += hide_error_label_Tick;
                hide_error_label.Start();
            }
        }

        private void name_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirm_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void success_label_Click(object sender, EventArgs e)
        {

        }

        private void confirm_label_Click(object sender, EventArgs e)
        {

        }

        private void password_label_Click(object sender, EventArgs e)
        {

        }

        private void email_label_Click(object sender, EventArgs e)
        {

        }

        private void name_label_Click(object sender, EventArgs e)
        {

        }

        private void username_label_Click(object sender, EventArgs e)
        {

        }

        private void hide_success_label_Tick(object sender, EventArgs e)
        {
            success_label.Visible = false;
            hide_success_label.Stop();
        }

        private void connection_error_label_Click(object sender, EventArgs e)
        {

        }

        private void hide_error_label_Tick(object sender, EventArgs e)
        {
            connection_error_label.Visible = false;
            hide_error_label.Stop();
        }

        private void RegisterUser_Load(object sender, EventArgs e)
        {

        }
    }
}
