
namespace RentMe_App.UserControls.MemberDashboardUCs
{
    partial class ReturnCartUserControl
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
            this.PrimaryTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ReturnButtonsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CompleteReturnButton = new System.Windows.Forms.Button();
            this.ViewReturnItemButton = new System.Windows.Forms.Button();
            this.ClearReturnsButton = new System.Windows.Forms.Button();
            this.ReturnSumsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ReturnCountFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ReturnCountLabelLabel = new System.Windows.Forms.Label();
            this.ReturnCountValueLabel = new System.Windows.Forms.Label();
            this.ReturnBalanceFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ReturnBalanceLabelLabel = new System.Windows.Forms.Label();
            this.ReturnBalanceValueLabel = new System.Windows.Forms.Label();
            this.ReturnsDataGridView = new System.Windows.Forms.DataGridView();
            this.ErrorMessage = new System.Windows.Forms.Label();
            this.PrimaryTableLayoutPanel.SuspendLayout();
            this.ReturnButtonsFlowLayoutPanel.SuspendLayout();
            this.ReturnSumsFlowLayoutPanel.SuspendLayout();
            this.ReturnCountFlowLayoutPanel.SuspendLayout();
            this.ReturnBalanceFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PrimaryTableLayoutPanel
            // 
            this.PrimaryTableLayoutPanel.ColumnCount = 1;
            this.PrimaryTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PrimaryTableLayoutPanel.Controls.Add(this.ReturnButtonsFlowLayoutPanel, 0, 3);
            this.PrimaryTableLayoutPanel.Controls.Add(this.ReturnSumsFlowLayoutPanel, 0, 0);
            this.PrimaryTableLayoutPanel.Controls.Add(this.ReturnsDataGridView, 0, 1);
            this.PrimaryTableLayoutPanel.Controls.Add(this.ErrorMessage, 0, 2);
            this.PrimaryTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrimaryTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.PrimaryTableLayoutPanel.Name = "PrimaryTableLayoutPanel";
            this.PrimaryTableLayoutPanel.RowCount = 4;
            this.PrimaryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PrimaryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.PrimaryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PrimaryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PrimaryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PrimaryTableLayoutPanel.Size = new System.Drawing.Size(380, 358);
            this.PrimaryTableLayoutPanel.TabIndex = 0;
            // 
            // ReturnButtonsFlowLayoutPanel
            // 
            this.ReturnButtonsFlowLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReturnButtonsFlowLayoutPanel.AutoSize = true;
            this.ReturnButtonsFlowLayoutPanel.Controls.Add(this.CompleteReturnButton);
            this.ReturnButtonsFlowLayoutPanel.Controls.Add(this.ViewReturnItemButton);
            this.ReturnButtonsFlowLayoutPanel.Controls.Add(this.ClearReturnsButton);
            this.ReturnButtonsFlowLayoutPanel.Location = new System.Drawing.Point(55, 313);
            this.ReturnButtonsFlowLayoutPanel.Name = "ReturnButtonsFlowLayoutPanel";
            this.ReturnButtonsFlowLayoutPanel.Size = new System.Drawing.Size(270, 29);
            this.ReturnButtonsFlowLayoutPanel.TabIndex = 10;
            // 
            // CompleteReturnButton
            // 
            this.CompleteReturnButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CompleteReturnButton.AutoSize = true;
            this.CompleteReturnButton.Location = new System.Drawing.Point(3, 3);
            this.CompleteReturnButton.Name = "CompleteReturnButton";
            this.CompleteReturnButton.Size = new System.Drawing.Size(96, 23);
            this.CompleteReturnButton.TabIndex = 0;
            this.CompleteReturnButton.Text = "Complete Return";
            this.CompleteReturnButton.UseVisualStyleBackColor = true;
            this.CompleteReturnButton.Click += new System.EventHandler(this.CompleteReturnButton_Click);
            // 
            // ViewReturnItemButton
            // 
            this.ViewReturnItemButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ViewReturnItemButton.AutoSize = true;
            this.ViewReturnItemButton.Enabled = false;
            this.ViewReturnItemButton.Location = new System.Drawing.Point(105, 3);
            this.ViewReturnItemButton.Name = "ViewReturnItemButton";
            this.ViewReturnItemButton.Size = new System.Drawing.Size(75, 23);
            this.ViewReturnItemButton.TabIndex = 1;
            this.ViewReturnItemButton.Text = "View Item";
            this.ViewReturnItemButton.UseVisualStyleBackColor = true;
            this.ViewReturnItemButton.Visible = false;
            this.ViewReturnItemButton.Click += new System.EventHandler(this.ViewReturnItemButton_Click);
            // 
            // ClearReturnsButton
            // 
            this.ClearReturnsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClearReturnsButton.AutoSize = true;
            this.ClearReturnsButton.Location = new System.Drawing.Point(186, 3);
            this.ClearReturnsButton.Name = "ClearReturnsButton";
            this.ClearReturnsButton.Size = new System.Drawing.Size(81, 23);
            this.ClearReturnsButton.TabIndex = 2;
            this.ClearReturnsButton.Text = "Clear Returns";
            this.ClearReturnsButton.UseVisualStyleBackColor = true;
            this.ClearReturnsButton.Click += new System.EventHandler(this.ClearReturnsButton_Click);
            // 
            // ReturnSumsFlowLayoutPanel
            // 
            this.ReturnSumsFlowLayoutPanel.AutoSize = true;
            this.ReturnSumsFlowLayoutPanel.Controls.Add(this.ReturnCountFlowLayoutPanel);
            this.ReturnSumsFlowLayoutPanel.Controls.Add(this.ReturnBalanceFlowLayoutPanel);
            this.ReturnSumsFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ReturnSumsFlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.ReturnSumsFlowLayoutPanel.Name = "ReturnSumsFlowLayoutPanel";
            this.ReturnSumsFlowLayoutPanel.Size = new System.Drawing.Size(134, 38);
            this.ReturnSumsFlowLayoutPanel.TabIndex = 7;
            // 
            // ReturnCountFlowLayoutPanel
            // 
            this.ReturnCountFlowLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ReturnCountFlowLayoutPanel.AutoSize = true;
            this.ReturnCountFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ReturnCountFlowLayoutPanel.Controls.Add(this.ReturnCountLabelLabel);
            this.ReturnCountFlowLayoutPanel.Controls.Add(this.ReturnCountValueLabel);
            this.ReturnCountFlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.ReturnCountFlowLayoutPanel.Name = "ReturnCountFlowLayoutPanel";
            this.ReturnCountFlowLayoutPanel.Size = new System.Drawing.Size(128, 13);
            this.ReturnCountFlowLayoutPanel.TabIndex = 0;
            // 
            // ReturnCountLabelLabel
            // 
            this.ReturnCountLabelLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ReturnCountLabelLabel.AutoSize = true;
            this.ReturnCountLabelLabel.Location = new System.Drawing.Point(3, 0);
            this.ReturnCountLabelLabel.Name = "ReturnCountLabelLabel";
            this.ReturnCountLabelLabel.Size = new System.Drawing.Size(95, 13);
            this.ReturnCountLabelLabel.TabIndex = 0;
            this.ReturnCountLabelLabel.Text = "Total Items in Cart:";
            // 
            // ReturnCountValueLabel
            // 
            this.ReturnCountValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ReturnCountValueLabel.AutoSize = true;
            this.ReturnCountValueLabel.Location = new System.Drawing.Point(104, 0);
            this.ReturnCountValueLabel.Name = "ReturnCountValueLabel";
            this.ReturnCountValueLabel.Size = new System.Drawing.Size(21, 13);
            this.ReturnCountValueLabel.TabIndex = 1;
            this.ReturnCountValueLabel.Text = "XX";
            // 
            // ReturnBalanceFlowLayoutPanel
            // 
            this.ReturnBalanceFlowLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ReturnBalanceFlowLayoutPanel.AutoSize = true;
            this.ReturnBalanceFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ReturnBalanceFlowLayoutPanel.Controls.Add(this.ReturnBalanceLabelLabel);
            this.ReturnBalanceFlowLayoutPanel.Controls.Add(this.ReturnBalanceValueLabel);
            this.ReturnBalanceFlowLayoutPanel.Location = new System.Drawing.Point(3, 22);
            this.ReturnBalanceFlowLayoutPanel.Name = "ReturnBalanceFlowLayoutPanel";
            this.ReturnBalanceFlowLayoutPanel.Size = new System.Drawing.Size(125, 13);
            this.ReturnBalanceFlowLayoutPanel.TabIndex = 1;
            // 
            // ReturnBalanceLabelLabel
            // 
            this.ReturnBalanceLabelLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ReturnBalanceLabelLabel.AutoSize = true;
            this.ReturnBalanceLabelLabel.Location = new System.Drawing.Point(3, 0);
            this.ReturnBalanceLabelLabel.Name = "ReturnBalanceLabelLabel";
            this.ReturnBalanceLabelLabel.Size = new System.Drawing.Size(86, 13);
            this.ReturnBalanceLabelLabel.TabIndex = 0;
            this.ReturnBalanceLabelLabel.Text = "Current Balance:";
            // 
            // ReturnBalanceValueLabel
            // 
            this.ReturnBalanceValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ReturnBalanceValueLabel.AutoSize = true;
            this.ReturnBalanceValueLabel.Location = new System.Drawing.Point(95, 0);
            this.ReturnBalanceValueLabel.Name = "ReturnBalanceValueLabel";
            this.ReturnBalanceValueLabel.Size = new System.Drawing.Size(27, 13);
            this.ReturnBalanceValueLabel.TabIndex = 1;
            this.ReturnBalanceValueLabel.Text = "$XX";
            // 
            // ReturnsDataGridView
            // 
            this.ReturnsDataGridView.AllowUserToAddRows = false;
            this.ReturnsDataGridView.AllowUserToDeleteRows = false;
            this.ReturnsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReturnsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReturnsDataGridView.Location = new System.Drawing.Point(3, 47);
            this.ReturnsDataGridView.Name = "ReturnsDataGridView";
            this.ReturnsDataGridView.ReadOnly = true;
            this.ReturnsDataGridView.Size = new System.Drawing.Size(374, 234);
            this.ReturnsDataGridView.TabIndex = 8;
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ErrorMessage.AutoSize = true;
            this.ErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessage.Location = new System.Drawing.Point(152, 284);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(75, 13);
            this.ErrorMessage.TabIndex = 9;
            this.ErrorMessage.Text = "Error Message";
            this.ErrorMessage.Visible = false;
            // 
            // ReturnCartUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PrimaryTableLayoutPanel);
            this.Name = "ReturnCartUserControl";
            this.Size = new System.Drawing.Size(380, 358);
            this.Load += new System.EventHandler(this.ReturnCartUserControl_Load);
            this.PrimaryTableLayoutPanel.ResumeLayout(false);
            this.PrimaryTableLayoutPanel.PerformLayout();
            this.ReturnButtonsFlowLayoutPanel.ResumeLayout(false);
            this.ReturnButtonsFlowLayoutPanel.PerformLayout();
            this.ReturnSumsFlowLayoutPanel.ResumeLayout(false);
            this.ReturnSumsFlowLayoutPanel.PerformLayout();
            this.ReturnCountFlowLayoutPanel.ResumeLayout(false);
            this.ReturnCountFlowLayoutPanel.PerformLayout();
            this.ReturnBalanceFlowLayoutPanel.ResumeLayout(false);
            this.ReturnBalanceFlowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PrimaryTableLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel ReturnSumsFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel ReturnCountFlowLayoutPanel;
        private System.Windows.Forms.Label ReturnCountLabelLabel;
        private System.Windows.Forms.Label ReturnCountValueLabel;
        private System.Windows.Forms.FlowLayoutPanel ReturnBalanceFlowLayoutPanel;
        private System.Windows.Forms.Label ReturnBalanceLabelLabel;
        private System.Windows.Forms.Label ReturnBalanceValueLabel;
        private System.Windows.Forms.DataGridView ReturnsDataGridView;
        private System.Windows.Forms.Label ErrorMessage;
        private System.Windows.Forms.FlowLayoutPanel ReturnButtonsFlowLayoutPanel;
        private System.Windows.Forms.Button CompleteReturnButton;
        private System.Windows.Forms.Button ViewReturnItemButton;
        private System.Windows.Forms.Button ClearReturnsButton;
    }
}
