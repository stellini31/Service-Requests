namespace Service_Requests.UI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fields_panel = new System.Windows.Forms.Panel();
            this.status_label = new System.Windows.Forms.Label();
            this.register_label = new System.Windows.Forms.LinkLabel();
            this.username_text = new System.Windows.Forms.TextBox();
            this.or_label = new System.Windows.Forms.Label();
            this.login_button = new System.Windows.Forms.Button();
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.login_label = new System.Windows.Forms.Label();
            this.password_text = new System.Windows.Forms.TextBox();
            this.fields_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // fields_panel
            // 
            this.fields_panel.BackColor = System.Drawing.Color.White;
            this.fields_panel.Controls.Add(this.status_label);
            this.fields_panel.Controls.Add(this.register_label);
            this.fields_panel.Controls.Add(this.username_text);
            this.fields_panel.Controls.Add(this.or_label);
            this.fields_panel.Controls.Add(this.login_button);
            this.fields_panel.Controls.Add(this.username_label);
            this.fields_panel.Controls.Add(this.password_label);
            this.fields_panel.Controls.Add(this.login_label);
            this.fields_panel.Controls.Add(this.password_text);
            this.fields_panel.Location = new System.Drawing.Point(67, 44);
            this.fields_panel.Name = "fields_panel";
            this.fields_panel.Size = new System.Drawing.Size(344, 412);
            this.fields_panel.TabIndex = 6;
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_label.Location = new System.Drawing.Point(57, 301);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(0, 20);
            this.status_label.TabIndex = 14;
            this.status_label.Visible = false;
            // 
            // register_label
            // 
            this.register_label.AutoSize = true;
            this.register_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_label.Location = new System.Drawing.Point(120, 359);
            this.register_label.Name = "register_label";
            this.register_label.Size = new System.Drawing.Size(93, 20);
            this.register_label.TabIndex = 13;
            this.register_label.TabStop = true;
            this.register_label.Text = "REGISTER";
            this.register_label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.register_label_LinkClicked);
            // 
            // username_text
            // 
            this.username_text.BackColor = System.Drawing.SystemColors.Menu;
            this.username_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_text.ForeColor = System.Drawing.Color.Silver;
            this.username_text.Location = new System.Drawing.Point(61, 124);
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(222, 27);
            this.username_text.TabIndex = 6;
            this.username_text.Tag = "";
            this.username_text.WordWrap = false;
            // 
            // or_label
            // 
            this.or_label.AutoSize = true;
            this.or_label.Location = new System.Drawing.Point(155, 327);
            this.or_label.Name = "or_label";
            this.or_label.Size = new System.Drawing.Size(29, 17);
            this.or_label.TabIndex = 12;
            this.or_label.Text = "OR";
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(86)))), ((int)(((byte)(212)))));
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.ForeColor = System.Drawing.Color.White;
            this.login_button.Location = new System.Drawing.Point(61, 245);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(222, 36);
            this.login_button.TabIndex = 11;
            this.login_button.Text = "LOGIN";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.Location = new System.Drawing.Point(56, 96);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(108, 25);
            this.username_label.TabIndex = 10;
            this.username_label.Text = "Username:";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.Location = new System.Drawing.Point(56, 170);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(98, 25);
            this.password_label.TabIndex = 9;
            this.password_label.Text = "Password";
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_label.Location = new System.Drawing.Point(108, 34);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(111, 33);
            this.login_label.TabIndex = 8;
            this.login_label.Text = "LOGIN";
            // 
            // password_text
            // 
            this.password_text.AccessibleDescription = "";
            this.password_text.BackColor = System.Drawing.SystemColors.Menu;
            this.password_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_text.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_text.Location = new System.Drawing.Point(61, 198);
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(222, 29);
            this.password_text.TabIndex = 7;
            this.password_text.UseSystemPasswordChar = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 513);
            this.Controls.Add(this.fields_panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.fields_panel.ResumeLayout(false);
            this.fields_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel fields_panel;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.LinkLabel register_label;
        private System.Windows.Forms.TextBox username_text;
        private System.Windows.Forms.Label or_label;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.TextBox password_text;
    }
}