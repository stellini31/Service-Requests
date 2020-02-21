namespace Service_Requests.UI
{
    partial class MainApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApp));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.column1_label = new System.Windows.Forms.Label();
            this.column4_label = new System.Windows.Forms.Label();
            this.column3_label = new System.Windows.Forms.Label();
            this.column2_label = new System.Windows.Forms.Label();
            this.tablePanel = new System.Windows.Forms.Panel();
            this.create_issue_button = new System.Windows.Forms.Button();
            this.refresh_button = new System.Windows.Forms.Button();
            this.search_text = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.column1_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.column4_label, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.column3_label, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.column2_label, 1, 0);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1097, 613);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // column1_label
            // 
            this.column1_label.AutoSize = true;
            this.column1_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.column1_label.Location = new System.Drawing.Point(4, 1);
            this.column1_label.Name = "column1_label";
            this.column1_label.Size = new System.Drawing.Size(49, 25);
            this.column1_label.TabIndex = 4;
            this.column1_label.Text = "Title";
            // 
            // column4_label
            // 
            this.column4_label.AutoSize = true;
            this.column4_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.column4_label.Location = new System.Drawing.Point(826, 1);
            this.column4_label.Name = "column4_label";
            this.column4_label.Size = new System.Drawing.Size(128, 25);
            this.column4_label.TabIndex = 3;
            this.column4_label.Text = "Date Created";
            // 
            // column3_label
            // 
            this.column3_label.AutoSize = true;
            this.column3_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.column3_label.Location = new System.Drawing.Point(552, 1);
            this.column3_label.Name = "column3_label";
            this.column3_label.Size = new System.Drawing.Size(109, 25);
            this.column3_label.TabIndex = 2;
            this.column3_label.Text = "Issue Type";
            // 
            // column2_label
            // 
            this.column2_label.AutoSize = true;
            this.column2_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.column2_label.Location = new System.Drawing.Point(278, 1);
            this.column2_label.Name = "column2_label";
            this.column2_label.Size = new System.Drawing.Size(97, 25);
            this.column2_label.TabIndex = 1;
            this.column2_label.Text = "Comment";
            // 
            // tablePanel
            // 
            this.tablePanel.Controls.Add(this.tableLayoutPanel1);
            this.tablePanel.Location = new System.Drawing.Point(12, 84);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Size = new System.Drawing.Size(1097, 613);
            this.tablePanel.TabIndex = 2;
            // 
            // create_issue_button
            // 
            this.create_issue_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_issue_button.Location = new System.Drawing.Point(25, 9);
            this.create_issue_button.Name = "create_issue_button";
            this.create_issue_button.Size = new System.Drawing.Size(312, 69);
            this.create_issue_button.TabIndex = 3;
            this.create_issue_button.Text = "Create Issue";
            this.create_issue_button.UseVisualStyleBackColor = true;
            this.create_issue_button.Click += new System.EventHandler(this.create_issue_button_Click);
            // 
            // refresh_button
            // 
            this.refresh_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refresh_button.BackgroundImage")));
            this.refresh_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refresh_button.Location = new System.Drawing.Point(1057, 32);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(35, 35);
            this.refresh_button.TabIndex = 4;
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // search_text
            // 
            this.search_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_text.Location = new System.Drawing.Point(527, 32);
            this.search_text.Name = "search_text";
            this.search_text.Size = new System.Drawing.Size(201, 26);
            this.search_text.TabIndex = 5;
            this.search_text.Tag = "";
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(734, 32);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(82, 25);
            this.search_button.TabIndex = 6;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 718);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.search_text);
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.tablePanel);
            this.Controls.Add(this.create_issue_button);
            this.Name = "MainApp";
            this.Text = "MainApp";
            this.Load += new System.EventHandler(this.MainApp_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tablePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label column4_label;
        private System.Windows.Forms.Label column3_label;
        private System.Windows.Forms.Label column2_label;
        private System.Windows.Forms.Panel tablePanel;
        private System.Windows.Forms.Button create_issue_button;
        private System.Windows.Forms.Label column1_label;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.TextBox search_text;
        private System.Windows.Forms.Button search_button;
    }
}