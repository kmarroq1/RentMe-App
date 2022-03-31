
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
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.addMemberTabPage = new System.Windows.Forms.TabPage();
            this.searchMembersTabPage = new System.Windows.Forms.TabPage();
            this.addMemberUserControl1 = new RentMe_App.UserControls.AddMemberUserControl();
            this.searchMemberUserControl1 = new RentMe_App.UserControls.SearchMemberUserControl();
            this.mainTabControl.SuspendLayout();
            this.addMemberTabPage.SuspendLayout();
            this.searchMembersTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.addMemberTabPage);
            this.mainTabControl.Controls.Add(this.searchMembersTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainTabControl.Location = new System.Drawing.Point(0, 73);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(836, 535);
            this.mainTabControl.TabIndex = 0;
            // 
            // addMemberTabPage
            // 
            this.addMemberTabPage.Controls.Add(this.addMemberUserControl1);
            this.addMemberTabPage.Location = new System.Drawing.Point(4, 22);
            this.addMemberTabPage.Name = "addMemberTabPage";
            this.addMemberTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addMemberTabPage.Size = new System.Drawing.Size(828, 509);
            this.addMemberTabPage.TabIndex = 0;
            this.addMemberTabPage.Text = "Add Member";
            this.addMemberTabPage.UseVisualStyleBackColor = true;
            // 
            // searchMembersTabPage
            // 
            this.searchMembersTabPage.Controls.Add(this.searchMemberUserControl1);
            this.searchMembersTabPage.Location = new System.Drawing.Point(4, 22);
            this.searchMembersTabPage.Name = "searchMembersTabPage";
            this.searchMembersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.searchMembersTabPage.Size = new System.Drawing.Size(828, 509);
            this.searchMembersTabPage.TabIndex = 1;
            this.searchMembersTabPage.Text = "Search Members";
            this.searchMembersTabPage.UseVisualStyleBackColor = true;
            // 
            // addMemberUserControl1
            // 
            this.addMemberUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addMemberUserControl1.Location = new System.Drawing.Point(3, 3);
            this.addMemberUserControl1.Name = "addMemberUserControl1";
            this.addMemberUserControl1.Size = new System.Drawing.Size(822, 503);
            this.addMemberUserControl1.TabIndex = 0;
            // 
            // searchMemberUserControl1
            // 
            this.searchMemberUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchMemberUserControl1.Location = new System.Drawing.Point(3, 3);
            this.searchMemberUserControl1.Name = "searchMemberUserControl1";
            this.searchMemberUserControl1.Size = new System.Drawing.Size(822, 503);
            this.searchMemberUserControl1.TabIndex = 0;
            // 
            // MainEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 608);
            this.Controls.Add(this.mainTabControl);
            this.Name = "MainEmployeeForm";
            this.Text = "MainEmployeeForm";
            this.mainTabControl.ResumeLayout(false);
            this.addMemberTabPage.ResumeLayout(false);
            this.searchMembersTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage addMemberTabPage;
        private System.Windows.Forms.TabPage searchMembersTabPage;
        private UserControls.AddMemberUserControl addMemberUserControl1;
        private UserControls.SearchMemberUserControl searchMemberUserControl1;
    }
}