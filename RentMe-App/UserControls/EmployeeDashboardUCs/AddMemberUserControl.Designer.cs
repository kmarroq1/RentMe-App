
namespace RentMe_App.UserControls
{
    partial class AddMemberUserControl
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
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.memberDetailsUserControl = new RentMe_App.UserControls.MemberDetailsUserControl();
            this.controlsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.addButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.mainTableLayoutPanel.SuspendLayout();
            this.controlsFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 1;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Controls.Add(this.headerLabel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.memberDetailsUserControl, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.controlsFlowLayoutPanel, 0, 3);
            this.mainTableLayoutPanel.Controls.Add(this.errorMessageLabel, 0, 2);
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 4;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(432, 387);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Location = new System.Drawing.Point(3, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(67, 13);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Add Member";
            // 
            // memberDetailsUserControl
            // 
            this.memberDetailsUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberDetailsUserControl.Location = new System.Drawing.Point(3, 16);
            this.memberDetailsUserControl.Name = "memberDetailsUserControl";
            this.memberDetailsUserControl.Size = new System.Drawing.Size(426, 260);
            this.memberDetailsUserControl.TabIndex = 1;
            // 
            // controlsFlowLayoutPanel
            // 
            this.controlsFlowLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.controlsFlowLayoutPanel.AutoSize = true;
            this.controlsFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.controlsFlowLayoutPanel.Controls.Add(this.addButton);
            this.controlsFlowLayoutPanel.Controls.Add(this.clearButton);
            this.controlsFlowLayoutPanel.Location = new System.Drawing.Point(135, 328);
            this.controlsFlowLayoutPanel.Name = "controlsFlowLayoutPanel";
            this.controlsFlowLayoutPanel.Size = new System.Drawing.Size(162, 29);
            this.controlsFlowLayoutPanel.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(3, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(84, 3);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.errorMessageLabel.AutoSize = true;
            this.errorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.errorMessageLabel.Location = new System.Drawing.Point(178, 282);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(75, 13);
            this.errorMessageLabel.TabIndex = 3;
            this.errorMessageLabel.Text = "Error Message";
            this.errorMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorMessageLabel.Visible = false;
            // 
            // AddMemberUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Name = "AddMemberUserControl";
            this.Size = new System.Drawing.Size(438, 393);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            this.controlsFlowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Label headerLabel;
        private MemberDetailsUserControl memberDetailsUserControl;
        private System.Windows.Forms.FlowLayoutPanel controlsFlowLayoutPanel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label errorMessageLabel;
    }
}
