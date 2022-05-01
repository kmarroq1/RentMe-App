
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
            this.qtyReturnNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.FurnitureID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FurnitureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyRented = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyReturned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentalRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FineRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topLableLayoutPanel.SuspendLayout();
            this.bottomTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureOrderedDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtyReturnNumericUpDown)).BeginInit();
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
            this.topLableLayoutPanel.Margin = new System.Windows.Forms.Padding(1);
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
            this.bottomTableLayoutPanel.Margin = new System.Windows.Forms.Padding(1);
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
            this.bottomTableLayoutPanel.SetColumnSpan(this.errorLabel, 2);
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
            this.RentAgainButton.Enabled = false;
            this.RentAgainButton.Location = new System.Drawing.Point(86, 26);
            this.RentAgainButton.Margin = new System.Windows.Forms.Padding(1);
            this.RentAgainButton.Name = "RentAgainButton";
            this.RentAgainButton.Size = new System.Drawing.Size(88, 22);
            this.RentAgainButton.TabIndex = 1;
            this.RentAgainButton.Text = "Rent Again";
            this.RentAgainButton.UseVisualStyleBackColor = true;
            this.RentAgainButton.Visible = false;
            this.RentAgainButton.Click += new System.EventHandler(this.RentAgainButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ReturnButton.Location = new System.Drawing.Point(331, 26);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(1);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(121, 22);
            this.ReturnButton.TabIndex = 2;
            this.ReturnButton.Text = "Add to Return Cart";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CloseButton.Location = new System.Drawing.Point(615, 26);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(1);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(74, 22);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // furnitureOrderedDataGridView
            // 
            this.furnitureOrderedDataGridView.AllowUserToAddRows = false;
            this.furnitureOrderedDataGridView.AllowUserToDeleteRows = false;
            this.furnitureOrderedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.furnitureOrderedDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FurnitureID,
            this.FurnitureName,
            this.RentalDate,
            this.QtyRented,
            this.QtyReturned,
            this.RentalRate,
            this.FineRate,
            this.Balance});
            this.furnitureOrderedDataGridView.Location = new System.Drawing.Point(1, 160);
            this.furnitureOrderedDataGridView.Margin = new System.Windows.Forms.Padding(1);
            this.furnitureOrderedDataGridView.Name = "furnitureOrderedDataGridView";
            this.furnitureOrderedDataGridView.ReadOnly = true;
            this.furnitureOrderedDataGridView.RowHeadersVisible = false;
            this.furnitureOrderedDataGridView.RowHeadersWidth = 123;
            this.furnitureOrderedDataGridView.RowTemplate.Height = 46;
            this.furnitureOrderedDataGridView.Size = new System.Drawing.Size(783, 240);
            this.furnitureOrderedDataGridView.TabIndex = 2;
            this.furnitureOrderedDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
            // 
            // qtyReturnNumericUpDown
            // 
            this.qtyReturnNumericUpDown.Location = new System.Drawing.Point(444, 76);
            this.qtyReturnNumericUpDown.Name = "qtyReturnNumericUpDown";
            this.qtyReturnNumericUpDown.Size = new System.Drawing.Size(114, 20);
            this.qtyReturnNumericUpDown.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Return how many?";
            // 
            // FurnitureID
            // 
            this.FurnitureID.HeaderText = "Furniture ID";
            this.FurnitureID.Name = "FurnitureID";
            this.FurnitureID.ReadOnly = true;
            // 
            // FurnitureName
            // 
            this.FurnitureName.HeaderText = "Name";
            this.FurnitureName.Name = "FurnitureName";
            this.FurnitureName.ReadOnly = true;
            // 
            // RentalDate
            // 
            this.RentalDate.HeaderText = "Rental Date";
            this.RentalDate.Name = "RentalDate";
            this.RentalDate.ReadOnly = true;
            // 
            // QtyRented
            // 
            this.QtyRented.HeaderText = "Qty Rented";
            this.QtyRented.Name = "QtyRented";
            this.QtyRented.ReadOnly = true;
            // 
            // QtyReturned
            // 
            this.QtyReturned.HeaderText = "Qty Returned";
            this.QtyReturned.Name = "QtyReturned";
            this.QtyReturned.ReadOnly = true;
            // 
            // RentalRate
            // 
            this.RentalRate.HeaderText = "Rental Rate";
            this.RentalRate.Name = "RentalRate";
            this.RentalRate.ReadOnly = true;
            // 
            // FineRate
            // 
            this.FineRate.HeaderText = "Fine Rate";
            this.FineRate.Name = "FineRate";
            this.FineRate.ReadOnly = true;
            // 
            // Balance
            // 
            this.Balance.HeaderText = "Balance";
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            // 
            // ViewOrderModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qtyReturnNumericUpDown);
            this.Controls.Add(this.furnitureOrderedDataGridView);
            this.Controls.Add(this.bottomTableLayoutPanel);
            this.Controls.Add(this.topLableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(1);
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
            ((System.ComponentModel.ISupportInitialize)(this.qtyReturnNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.NumericUpDown qtyReturnNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FurnitureID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FurnitureName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyRented;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyReturned;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn FineRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
    }
}