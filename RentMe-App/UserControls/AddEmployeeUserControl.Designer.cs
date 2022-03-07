using System.Windows.Forms;

namespace RentMe_App.UserControls
{
    public partial class AddEmployeeUserControl
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

        private void InitializeComponent()
        {
            HeaderLabel.Text = "Add Employee";

            TableLayoutControlCollection controls = FormTableLayoutPanel.Controls;
            TableLayoutRowStyleCollection rowStyles = FormTableLayoutPanel.RowStyles;

            FormTableLayoutPanel.RowCount++;
            rowStyles.Add(new RowStyle());
            PasswordFormGroup = new FormGroup("Password");
            PasswordFormGroup.TabIndex = 10;
            PasswordFormGroup.FormGroupTextBox.PasswordChar = '*';
            controls.Add(PasswordFormGroup, 0, 8);

            FormTableLayoutPanel.RowCount++;
            rowStyles.Add(new RowStyle());
            ConfirmPasswordFormGroup = new FormGroup("Confirm Password");
            ConfirmPasswordFormGroup.TabIndex = 11;
            ConfirmPasswordFormGroup.FormGroupTextBox.PasswordChar = '*';
            controls.Add(ConfirmPasswordFormGroup, 0, 9);

            ControlsFlowLayoutPanel.Controls.Add(new Button
            {
                Name = "CloseButton",
                Text = "Close",
            });
        }

        private FormGroup PasswordFormGroup;

        private FormGroup ConfirmPasswordFormGroup;
    }
}
