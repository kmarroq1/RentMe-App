
namespace RentMe_App.UserControls.MemberDashboardUCs
{
    partial class OrdersAndReturnsUserControl
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.transactionIdTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.pendingOrdersCheckbox = new System.Windows.Forms.CheckBox();
            this.yearsComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.orderHistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.TransactionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateReturned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ViewButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.errorMsgLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderHistoryDataGridView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.62846F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.81028F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.transactionIdTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.SearchButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.pendingOrdersCheckbox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.yearsComboBox, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2530, 247);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orders and Returns";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1977, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Orders in";
            // 
            // transactionIdTextBox
            // 
            this.transactionIdTextBox.Location = new System.Drawing.Point(424, 126);
            this.transactionIdTextBox.Name = "transactionIdTextBox";
            this.transactionIdTextBox.Size = new System.Drawing.Size(358, 44);
            this.transactionIdTextBox.TabIndex = 3;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(845, 126);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(179, 63);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // pendingOrdersCheckbox
            // 
            this.pendingOrdersCheckbox.AutoSize = true;
            this.pendingOrdersCheckbox.Location = new System.Drawing.Point(1266, 126);
            this.pendingOrdersCheckbox.Name = "pendingOrdersCheckbox";
            this.pendingOrdersCheckbox.Size = new System.Drawing.Size(361, 41);
            this.pendingOrdersCheckbox.TabIndex = 5;
            this.pendingOrdersCheckbox.Text = "Pending Orders Only";
            this.pendingOrdersCheckbox.UseVisualStyleBackColor = true;
            // 
            // yearsComboBox
            // 
            this.yearsComboBox.FormattingEnabled = true;
            this.yearsComboBox.Location = new System.Drawing.Point(2132, 126);
            this.yearsComboBox.Name = "yearsComboBox";
            this.yearsComboBox.Size = new System.Drawing.Size(230, 45);
            this.yearsComboBox.TabIndex = 6;
            this.yearsComboBox.SelectedIndexChanged += new System.EventHandler(this.YearsComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Transaction ID";
            // 
            // orderHistoryDataGridView
            // 
            this.orderHistoryDataGridView.AllowUserToAddRows = false;
            this.orderHistoryDataGridView.AllowUserToDeleteRows = false;
            this.orderHistoryDataGridView.AllowUserToOrderColumns = true;
            this.orderHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderHistoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransactionId,
            this.TransactionType,
            this.OrderDate,
            this.DueDate,
            this.DateReturned,
            this.OrderTotal,
            this.Status,
            this.Balance});
            this.orderHistoryDataGridView.Location = new System.Drawing.Point(0, 256);
            this.orderHistoryDataGridView.Name = "orderHistoryDataGridView";
            this.orderHistoryDataGridView.ReadOnly = true;
            this.orderHistoryDataGridView.RowHeadersWidth = 123;
            this.orderHistoryDataGridView.RowTemplate.Height = 46;
            this.orderHistoryDataGridView.Size = new System.Drawing.Size(2530, 1011);
            this.orderHistoryDataGridView.TabIndex = 1;
            this.orderHistoryDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
            // 
            // TransactionId
            // 
            this.TransactionId.HeaderText = "ID";
            this.TransactionId.MinimumWidth = 15;
            this.TransactionId.Name = "TransactionId";
            this.TransactionId.ReadOnly = true;
            this.TransactionId.ToolTipText = "Transaction ID";
            this.TransactionId.Width = 300;
            // 
            // TransactionType
            // 
            this.TransactionType.HeaderText = "Type";
            this.TransactionType.MinimumWidth = 15;
            this.TransactionType.Name = "TransactionType";
            this.TransactionType.ReadOnly = true;
            this.TransactionType.Width = 300;
            // 
            // OrderDate
            // 
            this.OrderDate.HeaderText = "Order Date";
            this.OrderDate.MinimumWidth = 15;
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            this.OrderDate.Width = 300;
            // 
            // DueDate
            // 
            this.DueDate.HeaderText = "Due Date";
            this.DueDate.MinimumWidth = 15;
            this.DueDate.Name = "DueDate";
            this.DueDate.ReadOnly = true;
            this.DueDate.Width = 300;
            // 
            // DateReturned
            // 
            this.DateReturned.HeaderText = "Date Returned";
            this.DateReturned.MinimumWidth = 15;
            this.DateReturned.Name = "DateReturned";
            this.DateReturned.ReadOnly = true;
            this.DateReturned.Width = 300;
            // 
            // OrderTotal
            // 
            this.OrderTotal.HeaderText = "Order Total";
            this.OrderTotal.MinimumWidth = 15;
            this.OrderTotal.Name = "OrderTotal";
            this.OrderTotal.ReadOnly = true;
            this.OrderTotal.Width = 300;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 15;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 300;
            // 
            // Balance
            // 
            this.Balance.HeaderText = "Balance";
            this.Balance.MinimumWidth = 15;
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            this.Balance.Width = 300;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Controls.Add(this.ViewButton, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.ClearButton, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.errorMsgLabel, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 1273);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(2526, 147);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // ViewButton
            // 
            this.ViewButton.Location = new System.Drawing.Point(843, 76);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(179, 59);
            this.ViewButton.TabIndex = 0;
            this.ViewButton.Text = "View";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(1263, 76);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(207, 59);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // errorMsgLabel
            // 
            this.errorMsgLabel.AutoSize = true;
            this.errorMsgLabel.ForeColor = System.Drawing.Color.Red;
            this.errorMsgLabel.Location = new System.Drawing.Point(843, 0);
            this.errorMsgLabel.Name = "errorMsgLabel";
            this.errorMsgLabel.Size = new System.Drawing.Size(35, 37);
            this.errorMsgLabel.TabIndex = 2;
            this.errorMsgLabel.Text = "  ";
            // 
            // OrdersAndReturnsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.orderHistoryDataGridView);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "OrdersAndReturnsUserControl";
            this.Size = new System.Drawing.Size(2533, 1423);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderHistoryDataGridView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox transactionIdTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.CheckBox pendingOrdersCheckbox;
        private System.Windows.Forms.ComboBox yearsComboBox;
        private System.Windows.Forms.DataGridView orderHistoryDataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label errorMsgLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateReturned;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
    }
}
