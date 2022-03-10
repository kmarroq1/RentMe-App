
namespace RentMe_App
{
    partial class Form1
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
            this.addEmployeeUserControl1 = new RentMe_App.UserControls.AddEmployeeUserControl();
            this.SuspendLayout();
            // 
            // addEmployeeUserControl1
            // 
            this.addEmployeeUserControl1.Location = new System.Drawing.Point(149, 71);
            this.addEmployeeUserControl1.Name = "addEmployeeUserControl1";
            this.addEmployeeUserControl1.Size = new System.Drawing.Size(335, 400);
            this.addEmployeeUserControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.addEmployeeUserControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.AddEmployeeUserControl addEmployeeUserControl1;
    }
}

