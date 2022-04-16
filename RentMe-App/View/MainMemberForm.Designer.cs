
namespace RentMe_App.View
{
    partial class MainMemberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMemberForm));
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.inventoryTabPage = new System.Windows.Forms.TabPage();
            this.orderAndReturnsTabPage = new System.Windows.Forms.TabPage();
            this.rentalCartTabPage = new System.Windows.Forms.TabPage();
            this.returnCartTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.employeeNameValueLabel = new System.Windows.Forms.Label();
            this.logoutLabel = new System.Windows.Forms.LinkLabel();
            this.labelFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameValueLabel = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.memberIDFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.memberIDLabel = new System.Windows.Forms.Label();
            this.memberIDValueLabel = new System.Windows.Forms.Label();
            this.ordersAndReturnsUserControl1 = new RentMe_App.UserControls.MemberDashboardUCs.OrdersAndReturnsUserControl();
            this.mainTabControl.SuspendLayout();
            this.orderAndReturnsTabPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.labelFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.memberIDFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.inventoryTabPage);
            this.mainTabControl.Controls.Add(this.orderAndReturnsTabPage);
            this.mainTabControl.Controls.Add(this.rentalCartTabPage);
            this.mainTabControl.Controls.Add(this.returnCartTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainTabControl.Location = new System.Drawing.Point(0, 133);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(836, 528);
            this.mainTabControl.TabIndex = 12;
            // 
            // inventoryTabPage
            // 
            this.inventoryTabPage.Location = new System.Drawing.Point(4, 22);
            this.inventoryTabPage.Name = "inventoryTabPage";
            this.inventoryTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.inventoryTabPage.Size = new System.Drawing.Size(828, 502);
            this.inventoryTabPage.TabIndex = 0;
            this.inventoryTabPage.Text = "Inventory";
            this.inventoryTabPage.UseVisualStyleBackColor = true;
            // 
            // orderAndReturnsTabPage
            // 
            this.orderAndReturnsTabPage.Controls.Add(this.ordersAndReturnsUserControl1);
            this.orderAndReturnsTabPage.Location = new System.Drawing.Point(4, 22);
            this.orderAndReturnsTabPage.Name = "orderAndReturnsTabPage";
            this.orderAndReturnsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.orderAndReturnsTabPage.Size = new System.Drawing.Size(828, 502);
            this.orderAndReturnsTabPage.TabIndex = 1;
            this.orderAndReturnsTabPage.Text = "Orders & Returns";
            this.orderAndReturnsTabPage.UseVisualStyleBackColor = true;
            // 
            // rentalCartTabPage
            // 
            this.rentalCartTabPage.Location = new System.Drawing.Point(4, 22);
            this.rentalCartTabPage.Name = "rentalCartTabPage";
            this.rentalCartTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.rentalCartTabPage.Size = new System.Drawing.Size(828, 502);
            this.rentalCartTabPage.TabIndex = 2;
            this.rentalCartTabPage.Text = "Rental Cart";
            this.rentalCartTabPage.UseVisualStyleBackColor = true;
            // 
            // returnCartTabPage
            // 
            this.returnCartTabPage.Location = new System.Drawing.Point(4, 22);
            this.returnCartTabPage.Name = "returnCartTabPage";
            this.returnCartTabPage.Size = new System.Drawing.Size(828, 502);
            this.returnCartTabPage.TabIndex = 3;
            this.returnCartTabPage.Text = "Return Cart";
            this.returnCartTabPage.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel1.TabIndex = 13;
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
            this.logoPictureBox.TabIndex = 14;
            this.logoPictureBox.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.memberIDFlowLayoutPanel, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 95);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(836, 25);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // memberIDFlowLayoutPanel
            // 
            this.memberIDFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.memberIDFlowLayoutPanel.AutoSize = true;
            this.memberIDFlowLayoutPanel.Controls.Add(this.memberIDLabel);
            this.memberIDFlowLayoutPanel.Controls.Add(this.memberIDValueLabel);
            this.memberIDFlowLayoutPanel.Location = new System.Drawing.Point(369, 3);
            this.memberIDFlowLayoutPanel.Name = "memberIDFlowLayoutPanel";
            this.memberIDFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.memberIDFlowLayoutPanel.Size = new System.Drawing.Size(97, 19);
            this.memberIDFlowLayoutPanel.TabIndex = 10;
            // 
            // memberIDLabel
            // 
            this.memberIDLabel.AutoSize = true;
            this.memberIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberIDLabel.Location = new System.Drawing.Point(3, 3);
            this.memberIDLabel.Name = "memberIDLabel";
            this.memberIDLabel.Size = new System.Drawing.Size(72, 13);
            this.memberIDLabel.TabIndex = 3;
            this.memberIDLabel.Text = "Member ID:";
            // 
            // memberIDValueLabel
            // 
            this.memberIDValueLabel.AutoSize = true;
            this.memberIDValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberIDValueLabel.Location = new System.Drawing.Point(81, 3);
            this.memberIDValueLabel.Name = "memberIDValueLabel";
            this.memberIDValueLabel.Size = new System.Drawing.Size(13, 13);
            this.memberIDValueLabel.TabIndex = 4;
            this.memberIDValueLabel.Text = "  ";
            // 
            // ordersAndReturnsUserControl1
            // 
            this.ordersAndReturnsUserControl1.Location = new System.Drawing.Point(5, 5);
            this.ordersAndReturnsUserControl1.Margin = new System.Windows.Forms.Padding(1);
            this.ordersAndReturnsUserControl1.Name = "ordersAndReturnsUserControl1";
            this.ordersAndReturnsUserControl1.Size = new System.Drawing.Size(819, 493);
            this.ordersAndReturnsUserControl1.TabIndex = 0;
            // 
            // MainMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 661);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMemberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMemberForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMemberForm_FormClosing);
            this.Load += new System.EventHandler(this.MainMemberForm_Load);
            this.mainTabControl.ResumeLayout(false);
            this.orderAndReturnsTabPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.labelFlowLayoutPanel.ResumeLayout(false);
            this.labelFlowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.memberIDFlowLayoutPanel.ResumeLayout(false);
            this.memberIDFlowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage inventoryTabPage;
        private System.Windows.Forms.TabPage orderAndReturnsTabPage;
        private System.Windows.Forms.TabPage rentalCartTabPage;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.Label employeeNameValueLabel;
        private System.Windows.Forms.LinkLabel logoutLabel;
        private System.Windows.Forms.FlowLayoutPanel labelFlowLayoutPanel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label usernameValueLabel;
        private System.Windows.Forms.TabPage returnCartTabPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel memberIDFlowLayoutPanel;
        private System.Windows.Forms.Label memberIDLabel;
        private System.Windows.Forms.Label memberIDValueLabel;
        private UserControls.MemberDashboardUCs.OrdersAndReturnsUserControl ordersAndReturnsUserControl1;
    }
}