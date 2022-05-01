
namespace RentMe_App.View.MemberModals
{
    partial class ReceiptModal
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
            this.HeaderFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.TransactionTypeHeaderLabel = new System.Windows.Forms.Label();
            this.HeaderTailLabel = new System.Windows.Forms.Label();
            this.ReturnTransactionIDLabelLabel = new System.Windows.Forms.Label();
            this.ReturnTransactionIDValueLabel = new System.Windows.Forms.Label();
            this.TransactionDateLabelLabel = new System.Windows.Forms.Label();
            this.TransactionDateValueLabel = new System.Windows.Forms.Label();
            this.ItemizationTextBox = new System.Windows.Forms.TextBox();
            this.MemberIDLabelLabel = new System.Windows.Forms.Label();
            this.MemberIDValueLabel = new System.Windows.Forms.Label();
            this.MemberNameLabelLabel = new System.Windows.Forms.Label();
            this.MemberNameValueLabel = new System.Windows.Forms.Label();
            this.TotalTypeLabel = new System.Windows.Forms.Label();
            this.TotalAmountLabel = new System.Windows.Forms.Label();
            this.ButtonsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.EmailButton = new System.Windows.Forms.Button();
            this.PrimaryTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.HeaderFlowLayoutPanel.SuspendLayout();
            this.ButtonsFlowLayoutPanel.SuspendLayout();
            this.PrimaryTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderFlowLayoutPanel
            // 
            this.HeaderFlowLayoutPanel.Controls.Add(this.TransactionTypeHeaderLabel);
            this.HeaderFlowLayoutPanel.Controls.Add(this.HeaderTailLabel);
            this.HeaderFlowLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.HeaderFlowLayoutPanel.Name = "HeaderFlowLayoutPanel";
            this.HeaderFlowLayoutPanel.Size = new System.Drawing.Size(373, 22);
            this.HeaderFlowLayoutPanel.TabIndex = 0;
            // 
            // TransactionTypeHeaderLabel
            // 
            this.TransactionTypeHeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TransactionTypeHeaderLabel.AutoSize = true;
            this.TransactionTypeHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionTypeHeaderLabel.Location = new System.Drawing.Point(3, 0);
            this.TransactionTypeHeaderLabel.Name = "TransactionTypeHeaderLabel";
            this.TransactionTypeHeaderLabel.Size = new System.Drawing.Size(128, 16);
            this.TransactionTypeHeaderLabel.TabIndex = 0;
            this.TransactionTypeHeaderLabel.Text = "[ Rental | Return ]";
            // 
            // HeaderTailLabel
            // 
            this.HeaderTailLabel.AutoSize = true;
            this.HeaderTailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderTailLabel.Location = new System.Drawing.Point(137, 0);
            this.HeaderTailLabel.Name = "HeaderTailLabel";
            this.HeaderTailLabel.Size = new System.Drawing.Size(62, 16);
            this.HeaderTailLabel.TabIndex = 1;
            this.HeaderTailLabel.Text = "Receipt";
            // 
            // ReturnTransactionIDLabelLabel
            // 
            this.ReturnTransactionIDLabelLabel.AutoSize = true;
            this.ReturnTransactionIDLabelLabel.Location = new System.Drawing.Point(3, 54);
            this.ReturnTransactionIDLabelLabel.Name = "ReturnTransactionIDLabelLabel";
            this.ReturnTransactionIDLabelLabel.Size = new System.Drawing.Size(115, 13);
            this.ReturnTransactionIDLabelLabel.TabIndex = 0;
            this.ReturnTransactionIDLabelLabel.Text = "Return Transaction ID:";
            // 
            // ReturnTransactionIDValueLabel
            // 
            this.ReturnTransactionIDValueLabel.AutoSize = true;
            this.ReturnTransactionIDValueLabel.Location = new System.Drawing.Point(189, 54);
            this.ReturnTransactionIDValueLabel.Name = "ReturnTransactionIDValueLabel";
            this.ReturnTransactionIDValueLabel.Size = new System.Drawing.Size(28, 13);
            this.ReturnTransactionIDValueLabel.TabIndex = 1;
            this.ReturnTransactionIDValueLabel.Text = "XXX";
            // 
            // TransactionDateLabelLabel
            // 
            this.TransactionDateLabelLabel.AutoSize = true;
            this.TransactionDateLabelLabel.Location = new System.Drawing.Point(3, 81);
            this.TransactionDateLabelLabel.Name = "TransactionDateLabelLabel";
            this.TransactionDateLabelLabel.Size = new System.Drawing.Size(92, 13);
            this.TransactionDateLabelLabel.TabIndex = 0;
            this.TransactionDateLabelLabel.Text = "Transaction Date:";
            // 
            // TransactionDateValueLabel
            // 
            this.TransactionDateValueLabel.AutoSize = true;
            this.TransactionDateValueLabel.Location = new System.Drawing.Point(189, 81);
            this.TransactionDateValueLabel.Name = "TransactionDateValueLabel";
            this.TransactionDateValueLabel.Size = new System.Drawing.Size(73, 13);
            this.TransactionDateValueLabel.TabIndex = 1;
            this.TransactionDateValueLabel.Text = "XX/XX/XXXX";
            // 
            // ItemizationTextBox
            // 
            this.PrimaryTableLayoutPanel.SetColumnSpan(this.ItemizationTextBox, 2);
            this.ItemizationTextBox.Location = new System.Drawing.Point(3, 111);
            this.ItemizationTextBox.Multiline = true;
            this.ItemizationTextBox.Name = "ItemizationTextBox";
            this.ItemizationTextBox.ReadOnly = true;
            this.ItemizationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ItemizationTextBox.Size = new System.Drawing.Size(367, 185);
            this.ItemizationTextBox.TabIndex = 7;
            // 
            // MemberIDLabelLabel
            // 
            this.MemberIDLabelLabel.AutoSize = true;
            this.MemberIDLabelLabel.Location = new System.Drawing.Point(3, 0);
            this.MemberIDLabelLabel.Name = "MemberIDLabelLabel";
            this.MemberIDLabelLabel.Size = new System.Drawing.Size(62, 13);
            this.MemberIDLabelLabel.TabIndex = 0;
            this.MemberIDLabelLabel.Text = "Member ID:";
            // 
            // MemberIDValueLabel
            // 
            this.MemberIDValueLabel.AutoSize = true;
            this.MemberIDValueLabel.Location = new System.Drawing.Point(189, 0);
            this.MemberIDValueLabel.Name = "MemberIDValueLabel";
            this.MemberIDValueLabel.Size = new System.Drawing.Size(28, 13);
            this.MemberIDValueLabel.TabIndex = 1;
            this.MemberIDValueLabel.Text = "XXX";
            // 
            // MemberNameLabelLabel
            // 
            this.MemberNameLabelLabel.AutoSize = true;
            this.MemberNameLabelLabel.Location = new System.Drawing.Point(3, 27);
            this.MemberNameLabelLabel.Name = "MemberNameLabelLabel";
            this.MemberNameLabelLabel.Size = new System.Drawing.Size(79, 13);
            this.MemberNameLabelLabel.TabIndex = 0;
            this.MemberNameLabelLabel.Text = "Member Name:";
            // 
            // MemberNameValueLabel
            // 
            this.MemberNameValueLabel.AutoSize = true;
            this.MemberNameValueLabel.Location = new System.Drawing.Point(189, 27);
            this.MemberNameValueLabel.Name = "MemberNameValueLabel";
            this.MemberNameValueLabel.Size = new System.Drawing.Size(28, 13);
            this.MemberNameValueLabel.TabIndex = 1;
            this.MemberNameValueLabel.Text = "XXX";
            // 
            // TotalTypeLabel
            // 
            this.TotalTypeLabel.AutoSize = true;
            this.TotalTypeLabel.Location = new System.Drawing.Point(3, 299);
            this.TotalTypeLabel.Name = "TotalTypeLabel";
            this.TotalTypeLabel.Size = new System.Drawing.Size(88, 13);
            this.TotalTypeLabel.TabIndex = 1;
            this.TotalTypeLabel.Text = "[ Fees | Refund ]:";
            // 
            // TotalAmountLabel
            // 
            this.TotalAmountLabel.AutoSize = true;
            this.TotalAmountLabel.Location = new System.Drawing.Point(189, 299);
            this.TotalAmountLabel.Name = "TotalAmountLabel";
            this.TotalAmountLabel.Size = new System.Drawing.Size(49, 13);
            this.TotalAmountLabel.TabIndex = 2;
            this.TotalAmountLabel.Text = "$XXX.00";
            // 
            // ButtonsFlowLayoutPanel
            // 
            this.ButtonsFlowLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonsFlowLayoutPanel.AutoSize = true;
            this.ButtonsFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PrimaryTableLayoutPanel.SetColumnSpan(this.ButtonsFlowLayoutPanel, 2);
            this.ButtonsFlowLayoutPanel.Controls.Add(this.CloseButton);
            this.ButtonsFlowLayoutPanel.Controls.Add(this.PrintButton);
            this.ButtonsFlowLayoutPanel.Controls.Add(this.EmailButton);
            this.ButtonsFlowLayoutPanel.Location = new System.Drawing.Point(65, 331);
            this.ButtonsFlowLayoutPanel.Name = "ButtonsFlowLayoutPanel";
            this.ButtonsFlowLayoutPanel.Size = new System.Drawing.Size(243, 29);
            this.ButtonsFlowLayoutPanel.TabIndex = 4;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(3, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Enabled = false;
            this.PrintButton.Location = new System.Drawing.Point(84, 3);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(75, 23);
            this.PrintButton.TabIndex = 1;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Visible = false;
            // 
            // EmailButton
            // 
            this.EmailButton.Enabled = false;
            this.EmailButton.Location = new System.Drawing.Point(165, 3);
            this.EmailButton.Name = "EmailButton";
            this.EmailButton.Size = new System.Drawing.Size(75, 23);
            this.EmailButton.TabIndex = 2;
            this.EmailButton.Text = "Email";
            this.EmailButton.UseVisualStyleBackColor = true;
            this.EmailButton.Visible = false;
            // 
            // PrimaryTableLayoutPanel
            // 
            this.PrimaryTableLayoutPanel.ColumnCount = 2;
            this.PrimaryTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PrimaryTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PrimaryTableLayoutPanel.Controls.Add(this.TotalAmountLabel, 1, 5);
            this.PrimaryTableLayoutPanel.Controls.Add(this.ButtonsFlowLayoutPanel, 0, 6);
            this.PrimaryTableLayoutPanel.Controls.Add(this.TotalTypeLabel, 0, 5);
            this.PrimaryTableLayoutPanel.Controls.Add(this.TransactionDateValueLabel, 1, 3);
            this.PrimaryTableLayoutPanel.Controls.Add(this.ItemizationTextBox, 0, 4);
            this.PrimaryTableLayoutPanel.Controls.Add(this.TransactionDateLabelLabel, 0, 3);
            this.PrimaryTableLayoutPanel.Controls.Add(this.ReturnTransactionIDValueLabel, 1, 2);
            this.PrimaryTableLayoutPanel.Controls.Add(this.ReturnTransactionIDLabelLabel, 0, 2);
            this.PrimaryTableLayoutPanel.Controls.Add(this.MemberNameValueLabel, 1, 1);
            this.PrimaryTableLayoutPanel.Controls.Add(this.MemberNameLabelLabel, 0, 1);
            this.PrimaryTableLayoutPanel.Controls.Add(this.MemberIDValueLabel, 1, 0);
            this.PrimaryTableLayoutPanel.Controls.Add(this.MemberIDLabelLabel, 0, 0);
            this.PrimaryTableLayoutPanel.Location = new System.Drawing.Point(12, 40);
            this.PrimaryTableLayoutPanel.Name = "PrimaryTableLayoutPanel";
            this.PrimaryTableLayoutPanel.RowCount = 7;
            this.PrimaryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PrimaryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PrimaryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PrimaryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PrimaryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PrimaryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PrimaryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PrimaryTableLayoutPanel.Size = new System.Drawing.Size(373, 365);
            this.PrimaryTableLayoutPanel.TabIndex = 5;
            // 
            // ReceiptModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(397, 417);
            this.Controls.Add(this.PrimaryTableLayoutPanel);
            this.Controls.Add(this.HeaderFlowLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReceiptModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentMe: ";
            this.HeaderFlowLayoutPanel.ResumeLayout(false);
            this.HeaderFlowLayoutPanel.PerformLayout();
            this.ButtonsFlowLayoutPanel.ResumeLayout(false);
            this.PrimaryTableLayoutPanel.ResumeLayout(false);
            this.PrimaryTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel HeaderFlowLayoutPanel;
        private System.Windows.Forms.Label TransactionTypeHeaderLabel;
        private System.Windows.Forms.Label HeaderTailLabel;
        private System.Windows.Forms.Label MemberIDLabelLabel;
        private System.Windows.Forms.Label MemberIDValueLabel;
        private System.Windows.Forms.Label MemberNameLabelLabel;
        private System.Windows.Forms.Label MemberNameValueLabel;
        private System.Windows.Forms.Label ReturnTransactionIDLabelLabel;
        private System.Windows.Forms.Label ReturnTransactionIDValueLabel;
        private System.Windows.Forms.Label TransactionDateLabelLabel;
        private System.Windows.Forms.Label TransactionDateValueLabel;
        private System.Windows.Forms.Label TotalTypeLabel;
        private System.Windows.Forms.Label TotalAmountLabel;
        private System.Windows.Forms.FlowLayoutPanel ButtonsFlowLayoutPanel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button EmailButton;
        private System.Windows.Forms.TextBox ItemizationTextBox;
        private System.Windows.Forms.TableLayoutPanel PrimaryTableLayoutPanel;
    }
}