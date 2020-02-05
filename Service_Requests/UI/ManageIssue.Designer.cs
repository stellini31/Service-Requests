namespace Service_Requests.UI
{
    partial class ManageIssue
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
            this.issuer_panel = new System.Windows.Forms.Panel();
            this.tel_text = new System.Windows.Forms.TextBox();
            this.id_text = new System.Windows.Forms.TextBox();
            this.name_text = new System.Windows.Forms.TextBox();
            this.tel_label = new System.Windows.Forms.Label();
            this.id_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.issuedBy_panel = new System.Windows.Forms.Panel();
            this.toggle_but = new System.Windows.Forms.Button();
            this.statusShow_label = new System.Windows.Forms.Label();
            this.status_label = new System.Windows.Forms.Label();
            this.creator_text = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.title_label = new System.Windows.Forms.Label();
            this.issueInfo_Panel = new System.Windows.Forms.Panel();
            this.issues_combo = new System.Windows.Forms.ComboBox();
            this.date_text = new System.Windows.Forms.TextBox();
            this.isssueType_label = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.description_text = new System.Windows.Forms.TextBox();
            this.description_label = new System.Windows.Forms.Label();
            this.actions_panel = new System.Windows.Forms.Panel();
            this.submit_button = new System.Windows.Forms.Button();
            this.actionSubmit_text = new System.Windows.Forms.TextBox();
            this.actions_text = new System.Windows.Forms.TextBox();
            this.actions_label = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.remind_label = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.reminder_enable = new System.Windows.Forms.CheckBox();
            this.issuer_panel.SuspendLayout();
            this.issuedBy_panel.SuspendLayout();
            this.issueInfo_Panel.SuspendLayout();
            this.actions_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // issuer_panel
            // 
            this.issuer_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.issuer_panel.Controls.Add(this.tel_text);
            this.issuer_panel.Controls.Add(this.id_text);
            this.issuer_panel.Controls.Add(this.name_text);
            this.issuer_panel.Controls.Add(this.tel_label);
            this.issuer_panel.Controls.Add(this.id_label);
            this.issuer_panel.Controls.Add(this.name_label);
            this.issuer_panel.Location = new System.Drawing.Point(59, 126);
            this.issuer_panel.Name = "issuer_panel";
            this.issuer_panel.Size = new System.Drawing.Size(400, 135);
            this.issuer_panel.TabIndex = 0;
            // 
            // tel_text
            // 
            this.tel_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tel_text.Location = new System.Drawing.Point(132, 92);
            this.tel_text.Name = "tel_text";
            this.tel_text.Size = new System.Drawing.Size(241, 30);
            this.tel_text.TabIndex = 5;
            // 
            // id_text
            // 
            this.id_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_text.Location = new System.Drawing.Point(132, 56);
            this.id_text.Name = "id_text";
            this.id_text.Size = new System.Drawing.Size(241, 30);
            this.id_text.TabIndex = 4;
            // 
            // name_text
            // 
            this.name_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_text.Location = new System.Drawing.Point(132, 20);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(241, 30);
            this.name_text.TabIndex = 3;
            // 
            // tel_label
            // 
            this.tel_label.AutoSize = true;
            this.tel_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tel_label.Location = new System.Drawing.Point(38, 99);
            this.tel_label.Name = "tel_label";
            this.tel_label.Size = new System.Drawing.Size(88, 20);
            this.tel_label.TabIndex = 2;
            this.tel_label.Text = "Issuer Tel:";
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_label.Location = new System.Drawing.Point(44, 63);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(82, 20);
            this.id_label.TabIndex = 1;
            this.id_label.Text = "Issuer ID:";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(17, 22);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(109, 20);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "Issuer Name:";
            // 
            // issuedBy_panel
            // 
            this.issuedBy_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.issuedBy_panel.Controls.Add(this.toggle_but);
            this.issuedBy_panel.Controls.Add(this.statusShow_label);
            this.issuedBy_panel.Controls.Add(this.status_label);
            this.issuedBy_panel.Controls.Add(this.creator_text);
            this.issuedBy_panel.Controls.Add(this.label1);
            this.issuedBy_panel.Controls.Add(this.title_label);
            this.issuedBy_panel.Location = new System.Drawing.Point(59, 12);
            this.issuedBy_panel.Name = "issuedBy_panel";
            this.issuedBy_panel.Size = new System.Drawing.Size(756, 91);
            this.issuedBy_panel.TabIndex = 1;
            // 
            // toggle_but
            // 
            this.toggle_but.BackColor = System.Drawing.Color.Tomato;
            this.toggle_but.CausesValidation = false;
            this.toggle_but.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggle_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toggle_but.ForeColor = System.Drawing.Color.Magenta;
            this.toggle_but.Location = new System.Drawing.Point(632, 53);
            this.toggle_but.Name = "toggle_but";
            this.toggle_but.Size = new System.Drawing.Size(53, 44);
            this.toggle_but.TabIndex = 6;
            this.toggle_but.UseVisualStyleBackColor = false;
            this.toggle_but.Click += new System.EventHandler(this.toggle_but_Click);
            // 
            // statusShow_label
            // 
            this.statusShow_label.AutoSize = true;
            this.statusShow_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusShow_label.Location = new System.Drawing.Point(546, 57);
            this.statusShow_label.Name = "statusShow_label";
            this.statusShow_label.Size = new System.Drawing.Size(55, 20);
            this.statusShow_label.TabIndex = 4;
            this.statusShow_label.Text = "status";
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_label.Location = new System.Drawing.Point(468, 57);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(62, 20);
            this.status_label.TabIndex = 3;
            this.status_label.Text = "Status:";
            // 
            // creator_text
            // 
            this.creator_text.AutoSize = true;
            this.creator_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creator_text.Location = new System.Drawing.Point(121, 57);
            this.creator_text.Name = "creator_text";
            this.creator_text.Size = new System.Drawing.Size(62, 20);
            this.creator_text.TabIndex = 2;
            this.creator_text.Text = "creator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Created By:";
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.Location = new System.Drawing.Point(18, 15);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(61, 29);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "Title";
            // 
            // issueInfo_Panel
            // 
            this.issueInfo_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.issueInfo_Panel.Controls.Add(this.issues_combo);
            this.issueInfo_Panel.Controls.Add(this.date_text);
            this.issueInfo_Panel.Controls.Add(this.isssueType_label);
            this.issueInfo_Panel.Controls.Add(this.date_label);
            this.issueInfo_Panel.Controls.Add(this.description_text);
            this.issueInfo_Panel.Controls.Add(this.description_label);
            this.issueInfo_Panel.Location = new System.Drawing.Point(59, 282);
            this.issueInfo_Panel.Name = "issueInfo_Panel";
            this.issueInfo_Panel.Size = new System.Drawing.Size(400, 253);
            this.issueInfo_Panel.TabIndex = 2;
            // 
            // issues_combo
            // 
            this.issues_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issues_combo.FormattingEnabled = true;
            this.issues_combo.Location = new System.Drawing.Point(132, 168);
            this.issues_combo.Name = "issues_combo";
            this.issues_combo.Size = new System.Drawing.Size(241, 28);
            this.issues_combo.TabIndex = 7;
            // 
            // date_text
            // 
            this.date_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_text.Location = new System.Drawing.Point(132, 209);
            this.date_text.Name = "date_text";
            this.date_text.ReadOnly = true;
            this.date_text.Size = new System.Drawing.Size(241, 30);
            this.date_text.TabIndex = 6;
            // 
            // isssueType_label
            // 
            this.isssueType_label.AutoSize = true;
            this.isssueType_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isssueType_label.Location = new System.Drawing.Point(19, 171);
            this.isssueType_label.Name = "isssueType_label";
            this.isssueType_label.Size = new System.Drawing.Size(95, 20);
            this.isssueType_label.TabIndex = 3;
            this.isssueType_label.Text = "Issue Type:";
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_label.Location = new System.Drawing.Point(0, 216);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(114, 20);
            this.date_label.TabIndex = 2;
            this.date_label.Text = "Date Created:";
            // 
            // description_text
            // 
            this.description_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_text.Location = new System.Drawing.Point(132, 15);
            this.description_text.MaximumSize = new System.Drawing.Size(300, 300);
            this.description_text.Multiline = true;
            this.description_text.Name = "description_text";
            this.description_text.ReadOnly = true;
            this.description_text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.description_text.Size = new System.Drawing.Size(241, 137);
            this.description_text.TabIndex = 1;
            this.description_text.Text = "Description";
            // 
            // description_label
            // 
            this.description_label.AutoSize = true;
            this.description_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_label.Location = new System.Drawing.Point(14, 15);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(100, 20);
            this.description_label.TabIndex = 0;
            this.description_label.Text = "Description:";
            // 
            // actions_panel
            // 
            this.actions_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.actions_panel.Controls.Add(this.submit_button);
            this.actions_panel.Controls.Add(this.actionSubmit_text);
            this.actions_panel.Controls.Add(this.actions_text);
            this.actions_panel.Location = new System.Drawing.Point(484, 126);
            this.actions_panel.Name = "actions_panel";
            this.actions_panel.Size = new System.Drawing.Size(331, 409);
            this.actions_panel.TabIndex = 3;
            // 
            // submit_button
            // 
            this.submit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_button.Location = new System.Drawing.Point(275, 373);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(34, 26);
            this.submit_button.TabIndex = 10;
            this.submit_button.Text = "S";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // actionSubmit_text
            // 
            this.actionSubmit_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionSubmit_text.Location = new System.Drawing.Point(13, 373);
            this.actionSubmit_text.Name = "actionSubmit_text";
            this.actionSubmit_text.Size = new System.Drawing.Size(256, 26);
            this.actionSubmit_text.TabIndex = 9;
            // 
            // actions_text
            // 
            this.actions_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actions_text.Location = new System.Drawing.Point(13, 12);
            this.actions_text.MaximumSize = new System.Drawing.Size(300, 400);
            this.actions_text.Multiline = true;
            this.actions_text.Name = "actions_text";
            this.actions_text.ReadOnly = true;
            this.actions_text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.actions_text.Size = new System.Drawing.Size(296, 352);
            this.actions_text.TabIndex = 8;
            this.actions_text.Text = "Actions";
            // 
            // actions_label
            // 
            this.actions_label.AutoSize = true;
            this.actions_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actions_label.Location = new System.Drawing.Point(493, 114);
            this.actions_label.Name = "actions_label";
            this.actions_label.Size = new System.Drawing.Size(77, 25);
            this.actions_label.TabIndex = 0;
            this.actions_label.Text = "Actions";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(192, 560);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(267, 26);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // remind_label
            // 
            this.remind_label.AutoSize = true;
            this.remind_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remind_label.Location = new System.Drawing.Point(80, 565);
            this.remind_label.Name = "remind_label";
            this.remind_label.Size = new System.Drawing.Size(86, 20);
            this.remind_label.TabIndex = 5;
            this.remind_label.Text = "Reminder:";
            // 
            // save_button
            // 
            this.save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_button.Location = new System.Drawing.Point(484, 561);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(331, 35);
            this.save_button.TabIndex = 6;
            this.save_button.Text = "Save Changes";
            this.save_button.UseVisualStyleBackColor = true;
            // 
            // reminder_enable
            // 
            this.reminder_enable.AutoSize = true;
            this.reminder_enable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reminder_enable.Location = new System.Drawing.Point(59, 568);
            this.reminder_enable.MaximumSize = new System.Drawing.Size(25, 25);
            this.reminder_enable.Name = "reminder_enable";
            this.reminder_enable.Size = new System.Drawing.Size(18, 17);
            this.reminder_enable.TabIndex = 7;
            this.reminder_enable.UseVisualStyleBackColor = true;
            this.reminder_enable.CheckedChanged += new System.EventHandler(this.reminder_enable_CheckedChanged);
            // 
            // ManageIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 602);
            this.Controls.Add(this.reminder_enable);
            this.Controls.Add(this.actions_label);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.remind_label);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.actions_panel);
            this.Controls.Add(this.issueInfo_Panel);
            this.Controls.Add(this.issuedBy_panel);
            this.Controls.Add(this.issuer_panel);
            this.Name = "ManageIssue";
            this.Text = "ManageIssue";
            this.Load += new System.EventHandler(this.ManageIssue_Load);
            this.issuer_panel.ResumeLayout(false);
            this.issuer_panel.PerformLayout();
            this.issuedBy_panel.ResumeLayout(false);
            this.issuedBy_panel.PerformLayout();
            this.issueInfo_Panel.ResumeLayout(false);
            this.issueInfo_Panel.PerformLayout();
            this.actions_panel.ResumeLayout(false);
            this.actions_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel issuer_panel;
        private System.Windows.Forms.Label tel_label;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Panel issuedBy_panel;
        private System.Windows.Forms.Panel issueInfo_Panel;
        private System.Windows.Forms.TextBox tel_text;
        private System.Windows.Forms.TextBox id_text;
        private System.Windows.Forms.TextBox name_text;
        private System.Windows.Forms.Label statusShow_label;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.Label creator_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.ComboBox issues_combo;
        private System.Windows.Forms.TextBox date_text;
        private System.Windows.Forms.Label isssueType_label;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.TextBox description_text;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.Panel actions_panel;
        private System.Windows.Forms.TextBox actions_text;
        private System.Windows.Forms.Label actions_label;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label remind_label;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button toggle_but;
        private System.Windows.Forms.CheckBox reminder_enable;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.TextBox actionSubmit_text;
    }
}