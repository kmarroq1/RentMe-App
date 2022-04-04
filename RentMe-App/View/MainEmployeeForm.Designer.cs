
namespace RentMe_App.View
{
    partial class MainEmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainEmployeeForm));
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.addMemberTabPage = new System.Windows.Forms.TabPage();
            this.addMemberUserControl1 = new RentMe_App.UserControls.AddMemberUserControl();
            this.searchMembersTabPage = new System.Windows.Forms.TabPage();
            this.searchMemberUserControl1 = new RentMe_App.UserControls.SearchMemberUserControl();
            this.searchFurnitureTab = new System.Windows.Forms.TabPage();
            this.searchFurnitureUserControl1 = new RentMe_App.UserControls.SearchFurnitureUserControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.employeeNameValueLabel = new System.Windows.Forms.Label();
            this.logoutLabel = new System.Windows.Forms.LinkLabel();
            this.labelFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameValueLabel = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.mainTabControl.SuspendLayout();
            this.addMemberTabPage.SuspendLayout();
            this.searchMembersTabPage.SuspendLayout();
            this.searchFurnitureTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.labelFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.addMemberTabPage);
            this.mainTabControl.Controls.Add(this.searchMembersTabPage);
            this.mainTabControl.Controls.Add(this.searchFurnitureTab);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainTabControl.Location = new System.Drawing.Point(0, 107);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(836, 554);
            this.mainTabControl.TabIndex = 0;
            // 
            // addMemberTabPage
            // 
            this.addMemberTabPage.Controls.Add(this.addMemberUserControl1);
            this.addMemberTabPage.Location = new System.Drawing.Point(4, 22);
            this.addMemberTabPage.Name = "addMemberTabPage";
            this.addMemberTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addMemberTabPage.Size = new System.Drawing.Size(828, 528);
            this.addMemberTabPage.TabIndex = 0;
            this.addMemberTabPage.Text = "Add Member";
            this.addMemberTabPage.UseVisualStyleBackColor = true;
            // 
            // addMemberUserControl1
            // 
            this.addMemberUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addMemberUserControl1.Location = new System.Drawing.Point(3, 3);
            this.addMemberUserControl1.Name = "addMemberUserControl1";
            this.addMemberUserControl1.Size = new System.Drawing.Size(822, 522);
            this.addMemberUserControl1.TabIndex = 0;
            this.addMemberUserControl1.Load += new System.EventHandler(this.AddMemberUserControl1_Load);
            // 
            // searchMembersTabPage
            // 
            this.searchMembersTabPage.Controls.Add(this.searchMemberUserControl1);
            this.searchMembersTabPage.Location = new System.Drawing.Point(4, 22);
            this.searchMembersTabPage.Name = "searchMembersTabPage";
            this.searchMembersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.searchMembersTabPage.Size = new System.Drawing.Size(828, 528);
            this.searchMembersTabPage.TabIndex = 1;
            this.searchMembersTabPage.Text = "Search Members";
            this.searchMembersTabPage.UseVisualStyleBackColor = true;
            // 
            // searchMemberUserControl1
            // 
            this.searchMemberUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchMemberUserControl1.Location = new System.Drawing.Point(3, 3);
            this.searchMemberUserControl1.Name = "searchMemberUserControl1";
            this.searchMemberUserControl1.Size = new System.Drawing.Size(822, 522);
            this.searchMemberUserControl1.TabIndex = 0;
            // 
            // searchFurnitureTab
            // 
            this.searchFurnitureTab.Controls.Add(this.searchFurnitureUserControl1);
            this.searchFurnitureTab.Location = new System.Drawing.Point(4, 22);
            this.searchFurnitureTab.Name = "searchFurnitureTab";
            this.searchFurnitureTab.Padding = new System.Windows.Forms.Padding(3);
            this.searchFurnitureTab.Size = new System.Drawing.Size(828, 528);
            this.searchFurnitureTab.TabIndex = 2;
            this.searchFurnitureTab.Text = "Search Furniture";
            this.searchFurnitureTab.UseVisualStyleBackColor = true;
            // 
            // searchFurnitureUserControl1
            // 
            this.searchFurnitureUserControl1.Location = new System.Drawing.Point(5, 5);
            this.searchFurnitureUserControl1.Name = "searchFurnitureUserControl1";
            this.searchFurnitureUserControl1.Size = new System.Drawing.Size(823, 523);
            this.searchFurnitureUserControl1.TabIndex = 0;
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
            this.tableLayoutPanel1.TabIndex = 10;
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
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(1, 0);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(102, 89);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 11;
            this.logoPictureBox.TabStop = false;
            // 
            // MainEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 661);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainEmployeeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainEmployeeForm_FormClosing);
            this.Load += new System.EventHandler(this.MainEmployeeForm_Load);
            this.mainTabControl.ResumeLayout(false);
            this.addMemberTabPage.ResumeLayout(false);
            this.searchMembersTabPage.ResumeLayout(false);
            this.searchFurnitureTab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.labelFlowLayoutPanel.ResumeLayout(false);
            this.labelFlowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage addMemberTabPage;
        private System.Windows.Forms.TabPage searchMembersTabPage;
        private UserControls.AddMemberUserControl addMemberUserControl1;
        private UserControls.SearchMemberUserControl searchMemberUserControl1;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.LinkLabel logoutLabel;
        private System.Windows.Forms.FlowLayoutPanel labelFlowLayoutPanel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label usernameValueLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.Label employeeNameValueLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.TabPage searchFurnitureTab;
        private UserControls.SearchFurnitureUserControl searchFurnitureUserControl1;
    }
}