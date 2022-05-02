
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
            this.FurnitureID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FurnitureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyRented = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyReturned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentalRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FineRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyReturnNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
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
            this.topLableLayoutPanel.Location = new System.Drawing.Point(22, 14);
            this.topLableLayoutPanel.Name = "topLableLayoutPanel";
            this.topLableLayoutPanel.RowCount = 5;
            this.topLableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.4657F));
            this.topLableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.63358F));
            this.topLableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.63358F));
            this.topLableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.63358F));
            this.topLableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.63358F));
            this.topLableLayoutPanel.Size = new System.Drawing.Size(798, 435);
            this.topLableLayoutPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(3, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(205, 37);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Order Details";
            // 
            // typeTitleLabel
            // 
            this.typeTitleLabel.AutoSize = true;
            this.typeTitleLabel.Location = new System.Drawing.Point(3, 128);
            this.typeTitleLabel.Name = "typeTitleLabel";
            this.typeTitleLabel.Size = new System.Drawing.Size(274, 37);
            this.typeTitleLabel.TabIndex = 2;
            this.typeTitleLabel.Text = "Transaction Type:";
            // 
            // transactionTypeLabel
            // 
            this.transactionTypeLabel.AutoSize = true;
            this.transactionTypeLabel.Location = new System.Drawing.Point(327, 128);
            this.transactionTypeLabel.Name = "transactionTypeLabel";
            this.transactionTypeLabel.Size = new System.Drawing.Size(35, 37);
            this.transactionTypeLabel.TabIndex = 4;
            this.transactionTypeLabel.Text = "  ";
            // 
            // dueDateTitleLabel
            // 
            this.dueDateTitleLabel.AutoSize = true;
            this.dueDateTitleLabel.Location = new System.Drawing.Point(3, 204);
            this.dueDateTitleLabel.Name = "dueDateTitleLabel";
            this.dueDateTitleLabel.Size = new System.Drawing.Size(160, 37);
            this.dueDateTitleLabel.TabIndex = 5;
            this.dueDateTitleLabel.Text = "Due Date:";
            // 
            // dueDateLabel
            // 
            this.dueDateLabel.AutoSize = true;
            this.dueDateLabel.Location = new System.Drawing.Point(327, 204);
            this.dueDateLabel.Name = "dueDateLabel";
            this.dueDateLabel.Size = new System.Drawing.Size(35, 37);
            this.dueDateLabel.TabIndex = 6;
            this.dueDateLabel.Text = "  ";
            // 
            // amtPaidTitleLabel
            // 
            this.amtPaidTitleLabel.AutoSize = true;
            this.amtPaidTitleLabel.Location = new System.Drawing.Point(3, 280);
            this.amtPaidTitleLabel.Name = "amtPaidTitleLabel";
            this.amtPaidTitleLabel.Size = new System.Drawing.Size(211, 37);
            this.amtPaidTitleLabel.TabIndex = 7;
            this.amtPaidTitleLabel.Text = "Amount Paid:";
            // 
            // amountPaidLabel
            // 
            this.amountPaidLabel.AutoSize = true;
            this.amountPaidLabel.Location = new System.Drawing.Point(327, 280);
            this.amountPaidLabel.Name = "amountPaidLabel";
            this.amountPaidLabel.Size = new System.Drawing.Size(35, 37);
            this.amountPaidLabel.TabIndex = 8;
            this.amountPaidLabel.Text = "  ";
            // 
            // balanceTitleLabel
            // 
            this.balanceTitleLabel.AutoSize = true;
            this.balanceTitleLabel.Location = new System.Drawing.Point(3, 356);
            this.balanceTitleLabel.Name = "balanceTitleLabel";
            this.balanceTitleLabel.Size = new System.Drawing.Size(141, 37);
            this.balanceTitleLabel.TabIndex = 9;
            this.balanceTitleLabel.Text = "Balance:";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(327, 356);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(35, 37);
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
            this.bottomTableLayoutPanel.Location = new System.Drawing.Point(3, 1167);
            this.bottomTableLayoutPanel.Name = "bottomTableLayoutPanel";
            this.bottomTableLayoutPanel.RowCount = 2;
            this.bottomTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.06202F));
            this.bottomTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.93798F));
            this.bottomTableLayoutPanel.Size = new System.Drawing.Size(2480, 154);
            this.bottomTableLayoutPanel.TabIndex = 1;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.bottomTableLayoutPanel.SetColumnSpan(this.errorLabel, 2);
            this.errorLabel.Location = new System.Drawing.Point(829, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(35, 37);
            this.errorLabel.TabIndex = 0;
            this.errorLabel.Text = "  ";
            // 
            // RentAgainButton
            // 
            this.RentAgainButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RentAgainButton.Enabled = false;
            this.RentAgainButton.Location = new System.Drawing.Point(273, 77);
            this.RentAgainButton.Name = "RentAgainButton";
            this.RentAgainButton.Size = new System.Drawing.Size(279, 63);
            this.RentAgainButton.TabIndex = 1;
            this.RentAgainButton.Text = "Rent Again";
            this.RentAgainButton.UseVisualStyleBackColor = true;
            this.RentAgainButton.Visible = false;
            this.RentAgainButton.Click += new System.EventHandler(this.RentAgainButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ReturnButton.Location = new System.Drawing.Point(1047, 77);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(383, 63);
            this.ReturnButton.TabIndex = 2;
            this.ReturnButton.Text = "Add to Return Cart";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CloseButton.Location = new System.Drawing.Point(1949, 77);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(234, 63);
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
            this.furnitureOrderedDataGridView.Location = new System.Drawing.Point(3, 455);
            this.furnitureOrderedDataGridView.Name = "furnitureOrderedDataGridView";
            this.furnitureOrderedDataGridView.ReadOnly = true;
            this.furnitureOrderedDataGridView.RowHeadersVisible = false;
            this.furnitureOrderedDataGridView.RowHeadersWidth = 123;
            this.furnitureOrderedDataGridView.RowTemplate.Height = 46;
            this.furnitureOrderedDataGridView.Size = new System.Drawing.Size(2480, 683);
            this.furnitureOrderedDataGridView.TabIndex = 2;
            this.furnitureOrderedDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
            // 
            // FurnitureID
            // 
            this.FurnitureID.HeaderText = "Furniture ID";
            this.FurnitureID.MinimumWidth = 15;
            this.FurnitureID.Name = "FurnitureID";
            this.FurnitureID.ReadOnly = true;
            this.FurnitureID.Width = 300;
            // 
            // FurnitureName
            // 
            this.FurnitureName.HeaderText = "Name";
            this.FurnitureName.MinimumWidth = 15;
            this.FurnitureName.Name = "FurnitureName";
            this.FurnitureName.ReadOnly = true;
            this.FurnitureName.Width = 300;
            // 
            // RentalDate
            // 
            this.RentalDate.HeaderText = "Rental Date";
            this.RentalDate.MinimumWidth = 15;
            this.RentalDate.Name = "RentalDate";
            this.RentalDate.ReadOnly = true;
            this.RentalDate.Width = 300;
            // 
            // QtyRented
            // 
            this.QtyRented.HeaderText = "Qty Rented";
            this.QtyRented.MinimumWidth = 15;
            this.QtyRented.Name = "QtyRented";
            this.QtyRented.ReadOnly = true;
            this.QtyRented.Width = 300;
            // 
            // QtyReturned
            // 
            this.QtyReturned.HeaderText = "Qty Returned";
            this.QtyReturned.MinimumWidth = 15;
            this.QtyReturned.Name = "QtyReturned";
            this.QtyReturned.ReadOnly = true;
            this.QtyReturned.Width = 300;
            // 
            // RentalRate
            // 
            this.RentalRate.HeaderText = "Rental Rate";
            this.RentalRate.MinimumWidth = 15;
            this.RentalRate.Name = "RentalRate";
            this.RentalRate.ReadOnly = true;
            this.RentalRate.Width = 300;
            // 
            // FineRate
            // 
            this.FineRate.HeaderText = "Fine Rate";
            this.FineRate.MinimumWidth = 15;
            this.FineRate.Name = "FineRate";
            this.FineRate.ReadOnly = true;
            this.FineRate.Width = 300;
            // 
            // Balance
            // 
            this.Balance.HeaderText = "Balance";
            this.Balance.MinimumWidth = 15;
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            this.Balance.Width = 300;
            // 
            // qtyReturnNumericUpDown
            // 
            this.qtyReturnNumericUpDown.Location = new System.Drawing.Point(1406, 216);
            this.qtyReturnNumericUpDown.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.qtyReturnNumericUpDown.Name = "qtyReturnNumericUpDown";
            this.qtyReturnNumericUpDown.ReadOnly = true;
            this.qtyReturnNumericUpDown.Size = new System.Drawing.Size(361, 44);
            this.qtyReturnNumericUpDown.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1083, 222);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Return how many?";
            // 
            // ViewOrderModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2483, 1312);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qtyReturnNumericUpDown);
            this.Controls.Add(this.furnitureOrderedDataGridView);
            this.Controls.Add(this.bottomTableLayoutPanel);
            this.Controls.Add(this.topLableLayoutPanel);
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