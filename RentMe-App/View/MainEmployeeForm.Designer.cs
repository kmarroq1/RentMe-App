
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
            this.dashboardHeaderUserControl = new RentMe_App.UserControls.DashboardHeaderUserControl();
            this.SuspendLayout();
            // 
            // dashboardHeaderUserControl
            // 
            this.dashboardHeaderUserControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboardHeaderUserControl.Location = new System.Drawing.Point(0, 0);
            this.dashboardHeaderUserControl.Name = "dashboardHeaderUserControl";
            this.dashboardHeaderUserControl.Size = new System.Drawing.Size(836, 135);
            this.dashboardHeaderUserControl.TabIndex = 0;
            // 
            // MainEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 608);
            this.Controls.Add(this.dashboardHeaderUserControl);
            this.Name = "MainEmployeeForm";
            this.Text = "MainEmployeeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainEmployeeForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.DashboardHeaderUserControl dashboardHeaderUserControl;
    }
}