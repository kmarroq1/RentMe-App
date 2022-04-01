
namespace RentMe_App.UserControls
{
    partial class DashboardHeaderUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardHeaderUserControl));
            this.logoutTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.logoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.userDetailsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.employeeNameLabelLabel = new System.Windows.Forms.Label();
            this.dividerLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameLabelLabel = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.logoutTableLayoutPanel.SuspendLayout();
            this.userDetailsFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // logoutTableLayoutPanel
            // 
            this.logoutTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutTableLayoutPanel.AutoSize = true;
            this.logoutTableLayoutPanel.ColumnCount = 1;
            this.logoutTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.logoutTableLayoutPanel.Controls.Add(this.logoutLinkLabel, 0, 1);
            this.logoutTableLayoutPanel.Controls.Add(this.userDetailsFlowLayoutPanel, 0, 0);
            this.logoutTableLayoutPanel.Location = new System.Drawing.Point(234, 3);
            this.logoutTableLayoutPanel.Name = "logoutTableLayoutPanel";
            this.logoutTableLayoutPanel.RowCount = 2;
            this.logoutTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.logoutTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.logoutTableLayoutPanel.Size = new System.Drawing.Size(387, 77);
            this.logoutTableLayoutPanel.TabIndex = 0;
            // 
            // logoutLinkLabel
            // 
            this.logoutLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutLinkLabel.AutoSize = true;
            this.logoutLinkLabel.Location = new System.Drawing.Point(324, 39);
            this.logoutLinkLabel.Name = "logoutLinkLabel";
            this.logoutLinkLabel.Padding = new System.Windows.Forms.Padding(10);
            this.logoutLinkLabel.Size = new System.Drawing.Size(60, 33);
            this.logoutLinkLabel.TabIndex = 0;
            this.logoutLinkLabel.TabStop = true;
            this.logoutLinkLabel.Text = "Logout";
            this.logoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLinkLabel_LinkClicked);
            // 
            // userDetailsFlowLayoutPanel
            // 
            this.userDetailsFlowLayoutPanel.AutoSize = true;
            this.userDetailsFlowLayoutPanel.Controls.Add(this.employeeNameLabel);
            this.userDetailsFlowLayoutPanel.Controls.Add(this.employeeNameLabelLabel);
            this.userDetailsFlowLayoutPanel.Controls.Add(this.dividerLabel);
            this.userDetailsFlowLayoutPanel.Controls.Add(this.usernameLabel);
            this.userDetailsFlowLayoutPanel.Controls.Add(this.usernameLabelLabel);
            this.userDetailsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userDetailsFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.userDetailsFlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.userDetailsFlowLayoutPanel.Name = "userDetailsFlowLayoutPanel";
            this.userDetailsFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(10);
            this.userDetailsFlowLayoutPanel.Size = new System.Drawing.Size(381, 33);
            this.userDetailsFlowLayoutPanel.TabIndex = 1;
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.Location = new System.Drawing.Point(330, 10);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(28, 13);
            this.employeeNameLabel.TabIndex = 0;
            this.employeeNameLabel.Text = "XXX";
            // 
            // employeeNameLabelLabel
            // 
            this.employeeNameLabelLabel.AutoSize = true;
            this.employeeNameLabelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNameLabelLabel.Location = new System.Drawing.Point(223, 10);
            this.employeeNameLabelLabel.Name = "employeeNameLabelLabel";
            this.employeeNameLabelLabel.Size = new System.Drawing.Size(101, 13);
            this.employeeNameLabelLabel.TabIndex = 1;
            this.employeeNameLabelLabel.Text = "Employee Name:";
            // 
            // dividerLabel
            // 
            this.dividerLabel.AutoSize = true;
            this.dividerLabel.Location = new System.Drawing.Point(208, 10);
            this.dividerLabel.Name = "dividerLabel";
            this.dividerLabel.Size = new System.Drawing.Size(9, 13);
            this.dividerLabel.TabIndex = 2;
            this.dividerLabel.Text = "|";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(174, 10);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(28, 13);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "XXX";
            // 
            // usernameLabelLabel
            // 
            this.usernameLabelLabel.AutoSize = true;
            this.usernameLabelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabelLabel.Location = new System.Drawing.Point(101, 10);
            this.usernameLabelLabel.Name = "usernameLabelLabel";
            this.usernameLabelLabel.Size = new System.Drawing.Size(67, 13);
            this.usernameLabelLabel.TabIndex = 4;
            this.usernameLabelLabel.Text = "Username:";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(128, 128);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // DashboardHeaderUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.logoutTableLayoutPanel);
            this.Name = "DashboardHeaderUserControl";
            this.Size = new System.Drawing.Size(624, 135);
            this.Load += new System.EventHandler(this.DashboardHeaderUserControl_Load);
            this.logoutTableLayoutPanel.ResumeLayout(false);
            this.logoutTableLayoutPanel.PerformLayout();
            this.userDetailsFlowLayoutPanel.ResumeLayout(false);
            this.userDetailsFlowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel logoutTableLayoutPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.LinkLabel logoutLinkLabel;
        private System.Windows.Forms.FlowLayoutPanel userDetailsFlowLayoutPanel;
        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.Label employeeNameLabelLabel;
        private System.Windows.Forms.Label dividerLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label usernameLabelLabel;
    }
}
