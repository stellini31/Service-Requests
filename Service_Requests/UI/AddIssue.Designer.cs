namespace Service_Requests.UI
{
    partial class AddIssue
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
            this.save_butoon = new System.Windows.Forms.Button();
            this.comment_text = new System.Windows.Forms.TextBox();
            this.issueType_combo = new System.Windows.Forms.ComboBox();
            this.issuerTel_text = new System.Windows.Forms.TextBox();
            this.issuerName_text = new System.Windows.Forms.TextBox();
            this.issuerID_text = new System.Windows.Forms.TextBox();
            this.title_text = new System.Windows.Forms.TextBox();
            this.pageTitle_label = new System.Windows.Forms.Label();
            this.text_panel = new System.Windows.Forms.Panel();
            this.issuerTel_label = new System.Windows.Forms.Label();
            this.issuerName_label = new System.Windows.Forms.Label();
            this.issuerID_label = new System.Windows.Forms.Label();
            this.issueType_label = new System.Windows.Forms.Label();
            this.comment_label = new System.Windows.Forms.Label();
            this.title_label = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labels_panel = new System.Windows.Forms.Panel();
            this.text_panel.SuspendLayout();
            this.labels_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // save_butoon
            // 
            this.save_butoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_butoon.Location = new System.Drawing.Point(177, 512);
            this.save_butoon.Name = "save_butoon";
            this.save_butoon.Size = new System.Drawing.Size(192, 39);
            this.save_butoon.TabIndex = 8;
            this.save_butoon.Text = "Save";
            this.save_butoon.UseVisualStyleBackColor = true;
            this.save_butoon.Click += new System.EventHandler(this.save_butoon_Click);
            // 
            // comment_text
            // 
            this.comment_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comment_text.Location = new System.Drawing.Point(0, 110);
            this.comment_text.Multiline = true;
            this.comment_text.Name = "comment_text";
            this.comment_text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.comment_text.Size = new System.Drawing.Size(255, 106);
            this.comment_text.TabIndex = 5;
            // 
            // issueType_combo
            // 
            this.issueType_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueType_combo.FormattingEnabled = true;
            this.issueType_combo.Location = new System.Drawing.Point(0, 57);
            this.issueType_combo.Name = "issueType_combo";
            this.issueType_combo.Size = new System.Drawing.Size(255, 28);
            this.issueType_combo.TabIndex = 4;
            // 
            // issuerTel_text
            // 
            this.issuerTel_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuerTel_text.Location = new System.Drawing.Point(0, 300);
            this.issuerTel_text.Name = "issuerTel_text";
            this.issuerTel_text.Size = new System.Drawing.Size(255, 26);
            this.issuerTel_text.TabIndex = 3;
            // 
            // issuerName_text
            // 
            this.issuerName_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuerName_text.Location = new System.Drawing.Point(0, 266);
            this.issuerName_text.Name = "issuerName_text";
            this.issuerName_text.Size = new System.Drawing.Size(255, 26);
            this.issuerName_text.TabIndex = 2;
            // 
            // issuerID_text
            // 
            this.issuerID_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuerID_text.Location = new System.Drawing.Point(0, 230);
            this.issuerID_text.Name = "issuerID_text";
            this.issuerID_text.Size = new System.Drawing.Size(255, 26);
            this.issuerID_text.TabIndex = 1;
            // 
            // title_text
            // 
            this.title_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_text.Location = new System.Drawing.Point(0, 12);
            this.title_text.Name = "title_text";
            this.title_text.Size = new System.Drawing.Size(255, 26);
            this.title_text.TabIndex = 0;
            // 
            // pageTitle_label
            // 
            this.pageTitle_label.AutoSize = true;
            this.pageTitle_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageTitle_label.Location = new System.Drawing.Point(51, 21);
            this.pageTitle_label.Name = "pageTitle_label";
            this.pageTitle_label.Size = new System.Drawing.Size(123, 25);
            this.pageTitle_label.TabIndex = 7;
            this.pageTitle_label.Text = "Create Issue";
            // 
            // text_panel
            // 
            this.text_panel.Controls.Add(this.comment_text);
            this.text_panel.Controls.Add(this.issueType_combo);
            this.text_panel.Controls.Add(this.issuerTel_text);
            this.text_panel.Controls.Add(this.issuerName_text);
            this.text_panel.Controls.Add(this.issuerID_text);
            this.text_panel.Controls.Add(this.title_text);
            this.text_panel.Location = new System.Drawing.Point(239, 85);
            this.text_panel.Name = "text_panel";
            this.text_panel.Size = new System.Drawing.Size(259, 366);
            this.text_panel.TabIndex = 6;
            // 
            // issuerTel_label
            // 
            this.issuerTel_label.AutoSize = true;
            this.issuerTel_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuerTel_label.Location = new System.Drawing.Point(-1, 291);
            this.issuerTel_label.Name = "issuerTel_label";
            this.issuerTel_label.Size = new System.Drawing.Size(142, 20);
            this.issuerTel_label.TabIndex = 6;
            this.issuerTel_label.Text = "Issuer Telephone:";
            // 
            // issuerName_label
            // 
            this.issuerName_label.AutoSize = true;
            this.issuerName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuerName_label.Location = new System.Drawing.Point(30, 257);
            this.issuerName_label.Name = "issuerName_label";
            this.issuerName_label.Size = new System.Drawing.Size(109, 20);
            this.issuerName_label.TabIndex = 5;
            this.issuerName_label.Text = "Issuer Name:";
            // 
            // issuerID_label
            // 
            this.issuerID_label.AutoSize = true;
            this.issuerID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuerID_label.Location = new System.Drawing.Point(57, 221);
            this.issuerID_label.Name = "issuerID_label";
            this.issuerID_label.Size = new System.Drawing.Size(82, 20);
            this.issuerID_label.TabIndex = 4;
            this.issuerID_label.Text = "Issuer ID:";
            // 
            // issueType_label
            // 
            this.issueType_label.AutoSize = true;
            this.issueType_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueType_label.Location = new System.Drawing.Point(44, 48);
            this.issueType_label.Name = "issueType_label";
            this.issueType_label.Size = new System.Drawing.Size(95, 20);
            this.issueType_label.TabIndex = 3;
            this.issueType_label.Text = "Issue Type:";
            // 
            // comment_label
            // 
            this.comment_label.AutoSize = true;
            this.comment_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comment_label.Location = new System.Drawing.Point(53, 95);
            this.comment_label.Name = "comment_label";
            this.comment_label.Size = new System.Drawing.Size(86, 20);
            this.comment_label.TabIndex = 2;
            this.comment_label.Text = "Comment:";
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.Location = new System.Drawing.Point(93, -1);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(46, 20);
            this.title_label.TabIndex = 1;
            this.title_label.Text = "Title:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(144, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(18, 15);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // labels_panel
            // 
            this.labels_panel.Controls.Add(this.issuerTel_label);
            this.labels_panel.Controls.Add(this.issuerName_label);
            this.labels_panel.Controls.Add(this.issuerID_label);
            this.labels_panel.Controls.Add(this.issueType_label);
            this.labels_panel.Controls.Add(this.comment_label);
            this.labels_panel.Controls.Add(this.title_label);
            this.labels_panel.Controls.Add(this.flowLayoutPanel1);
            this.labels_panel.Location = new System.Drawing.Point(53, 97);
            this.labels_panel.Name = "labels_panel";
            this.labels_panel.Size = new System.Drawing.Size(139, 354);
            this.labels_panel.TabIndex = 5;
            // 
            // AddIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 570);
            this.Controls.Add(this.save_butoon);
            this.Controls.Add(this.pageTitle_label);
            this.Controls.Add(this.text_panel);
            this.Controls.Add(this.labels_panel);
            this.Name = "AddIssue";
            this.Text = "AddIssue";
            this.Load += new System.EventHandler(this.AddIssue_Load);
            this.text_panel.ResumeLayout(false);
            this.text_panel.PerformLayout();
            this.labels_panel.ResumeLayout(false);
            this.labels_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save_butoon;
        private System.Windows.Forms.TextBox comment_text;
        private System.Windows.Forms.ComboBox issueType_combo;
        private System.Windows.Forms.TextBox issuerTel_text;
        private System.Windows.Forms.TextBox issuerName_text;
        private System.Windows.Forms.TextBox issuerID_text;
        private System.Windows.Forms.TextBox title_text;
        private System.Windows.Forms.Label pageTitle_label;
        private System.Windows.Forms.Panel text_panel;
        private System.Windows.Forms.Label issuerTel_label;
        private System.Windows.Forms.Label issuerName_label;
        private System.Windows.Forms.Label issuerID_label;
        private System.Windows.Forms.Label issueType_label;
        private System.Windows.Forms.Label comment_label;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel labels_panel;
    }
}