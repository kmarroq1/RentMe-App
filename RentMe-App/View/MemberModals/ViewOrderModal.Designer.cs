
namespace RentMe_App.View.EmployeeModals
{
    partial class ViewOrderModal
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
            this.topLableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.typeTitleLabel = new System.Windows.Forms.Label();
            this.transactionTypeLabel = new System.Windows.Forms.Label();
            this.dueDateTitleLabel = new System.Windows.Forms.Label();
            this.dueDateLabel = new System.Windows.Forms.Label();
            this.amtPaidTitleLabel = new System.Windows.Forms.Label();
            this.amountPaidLabel = new System.Windows.Forms.Label();
            this.balanceTitleLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.bottomTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.RentAgainButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.furnitureOrderedDataGridView = new System.Windows.Forms.DataGridView();
            this.topLableLayoutPanel.SuspendLayout();
            this.bottomTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureOrderedDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // topLableLayoutPanel
            // 
            this.topLableLayoutPanel.ColumnCount = 2;
            this.topLableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.60151F));
            this.topLableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.39849F));
            this.topLableLayoutPanel.Controls.Add(this.titleLabel, 0, 0);
            this.topLableLayoutPanel.Controls.Add(this.typeTitleLabel, 0, 1);
            this.topLableLayoutPanel.Controls.Add(this.transactionTypeLabel, 1, 1);
            this.topLableLayoutPanel.Controls.Add(this.dueDateTitleLabel, 0, 2);
            this.topLableLayoutPanel.Controls.Add(this.dueDateLabel, 1, 2);
            this.topLableLayoutPanel.Controls.Add(this.amtPaidTitleLabel, 0, 3);
            this.topLableLayoutPanel.Controls.Add(this.amountPaidLabel, 1, 3);
            this.topLableLayoutPanel.Controls.Add(this.balanceTitleLabel, 0, 4);
            this.topLableLayoutPanel.Controls.Add(this.balanceLabel, 1, 4);
            this.topLableLayoutPanel.Location = new System.Drawing.Point(7, 5);
            this.topLableLayoutPanel.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.topLableLayoutPanel.Name = "topLableLayoutPanel";
            this.topLableLayoutPanel.RowCount = 5;
            this.topLableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.4657F));
            this.topLableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.63358F));
            this.topLableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.63358F));
            this.topLableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.63358F));
            this.topLableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.63358F));
            this.topLableLayoutPanel.Size = new System.Drawing.Size(252, 153);
            this.topLableLayoutPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(1, 0);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(68, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Order Details";
            // 
            // typeTitleLabel
            // 
            this.typeTitleLabel.AutoSize = true;
            this.typeTitleLabel.Location = new System.Drawing.Point(1, 45);
            this.typeTitleLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.typeTitleLabel.Name = "typeTitleLabel";
            this.typeTitleLabel.Size = new System.Drawing.Size(93, 13);
            this.typeTitleLabel.TabIndex = 2;
            this.typeTitleLabel.Text = "Transaction Type:";
            // 
            // transactionTypeLabel
            // 
            this.transactionTypeLabel.AutoSize = true;
            this.transactionTypeLabel.Location = new System.Drawing.Point(103, 45);
            this.transactionTypeLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.transactionTypeLabel.Name = "transactionTypeLabel";
            this.transactionTypeLabel.Size = new System.Drawing.Size(13, 13);
            this.transactionTypeLabel.TabIndex = 4;
            this.transactionTypeLabel.Text = "  ";
            // 
            // dueDateTitleLabel
            // 
            this.dueDateTitleLabel.AutoSize = true;
            this.dueDateTitleLabel.Location = new System.Drawing.Point(1, 71);
            this.dueDateTitleLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.dueDateTitleLabel.Name = "dueDateTitleLabel";
            this.dueDateTitleLabel.Size = new System.Drawing.Size(56, 13);
            this.dueDateTitleLabel.TabIndex = 5;
            this.dueDateTitleLabel.Text = "Due Date:";
            // 
            // dueDateLabel
            // 
            this.dueDateLabel.AutoSize = true;
            this.dueDateLabel.Location = new System.Drawing.Point(103, 71);
            this.dueDateLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.dueDateLabel.Name = "dueDateLabel";
            this.dueDateLabel.Size = new System.Drawing.Size(13, 13);
            this.dueDateLabel.TabIndex = 6;
            this.dueDateLabel.Text = "  ";
            // 
            // amtPaidTitleLabel
            // 
            this.amtPaidTitleLabel.AutoSize = true;
            this.amtPaidTitleLabel.Location = new System.Drawing.Point(1, 97);
            this.amtPaidTitleLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.amtPaidTitleLabel.Name = "amtPaidTitleLabel";
            this.amtPaidTitleLabel.Size = new System.Drawing.Size(70, 13);
            this.amtPaidTitleLabel.TabIndex = 7;
            this.amtPaidTitleLabel.Text = "Amount Paid:";
            // 
            // amountPaidLabel
            // 
            this.amountPaidLabel.AutoSize = true;
            this.amountPaidLabel.Location = new System.Drawing.Point(103, 97);
            this.amountPaidLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.amountPaidLabel.Name = "amountPaidLabel";
            this.amountPaidLabel.Size = new System.Drawing.Size(13, 13);
            this.amountPaidLabel.TabIndex = 8;
            this.amountPaidLabel.Text = "  ";
            // 
            // balanceTitleLabel
            // 
            this.balanceTitleLabel.AutoSize = true;
            this.balanceTitleLabel.Location = new System.Drawing.Point(1, 123);
            this.balanceTitleLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.balanceTitleLabel.Name = "balanceTitleLabel";
            this.balanceTitleLabel.Size = new System.Drawing.Size(49, 13);
            this.balanceTitleLabel.TabIndex = 9;
            this.balanceTitleLabel.Text = "Balance:";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(103, 123);
            this.balanceLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(13, 13);
            this.balanceLabel.TabIndex = 10;
            this.balanceLabel.Text = "  ";
            // 
            // bottomTableLayoutPanel
            // 
            this.bottomTableLayoutPanel.ColumnCount = 3;
            this.bottomTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.bottomTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.bottomTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.bottomTableLayoutPanel.Controls.Add(this.errorLabel, 1, 0);
            this.bottomTableLayoutPanel.Controls.Add(this.RentAgainButton, 0, 1);
            this.bottomTableLayoutPanel.Controls.Add(this.ReturnButton, 1, 1);
            this.bottomTableLayoutPanel.Controls.Add(this.CloseButton, 2, 1);
            this.bottomTableLayoutPanel.Location = new System.Drawing.Point(1, 410);
            this.bottomTableLayoutPanel.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.bottomTableLayoutPanel.Name = "bottomTableLayoutPanel";
            this.bottomTableLayoutPanel.RowCount = 2;
            this.bottomTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.06202F));
            this.bottomTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.93798F));
            this.bottomTableLayoutPanel.Size = new System.Drawing.Size(783, 54);
            this.bottomTableLayoutPanel.TabIndex = 1;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(262, 0);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(13, 13);
            this.errorLabel.TabIndex = 0;
            this.errorLabel.Text = "  ";
            // 
            // RentAgainButton
            // 
            this.RentAgainButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RentAgainButton.Location = new System.Drawing.Point(86, 26);
            this.RentAgainButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.RentAgainButton.Name = "RentAgainButton";
            this.RentAgainButton.Size = new System.Drawing.Size(88, 22);
            this.RentAgainButton.TabIndex = 1;
            this.RentAgainButton.Text = "Rent Again";
            this.RentAgainButton.UseVisualStyleBackColor = true;
            this.RentAgainButton.Click += new System.EventHandler(this.RentAgainButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ReturnButton.Location = new System.Drawing.Point(358, 26);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(66, 22);
            this.ReturnButton.TabIndex = 2;
            this.ReturnButton.Text = "Return Item";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CloseButton.Location = new System.Drawing.Point(615, 26);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(74, 22);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // furnitureOrderedDataGridView
            // 
            this.furnitureOrderedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.furnitureOrderedDataGridView.Location = new System.Drawing.Point(1, 160);
            this.furnitureOrderedDataGridView.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.furnitureOrderedDataGridView.Name = "furnitureOrderedDataGridView";
            this.furnitureOrderedDataGridView.RowHeadersWidth = 123;
            this.furnitureOrderedDataGridView.RowTemplate.Height = 46;
            this.furnitureOrderedDataGridView.Size = new System.Drawing.Size(783, 240);
            this.furnitureOrderedDataGridView.TabIndex = 2;
            // 
            // ViewOrderModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.furnitureOrderedDataGridView);
            this.Controls.Add(this.bottomTableLayoutPanel);
            this.Controls.Add(this.topLableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewOrderModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Details";
            this.topLableLayoutPanel.ResumeLayout(false);
            this.topLableLayoutPanel.PerformLayout();
            this.bottomTableLayoutPanel.ResumeLayout(false);
            this.bottomTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureOrderedDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel topLableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel bottomTableLayoutPanel;
        private System.Windows.Forms.DataGridView furnitureOrderedDataGridView;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label typeTitleLabel;
        private System.Windows.Forms.Label transactionTypeLabel;
        private System.Windows.Forms.Label dueDateTitleLabel;
        private System.Windows.Forms.Label dueDateLabel;
        private System.Windows.Forms.Label amtPaidTitleLabel;
        private System.Windows.Forms.Label amountPaidLabel;
        private System.Windows.Forms.Label balanceTitleLabel;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button RentAgainButton;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button CloseButton;
    }
}