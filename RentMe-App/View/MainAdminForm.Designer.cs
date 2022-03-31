
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.personnelTabPage = new System.Windows.Forms.TabPage();
            this.reportsTabPage = new System.Windows.Forms.TabPage();
            this.searchEmployeeUserControl1 = new RentMe_App.UserControls.SearchEmployeeUserControl();
            this.tabControl1.SuspendLayout();
            this.personnelTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.personnelTabPage);
            this.tabControl1.Controls.Add(this.reportsTabPage);
            this.tabControl1.Location = new System.Drawing.Point(1, 53);
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
            // reportsTabPage
            // 
            this.reportsTabPage.Location = new System.Drawing.Point(4, 22);
            this.reportsTabPage.Name = "reportsTabPage";
            this.reportsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.reportsTabPage.Size = new System.Drawing.Size(901, 541);
            this.reportsTabPage.TabIndex = 1;
            this.reportsTabPage.Text = "Reports";
            this.reportsTabPage.UseVisualStyleBackColor = true;
            // 
            // searchEmployeeUserControl1
            // 
            this.searchEmployeeUserControl1.Location = new System.Drawing.Point(8, 15);
            this.searchEmployeeUserControl1.Name = "searchEmployeeUserControl1";
            this.searchEmployeeUserControl1.Size = new System.Drawing.Size(800, 500);
            this.searchEmployeeUserControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 608);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl1.ResumeLayout(false);
            this.personnelTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage personnelTabPage;
        private System.Windows.Forms.TabPage reportsTabPage;
        private UserControls.SearchEmployeeUserControl searchEmployeeUserControl1;
    }
}