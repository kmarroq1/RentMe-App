
namespace RentMe_App
{
    partial class MainAdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAdminForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.personnelTabPage = new System.Windows.Forms.TabPage();
            this.searchEmployeeUserControl1 = new RentMe_App.UserControls.SearchEmployeeUserControl();
            this.reportsTabPage = new System.Windows.Forms.TabPage();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.employeeNameValueLabel = new System.Windows.Forms.Label();
            this.logoutLabel = new System.Windows.Forms.LinkLabel();
            this.labelFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameValueLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.personnelTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.labelFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.personnelTabPage);
            this.tabControl1.Controls.Add(this.reportsTabPage);
            this.tabControl1.Location = new System.Drawing.Point(3, 102);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(837, 557);
            this.tabControl1.TabIndex = 0;
            // 
            // personnelTabPage
            // 
            this.personnelTabPage.Controls.Add(this.searchEmployeeUserControl1);
            this.personnelTabPage.Location = new System.Drawing.Point(4, 22);
            this.personnelTabPage.Name = "personnelTabPage";
            this.personnelTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.personnelTabPage.Size = new System.Drawing.Size(829, 531);
            this.personnelTabPage.TabIndex = 0;
            this.personnelTabPage.Text = "Personnel";
            this.personnelTabPage.UseVisualStyleBackColor = true;
            // 
            // searchEmployeeUserControl1
            // 
            this.searchEmployeeUserControl1.Location = new System.Drawing.Point(8, 15);
            this.searchEmployeeUserControl1.Name = "searchEmployeeUserControl1";
            this.searchEmployeeUserControl1.Size = new System.Drawing.Size(800, 500);
            this.searchEmployeeUserControl1.TabIndex = 0;
            // 
            // reportsTabPage
            // 
            this.reportsTabPage.Location = new System.Drawing.Point(4, 22);
            this.reportsTabPage.Name = "reportsTabPage";
            this.reportsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.reportsTabPage.Size = new System.Drawing.Size(829, 531);
            this.reportsTabPage.TabIndex = 1;
            this.reportsTabPage.Text = "Reports";
            this.reportsTabPage.UseVisualStyleBackColor = true;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(2, 2);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(102, 89);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 7;
            this.logoPictureBox.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.logoutLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelFlowLayoutPanel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(233, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(591, 66);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.employeeNameLabel);
            this.flowLayoutPanel1.Controls.Add(this.employeeNameValueLabel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(462, 25);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(126, 16);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNameLabel.Location = new System.Drawing.Point(3, 0);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(101, 13);
            this.employeeNameLabel.TabIndex = 3;
            this.employeeNameLabel.Text = "Employee Name:";
            // 
            // employeeNameValueLabel
            // 
            this.employeeNameValueLabel.AutoSize = true;
            this.employeeNameValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNameValueLabel.Location = new System.Drawing.Point(110, 0);
            this.employeeNameValueLabel.Name = "employeeNameValueLabel";
            this.employeeNameValueLabel.Size = new System.Drawing.Size(13, 13);
            this.employeeNameValueLabel.TabIndex = 4;
            this.employeeNameValueLabel.Text = "  ";
            // 
            // logoutLabel
            // 
            this.logoutLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutLabel.AutoSize = true;
            this.logoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLabel.Location = new System.Drawing.Point(545, 44);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.logoutLabel.Size = new System.Drawing.Size(43, 22);
            this.logoutLabel.TabIndex = 7;
            this.logoutLabel.TabStop = true;
            this.logoutLabel.Text = "Logout";
            this.logoutLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLabel_LinkClicked);
            // 
            // labelFlowLayoutPanel
            // 
            this.labelFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFlowLayoutPanel.AutoSize = true;
            this.labelFlowLayoutPanel.Controls.Add(this.usernameLabel);
            this.labelFlowLayoutPanel.Controls.Add(this.usernameValueLabel);
            this.labelFlowLayoutPanel.Location = new System.Drawing.Point(496, 3);
            this.labelFlowLayoutPanel.Name = "labelFlowLayoutPanel";
            this.labelFlowLayoutPanel.Size = new System.Drawing.Size(92, 16);
            this.labelFlowLayoutPanel.TabIndex = 8;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(3, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(67, 13);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username:";
            // 
            // usernameValueLabel
            // 
            this.usernameValueLabel.AutoSize = true;
            this.usernameValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameValueLabel.Location = new System.Drawing.Point(76, 0);
            this.usernameValueLabel.Name = "usernameValueLabel";
            this.usernameValueLabel.Size = new System.Drawing.Size(13, 13);
            this.usernameValueLabel.TabIndex = 1;
            this.usernameValueLabel.Text = "  ";
            // 
            // MainAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 661);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainAdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentMe: Admin Access";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainAdminForm_FormClosing);
            this.Load += new System.EventHandler(this.MainAdminForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.personnelTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.labelFlowLayoutPanel.ResumeLayout(false);
            this.labelFlowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage personnelTabPage;
        private System.Windows.Forms.TabPage reportsTabPage;
        private UserControls.SearchEmployeeUserControl searchEmployeeUserControl1;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.Label employeeNameValueLabel;
        private System.Windows.Forms.LinkLabel logoutLabel;
        private System.Windows.Forms.FlowLayoutPanel labelFlowLayoutPanel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label usernameValueLabel;
    }
}