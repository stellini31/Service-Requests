namespace Service_Requests.UI
{
    partial class RegisterUser
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
            this.components = new System.ComponentModel.Container();
            this.success_label = new System.Windows.Forms.Label();
            this.register_button = new System.Windows.Forms.Button();
            this.username_text = new System.Windows.Forms.TextBox();
            this.email_text = new System.Windows.Forms.TextBox();
            this.confirm_text = new System.Windows.Forms.TextBox();
            this.password_text = new System.Windows.Forms.TextBox();
            this.name_text = new System.Windows.Forms.TextBox();
            this.confirm_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.hide_success_label = new System.Windows.Forms.Timer(this.components);
            this.connection_error_label = new System.Windows.Forms.Label();
            this.hide_error_label = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // success_label
            // 
            this.success_label.AutoSize = true;
            this.success_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.success_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.success_label.Location = new System.Drawing.Point(215, 278);
            this.success_label.Name = "success_label";
            this.success_label.Size = new System.Drawing.Size(190, 20);
            this.success_label.TabIndex = 27;
            this.success_label.Text = "Registered Successfully";
            this.success_label.Click += new System.EventHandler(this.success_label_Click);
            // 
            // register_button
            // 
            this.register_button.Location = new System.Drawing.Point(202, 337);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(223, 35);
            this.register_button.TabIndex = 26;
            this.register_button.Text = "Register";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // username_text
            // 
            this.username_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_text.Location = new System.Drawing.Point(202, 114);
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(245, 30);
            this.username_text.TabIndex = 25;
            this.username_text.TextChanged += new System.EventHandler(this.username_text_TextChanged);
            // 
            // email_text
            // 
            this.email_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_text.Location = new System.Drawing.Point(202, 234);
            this.email_text.Name = "email_text";
            this.email_text.Size = new System.Drawing.Size(245, 30);
            this.email_text.TabIndex = 24;
            this.email_text.TextChanged += new System.EventHandler(this.email_text_TextChanged);
            // 
            // confirm_text
            // 
            this.confirm_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_text.Location = new System.Drawing.Point(202, 197);
            this.confirm_text.Name = "confirm_text";
            this.confirm_text.Size = new System.Drawing.Size(245, 30);
            this.confirm_text.TabIndex = 23;
            this.confirm_text.UseSystemPasswordChar = true;
            this.confirm_text.TextChanged += new System.EventHandler(this.confirm_text_TextChanged);
            // 
            // password_text
            // 
            this.password_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_text.Location = new System.Drawing.Point(202, 154);
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(245, 30);
            this.password_text.TabIndex = 22;
            this.password_text.UseSystemPasswordChar = true;
            this.password_text.TextChanged += new System.EventHandler(this.password_text_TextChanged);
            // 
            // name_text
            // 
            this.name_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_text.Location = new System.Drawing.Point(202, 75);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(245, 30);
            this.name_text.TabIndex = 21;
            this.name_text.TextChanged += new System.EventHandler(this.name_text_TextChanged);
            // 
            // confirm_label
            // 
            this.confirm_label.AutoSize = true;
            this.confirm_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_label.Location = new System.Drawing.Point(18, 197);
            this.confirm_label.Name = "confirm_label";
            this.confirm_label.Size = new System.Drawing.Size(177, 25);
            this.confirm_label.TabIndex = 20;
            this.confirm_label.Text = "Confirm Password:";
            this.confirm_label.Click += new System.EventHandler(this.confirm_label_Click);
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.Location = new System.Drawing.Point(97, 154);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(104, 25);
            this.password_label.TabIndex = 19;
            this.password_label.Text = "Password:";
            this.password_label.Click += new System.EventHandler(this.password_label_Click);
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.Location = new System.Drawing.Point(129, 237);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(66, 25);
            this.email_label.TabIndex = 18;
            this.email_label.Text = "Email:";
            this.email_label.Click += new System.EventHandler(this.email_label_Click);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(125, 73);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(70, 25);
            this.name_label.TabIndex = 17;
            this.name_label.Text = "Name:";
            this.name_label.Click += new System.EventHandler(this.name_label_Click);
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.Location = new System.Drawing.Point(87, 114);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(108, 25);
            this.username_label.TabIndex = 16;
            this.username_label.Text = "Username:";
            this.username_label.Click += new System.EventHandler(this.username_label_Click);
            // 
            // hide_success_label
            // 
            this.hide_success_label.Tick += new System.EventHandler(this.hide_success_label_Tick);
            // 
            // connection_error_label
            // 
            this.connection_error_label.AutoSize = true;
            this.connection_error_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connection_error_label.Location = new System.Drawing.Point(215, 278);
            this.connection_error_label.Name = "connection_error_label";
            this.connection_error_label.Size = new System.Drawing.Size(0, 20);
            this.connection_error_label.TabIndex = 28;
            this.connection_error_label.Click += new System.EventHandler(this.connection_error_label_Click);
            // 
            // hide_error_label
            // 
            this.hide_error_label.Tick += new System.EventHandler(this.hide_error_label_Tick);
            // 
            // RegisterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 429);
            this.Controls.Add(this.success_label);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.username_text);
            this.Controls.Add(this.email_text);
            this.Controls.Add(this.confirm_text);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.name_text);
            this.Controls.Add(this.confirm_label);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.connection_error_label);
            this.Name = "RegisterUser";
            this.Text = "RegisterUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label success_label;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.TextBox username_text;
        private System.Windows.Forms.TextBox email_text;
        private System.Windows.Forms.TextBox confirm_text;
        private System.Windows.Forms.TextBox password_text;
        private System.Windows.Forms.TextBox name_text;
        private System.Windows.Forms.Label confirm_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Timer hide_success_label;
        private System.Windows.Forms.Label connection_error_label;
        private System.Windows.Forms.Timer hide_error_label;
    }
}