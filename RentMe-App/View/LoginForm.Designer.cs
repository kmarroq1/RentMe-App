
namespace RentMe_App.View
{
    partial class LoginForm
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
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.inputTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.showEmployeeButton = new System.Windows.Forms.Button();
            this.showAdminButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.mainTableLayoutPanel.SuspendLayout();
            this.buttonFlowLayoutPanel.SuspendLayout();
            this.inputTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 1;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Controls.Add(this.buttonFlowLayoutPanel, 0, 2);
            this.mainTableLayoutPanel.Controls.Add(this.inputTableLayoutPanel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.errorMessageLabel, 0, 1);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 3;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(278, 211);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // buttonFlowLayoutPanel
            // 
            this.buttonFlowLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFlowLayoutPanel.AutoSize = true;
            this.buttonFlowLayoutPanel.Controls.Add(this.showEmployeeButton);
            this.buttonFlowLayoutPanel.Controls.Add(this.showAdminButton);
            this.buttonFlowLayoutPanel.Controls.Add(this.loginButton);
            this.buttonFlowLayoutPanel.Location = new System.Drawing.Point(8, 170);
            this.buttonFlowLayoutPanel.Name = "buttonFlowLayoutPanel";
            this.buttonFlowLayoutPanel.Size = new System.Drawing.Size(262, 29);
            this.buttonFlowLayoutPanel.TabIndex = 0;
            // 
            // inputTableLayoutPanel
            // 
            this.inputTableLayoutPanel.ColumnCount = 2;
            this.inputTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.inputTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.inputTableLayoutPanel.Controls.Add(this.passwordTextBox, 1, 1);
            this.inputTableLayoutPanel.Controls.Add(this.usernameLabel, 0, 0);
            this.inputTableLayoutPanel.Controls.Add(this.passwordLabel, 0, 1);
            this.inputTableLayoutPanel.Controls.Add(this.usernameTextBox, 1, 0);
            this.inputTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.inputTableLayoutPanel.Name = "inputTableLayoutPanel";
            this.inputTableLayoutPanel.RowCount = 2;
            this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.inputTableLayoutPanel.Size = new System.Drawing.Size(272, 140);
            this.inputTableLayoutPanel.TabIndex = 1;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(75, 28);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(58, 13);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(77, 98);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.usernameTextBox.Location = new System.Drawing.Point(139, 25);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.passwordTextBox.Location = new System.Drawing.Point(139, 95);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 3;
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.errorMessageLabel.AutoSize = true;
            this.errorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.errorMessageLabel.Location = new System.Drawing.Point(101, 146);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(75, 13);
            this.errorMessageLabel.TabIndex = 2;
            this.errorMessageLabel.Text = "Error Message";
            this.errorMessageLabel.Visible = false;
            // 
            // showEmployeeButton
            // 
            this.showEmployeeButton.AutoSize = true;
            this.showEmployeeButton.Location = new System.Drawing.Point(3, 3);
            this.showEmployeeButton.Name = "showEmployeeButton";
            this.showEmployeeButton.Size = new System.Drawing.Size(93, 23);
            this.showEmployeeButton.TabIndex = 0;
            this.showEmployeeButton.Text = "Show Employee";
            this.showEmployeeButton.UseVisualStyleBackColor = true;
            // 
            // showAdminButton
            // 
            this.showAdminButton.AutoSize = true;
            this.showAdminButton.Location = new System.Drawing.Point(102, 3);
            this.showAdminButton.Name = "showAdminButton";
            this.showAdminButton.Size = new System.Drawing.Size(76, 23);
            this.showAdminButton.TabIndex = 1;
            this.showAdminButton.Text = "Show Admin";
            this.showAdminButton.UseVisualStyleBackColor = true;
            // 
            // loginButton
            // 
            this.loginButton.Enabled = false;
            this.loginButton.Location = new System.Drawing.Point(184, 3);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 211);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Name = "LoginForm";
            this.Text = "RentMe: Login";
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            this.buttonFlowLayoutPanel.ResumeLayout(false);
            this.buttonFlowLayoutPanel.PerformLayout();
            this.inputTableLayoutPanel.ResumeLayout(false);
            this.inputTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel buttonFlowLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel inputTableLayoutPanel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label errorMessageLabel;
        private System.Windows.Forms.Button showEmployeeButton;
        private System.Windows.Forms.Button showAdminButton;
        private System.Windows.Forms.Button loginButton;
    }
}