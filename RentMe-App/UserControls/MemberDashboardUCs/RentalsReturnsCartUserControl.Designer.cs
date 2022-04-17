
namespace RentMe_App.UserControls.MemberDashboardUCs
{
    partial class RentalsReturnsCartUserControl
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
            this.ButtonGroupsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ReturnButtonsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CompleteReturnButton = new System.Windows.Forms.Button();
            this.ViewReturnItemButton = new System.Windows.Forms.Button();
            this.ClearReturnsButton = new System.Windows.Forms.Button();
            this.RentalButtonsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CompleteRentalButton = new System.Windows.Forms.Button();
            this.ViewRentalItemButton = new System.Windows.Forms.Button();
            this.ClearRentalsButton = new System.Windows.Forms.Button();
            this.ErrorMessage = new System.Windows.Forms.Label();
            this.HeadersTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ReturnSumsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ReturnCountFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ReturnCountLabelLabel = new System.Windows.Forms.Label();
            this.ReturnCountValueLabel = new System.Windows.Forms.Label();
            this.ReturnBalanceFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ReturnBalanceLabelLabel = new System.Windows.Forms.Label();
            this.ReturnBalanceValueLabel = new System.Windows.Forms.Label();
            this.ReturnsHeaderLabel = new System.Windows.Forms.Label();
            this.RentalsHeaderLabel = new System.Windows.Forms.Label();
            this.RentalDueDateFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.RentalDueDateLabel = new System.Windows.Forms.Label();
            this.DueDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.RentalSumsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.RentalCountFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.RentalCountLabelLabel = new System.Windows.Forms.Label();
            this.RentalCountValueLabel = new System.Windows.Forms.Label();
            this.RentalTotalFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.RentalTotalLabelLabel = new System.Windows.Forms.Label();
            this.RentalTotalValueLabel = new System.Windows.Forms.Label();
            this.GridViewsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ReturnsDataGridView = new System.Windows.Forms.DataGridView();
            this.ReturnIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.ReturnNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnQuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnBalanceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDeleteButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.RentalsDataGridView = new System.Windows.Forms.DataGridView();
            this.RentalIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentalImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.RentalNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentalQuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentalRateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentalDeleteButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ButtonGroupsTableLayoutPanel.SuspendLayout();
            this.ReturnButtonsFlowLayoutPanel.SuspendLayout();
            this.RentalButtonsFlowLayoutPanel.SuspendLayout();
            this.HeadersTableLayoutPanel.SuspendLayout();
            this.ReturnSumsFlowLayoutPanel.SuspendLayout();
            this.ReturnCountFlowLayoutPanel.SuspendLayout();
            this.ReturnBalanceFlowLayoutPanel.SuspendLayout();
            this.RentalDueDateFlowLayoutPanel.SuspendLayout();
            this.RentalSumsFlowLayoutPanel.SuspendLayout();
            this.RentalCountFlowLayoutPanel.SuspendLayout();
            this.RentalTotalFlowLayoutPanel.SuspendLayout();
            this.GridViewsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentalsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonGroupsTableLayoutPanel
            // 
            this.ButtonGroupsTableLayoutPanel.ColumnCount = 2;
            this.ButtonGroupsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonGroupsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonGroupsTableLayoutPanel.Controls.Add(this.ReturnButtonsFlowLayoutPanel, 1, 1);
            this.ButtonGroupsTableLayoutPanel.Controls.Add(this.RentalButtonsFlowLayoutPanel, 0, 1);
            this.ButtonGroupsTableLayoutPanel.Controls.Add(this.ErrorMessage, 0, 0);
            this.ButtonGroupsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonGroupsTableLayoutPanel.Location = new System.Drawing.Point(0, 357);
            this.ButtonGroupsTableLayoutPanel.Name = "ButtonGroupsTableLayoutPanel";
            this.ButtonGroupsTableLayoutPanel.RowCount = 2;
            this.ButtonGroupsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ButtonGroupsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ButtonGroupsTableLayoutPanel.Size = new System.Drawing.Size(849, 69);
            this.ButtonGroupsTableLayoutPanel.TabIndex = 0;
            // 
            // ReturnButtonsFlowLayoutPanel
            // 
            this.ReturnButtonsFlowLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReturnButtonsFlowLayoutPanel.AutoSize = true;
            this.ReturnButtonsFlowLayoutPanel.Controls.Add(this.CompleteReturnButton);
            this.ReturnButtonsFlowLayoutPanel.Controls.Add(this.ViewReturnItemButton);
            this.ReturnButtonsFlowLayoutPanel.Controls.Add(this.ClearReturnsButton);
            this.ReturnButtonsFlowLayoutPanel.Location = new System.Drawing.Point(501, 26);
            this.ReturnButtonsFlowLayoutPanel.Name = "ReturnButtonsFlowLayoutPanel";
            this.ReturnButtonsFlowLayoutPanel.Size = new System.Drawing.Size(270, 29);
            this.ReturnButtonsFlowLayoutPanel.TabIndex = 1;
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
            // 
            // ViewReturnItemButton
            // 
            this.ViewReturnItemButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ViewReturnItemButton.AutoSize = true;
            this.ViewReturnItemButton.Location = new System.Drawing.Point(105, 3);
            this.ViewReturnItemButton.Name = "ViewReturnItemButton";
            this.ViewReturnItemButton.Size = new System.Drawing.Size(75, 23);
            this.ViewReturnItemButton.TabIndex = 1;
            this.ViewReturnItemButton.Text = "View Item";
            this.ViewReturnItemButton.UseVisualStyleBackColor = true;
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
            // 
            // RentalButtonsFlowLayoutPanel
            // 
            this.RentalButtonsFlowLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RentalButtonsFlowLayoutPanel.AutoSize = true;
            this.RentalButtonsFlowLayoutPanel.Controls.Add(this.CompleteRentalButton);
            this.RentalButtonsFlowLayoutPanel.Controls.Add(this.ViewRentalItemButton);
            this.RentalButtonsFlowLayoutPanel.Controls.Add(this.ClearRentalsButton);
            this.RentalButtonsFlowLayoutPanel.Location = new System.Drawing.Point(78, 26);
            this.RentalButtonsFlowLayoutPanel.Name = "RentalButtonsFlowLayoutPanel";
            this.RentalButtonsFlowLayoutPanel.Size = new System.Drawing.Size(268, 29);
            this.RentalButtonsFlowLayoutPanel.TabIndex = 0;
            // 
            // CompleteRentalButton
            // 
            this.CompleteRentalButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CompleteRentalButton.AutoSize = true;
            this.CompleteRentalButton.Location = new System.Drawing.Point(3, 3);
            this.CompleteRentalButton.Name = "CompleteRentalButton";
            this.CompleteRentalButton.Size = new System.Drawing.Size(95, 23);
            this.CompleteRentalButton.TabIndex = 0;
            this.CompleteRentalButton.Text = "Complete Rental";
            this.CompleteRentalButton.UseVisualStyleBackColor = true;
            // 
            // ViewRentalItemButton
            // 
            this.ViewRentalItemButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ViewRentalItemButton.AutoSize = true;
            this.ViewRentalItemButton.Location = new System.Drawing.Point(104, 3);
            this.ViewRentalItemButton.Name = "ViewRentalItemButton";
            this.ViewRentalItemButton.Size = new System.Drawing.Size(75, 23);
            this.ViewRentalItemButton.TabIndex = 1;
            this.ViewRentalItemButton.Text = "View Item";
            this.ViewRentalItemButton.UseVisualStyleBackColor = true;
            // 
            // ClearRentalsButton
            // 
            this.ClearRentalsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClearRentalsButton.AutoSize = true;
            this.ClearRentalsButton.Location = new System.Drawing.Point(185, 3);
            this.ClearRentalsButton.Name = "ClearRentalsButton";
            this.ClearRentalsButton.Size = new System.Drawing.Size(80, 23);
            this.ClearRentalsButton.TabIndex = 2;
            this.ClearRentalsButton.Text = "Clear Rentals";
            this.ClearRentalsButton.UseVisualStyleBackColor = true;
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ErrorMessage.AutoSize = true;
            this.ButtonGroupsTableLayoutPanel.SetColumnSpan(this.ErrorMessage, 2);
            this.ErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessage.Location = new System.Drawing.Point(387, 0);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(75, 13);
            this.ErrorMessage.TabIndex = 2;
            this.ErrorMessage.Text = "Error Message";
            this.ErrorMessage.Visible = false;
            // 
            // HeadersTableLayoutPanel
            // 
            this.HeadersTableLayoutPanel.AutoSize = true;
            this.HeadersTableLayoutPanel.ColumnCount = 2;
            this.HeadersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HeadersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HeadersTableLayoutPanel.Controls.Add(this.ReturnSumsFlowLayoutPanel, 1, 1);
            this.HeadersTableLayoutPanel.Controls.Add(this.ReturnsHeaderLabel, 1, 0);
            this.HeadersTableLayoutPanel.Controls.Add(this.RentalsHeaderLabel, 0, 0);
            this.HeadersTableLayoutPanel.Controls.Add(this.RentalDueDateFlowLayoutPanel, 0, 2);
            this.HeadersTableLayoutPanel.Controls.Add(this.RentalSumsFlowLayoutPanel, 0, 1);
            this.HeadersTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeadersTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.HeadersTableLayoutPanel.Name = "HeadersTableLayoutPanel";
            this.HeadersTableLayoutPanel.RowCount = 3;
            this.HeadersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.HeadersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.HeadersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.HeadersTableLayoutPanel.Size = new System.Drawing.Size(849, 89);
            this.HeadersTableLayoutPanel.TabIndex = 1;
            // 
            // ReturnSumsFlowLayoutPanel
            // 
            this.ReturnSumsFlowLayoutPanel.AutoSize = true;
            this.ReturnSumsFlowLayoutPanel.Controls.Add(this.ReturnCountFlowLayoutPanel);
            this.ReturnSumsFlowLayoutPanel.Controls.Add(this.ReturnBalanceFlowLayoutPanel);
            this.ReturnSumsFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ReturnSumsFlowLayoutPanel.Location = new System.Drawing.Point(427, 16);
            this.ReturnSumsFlowLayoutPanel.Name = "ReturnSumsFlowLayoutPanel";
            this.ReturnSumsFlowLayoutPanel.Size = new System.Drawing.Size(134, 38);
            this.ReturnSumsFlowLayoutPanel.TabIndex = 6;
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
            // ReturnsHeaderLabel
            // 
            this.ReturnsHeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ReturnsHeaderLabel.AutoSize = true;
            this.ReturnsHeaderLabel.Location = new System.Drawing.Point(427, 0);
            this.ReturnsHeaderLabel.Name = "ReturnsHeaderLabel";
            this.ReturnsHeaderLabel.Size = new System.Drawing.Size(44, 13);
            this.ReturnsHeaderLabel.TabIndex = 1;
            this.ReturnsHeaderLabel.Text = "Returns";
            // 
            // RentalsHeaderLabel
            // 
            this.RentalsHeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RentalsHeaderLabel.AutoSize = true;
            this.RentalsHeaderLabel.Location = new System.Drawing.Point(3, 0);
            this.RentalsHeaderLabel.Name = "RentalsHeaderLabel";
            this.RentalsHeaderLabel.Size = new System.Drawing.Size(43, 13);
            this.RentalsHeaderLabel.TabIndex = 0;
            this.RentalsHeaderLabel.Text = "Rentals";
            // 
            // RentalDueDateFlowLayoutPanel
            // 
            this.RentalDueDateFlowLayoutPanel.AutoSize = true;
            this.RentalDueDateFlowLayoutPanel.Controls.Add(this.RentalDueDateLabel);
            this.RentalDueDateFlowLayoutPanel.Controls.Add(this.DueDateDateTimePicker);
            this.RentalDueDateFlowLayoutPanel.Location = new System.Drawing.Point(3, 60);
            this.RentalDueDateFlowLayoutPanel.Name = "RentalDueDateFlowLayoutPanel";
            this.RentalDueDateFlowLayoutPanel.Size = new System.Drawing.Size(203, 26);
            this.RentalDueDateFlowLayoutPanel.TabIndex = 3;
            // 
            // RentalDueDateLabel
            // 
            this.RentalDueDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RentalDueDateLabel.AutoSize = true;
            this.RentalDueDateLabel.Location = new System.Drawing.Point(3, 6);
            this.RentalDueDateLabel.Name = "RentalDueDateLabel";
            this.RentalDueDateLabel.Size = new System.Drawing.Size(53, 13);
            this.RentalDueDateLabel.TabIndex = 1;
            this.RentalDueDateLabel.Text = "Due Date";
            // 
            // DueDateDateTimePicker
            // 
            this.DueDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DueDateDateTimePicker.Location = new System.Drawing.Point(62, 3);
            this.DueDateDateTimePicker.Name = "DueDateDateTimePicker";
            this.DueDateDateTimePicker.Size = new System.Drawing.Size(138, 20);
            this.DueDateDateTimePicker.TabIndex = 0;
            // 
            // RentalSumsFlowLayoutPanel
            // 
            this.RentalSumsFlowLayoutPanel.AutoSize = true;
            this.RentalSumsFlowLayoutPanel.Controls.Add(this.RentalCountFlowLayoutPanel);
            this.RentalSumsFlowLayoutPanel.Controls.Add(this.RentalTotalFlowLayoutPanel);
            this.RentalSumsFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.RentalSumsFlowLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.RentalSumsFlowLayoutPanel.Name = "RentalSumsFlowLayoutPanel";
            this.RentalSumsFlowLayoutPanel.Size = new System.Drawing.Size(134, 38);
            this.RentalSumsFlowLayoutPanel.TabIndex = 5;
            // 
            // RentalCountFlowLayoutPanel
            // 
            this.RentalCountFlowLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RentalCountFlowLayoutPanel.AutoSize = true;
            this.RentalCountFlowLayoutPanel.Controls.Add(this.RentalCountLabelLabel);
            this.RentalCountFlowLayoutPanel.Controls.Add(this.RentalCountValueLabel);
            this.RentalCountFlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.RentalCountFlowLayoutPanel.Name = "RentalCountFlowLayoutPanel";
            this.RentalCountFlowLayoutPanel.Size = new System.Drawing.Size(128, 13);
            this.RentalCountFlowLayoutPanel.TabIndex = 0;
            // 
            // RentalCountLabelLabel
            // 
            this.RentalCountLabelLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RentalCountLabelLabel.AutoSize = true;
            this.RentalCountLabelLabel.Location = new System.Drawing.Point(3, 0);
            this.RentalCountLabelLabel.Name = "RentalCountLabelLabel";
            this.RentalCountLabelLabel.Size = new System.Drawing.Size(95, 13);
            this.RentalCountLabelLabel.TabIndex = 0;
            this.RentalCountLabelLabel.Text = "Total Items in Cart:";
            // 
            // RentalCountValueLabel
            // 
            this.RentalCountValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RentalCountValueLabel.AutoSize = true;
            this.RentalCountValueLabel.Location = new System.Drawing.Point(104, 0);
            this.RentalCountValueLabel.Name = "RentalCountValueLabel";
            this.RentalCountValueLabel.Size = new System.Drawing.Size(21, 13);
            this.RentalCountValueLabel.TabIndex = 1;
            this.RentalCountValueLabel.Text = "XX";
            // 
            // RentalTotalFlowLayoutPanel
            // 
            this.RentalTotalFlowLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RentalTotalFlowLayoutPanel.AutoSize = true;
            this.RentalTotalFlowLayoutPanel.Controls.Add(this.RentalTotalLabelLabel);
            this.RentalTotalFlowLayoutPanel.Controls.Add(this.RentalTotalValueLabel);
            this.RentalTotalFlowLayoutPanel.Location = new System.Drawing.Point(3, 22);
            this.RentalTotalFlowLayoutPanel.Name = "RentalTotalFlowLayoutPanel";
            this.RentalTotalFlowLayoutPanel.Size = new System.Drawing.Size(110, 13);
            this.RentalTotalFlowLayoutPanel.TabIndex = 2;
            // 
            // RentalTotalLabelLabel
            // 
            this.RentalTotalLabelLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RentalTotalLabelLabel.AutoSize = true;
            this.RentalTotalLabelLabel.Location = new System.Drawing.Point(3, 0);
            this.RentalTotalLabelLabel.Name = "RentalTotalLabelLabel";
            this.RentalTotalLabelLabel.Size = new System.Drawing.Size(71, 13);
            this.RentalTotalLabelLabel.TabIndex = 0;
            this.RentalTotalLabelLabel.Text = "Current Total:";
            // 
            // RentalTotalValueLabel
            // 
            this.RentalTotalValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RentalTotalValueLabel.AutoSize = true;
            this.RentalTotalValueLabel.Location = new System.Drawing.Point(80, 0);
            this.RentalTotalValueLabel.Name = "RentalTotalValueLabel";
            this.RentalTotalValueLabel.Size = new System.Drawing.Size(27, 13);
            this.RentalTotalValueLabel.TabIndex = 1;
            this.RentalTotalValueLabel.Text = "$XX";
            // 
            // GridViewsTableLayoutPanel
            // 
            this.GridViewsTableLayoutPanel.ColumnCount = 2;
            this.GridViewsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GridViewsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GridViewsTableLayoutPanel.Controls.Add(this.ReturnsDataGridView, 1, 0);
            this.GridViewsTableLayoutPanel.Controls.Add(this.RentalsDataGridView, 0, 0);
            this.GridViewsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewsTableLayoutPanel.Location = new System.Drawing.Point(0, 89);
            this.GridViewsTableLayoutPanel.Name = "GridViewsTableLayoutPanel";
            this.GridViewsTableLayoutPanel.RowCount = 1;
            this.GridViewsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GridViewsTableLayoutPanel.Size = new System.Drawing.Size(849, 268);
            this.GridViewsTableLayoutPanel.TabIndex = 2;
            // 
            // ReturnsDataGridView
            // 
            this.ReturnsDataGridView.AllowUserToAddRows = false;
            this.ReturnsDataGridView.AllowUserToDeleteRows = false;
            this.ReturnsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReturnsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReturnIDColumn,
            this.ReturnImageColumn,
            this.ReturnNameColumn,
            this.ReturnQuantityColumn,
            this.ReturnBalanceColumn,
            this.ReturnDeleteButtonColumn});
            this.ReturnsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReturnsDataGridView.Location = new System.Drawing.Point(427, 3);
            this.ReturnsDataGridView.Name = "ReturnsDataGridView";
            this.ReturnsDataGridView.ReadOnly = true;
            this.ReturnsDataGridView.Size = new System.Drawing.Size(419, 262);
            this.ReturnsDataGridView.TabIndex = 1;
            // 
            // ReturnIDColumn
            // 
            this.ReturnIDColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ReturnIDColumn.HeaderText = "ID";
            this.ReturnIDColumn.Name = "ReturnIDColumn";
            this.ReturnIDColumn.ReadOnly = true;
            this.ReturnIDColumn.ToolTipText = "ID of the furniture";
            this.ReturnIDColumn.Width = 43;
            // 
            // ReturnImageColumn
            // 
            this.ReturnImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ReturnImageColumn.HeaderText = "Image";
            this.ReturnImageColumn.Name = "ReturnImageColumn";
            this.ReturnImageColumn.ReadOnly = true;
            this.ReturnImageColumn.Width = 42;
            // 
            // ReturnNameColumn
            // 
            this.ReturnNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ReturnNameColumn.HeaderText = "Name";
            this.ReturnNameColumn.Name = "ReturnNameColumn";
            this.ReturnNameColumn.ReadOnly = true;
            this.ReturnNameColumn.Width = 60;
            // 
            // ReturnQuantityColumn
            // 
            this.ReturnQuantityColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ReturnQuantityColumn.HeaderText = "Qty to Return";
            this.ReturnQuantityColumn.Name = "ReturnQuantityColumn";
            this.ReturnQuantityColumn.ReadOnly = true;
            this.ReturnQuantityColumn.Width = 95;
            // 
            // ReturnBalanceColumn
            // 
            this.ReturnBalanceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ReturnBalanceColumn.HeaderText = "Balance/Fine";
            this.ReturnBalanceColumn.Name = "ReturnBalanceColumn";
            this.ReturnBalanceColumn.ReadOnly = true;
            this.ReturnBalanceColumn.Width = 96;
            // 
            // ReturnDeleteButtonColumn
            // 
            this.ReturnDeleteButtonColumn.HeaderText = "";
            this.ReturnDeleteButtonColumn.Name = "ReturnDeleteButtonColumn";
            this.ReturnDeleteButtonColumn.ReadOnly = true;
            // 
            // RentalsDataGridView
            // 
            this.RentalsDataGridView.AllowUserToAddRows = false;
            this.RentalsDataGridView.AllowUserToDeleteRows = false;
            this.RentalsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentalsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RentalIDColumn,
            this.RentalImageColumn,
            this.RentalNameColumn,
            this.RentalQuantityColumn,
            this.RentalRateColumn,
            this.RentalDeleteButtonColumn});
            this.RentalsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RentalsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.RentalsDataGridView.Name = "RentalsDataGridView";
            this.RentalsDataGridView.ReadOnly = true;
            this.RentalsDataGridView.Size = new System.Drawing.Size(418, 262);
            this.RentalsDataGridView.TabIndex = 0;
            // 
            // RentalIDColumn
            // 
            this.RentalIDColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.RentalIDColumn.HeaderText = "ID";
            this.RentalIDColumn.Name = "RentalIDColumn";
            this.RentalIDColumn.ReadOnly = true;
            this.RentalIDColumn.ToolTipText = "ID of the furniture";
            this.RentalIDColumn.Width = 43;
            // 
            // RentalImageColumn
            // 
            this.RentalImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.RentalImageColumn.HeaderText = "Image";
            this.RentalImageColumn.Name = "RentalImageColumn";
            this.RentalImageColumn.ReadOnly = true;
            this.RentalImageColumn.Width = 42;
            // 
            // RentalNameColumn
            // 
            this.RentalNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.RentalNameColumn.HeaderText = "Name";
            this.RentalNameColumn.Name = "RentalNameColumn";
            this.RentalNameColumn.ReadOnly = true;
            this.RentalNameColumn.Width = 60;
            // 
            // RentalQuantityColumn
            // 
            this.RentalQuantityColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.RentalQuantityColumn.HeaderText = "Qty to Rent";
            this.RentalQuantityColumn.Name = "RentalQuantityColumn";
            this.RentalQuantityColumn.ReadOnly = true;
            this.RentalQuantityColumn.Width = 79;
            // 
            // RentalRateColumn
            // 
            this.RentalRateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.RentalRateColumn.HeaderText = "Daily Rental Rate";
            this.RentalRateColumn.Name = "RentalRateColumn";
            this.RentalRateColumn.ReadOnly = true;
            this.RentalRateColumn.Width = 105;
            // 
            // RentalDeleteButtonColumn
            // 
            this.RentalDeleteButtonColumn.HeaderText = "";
            this.RentalDeleteButtonColumn.Name = "RentalDeleteButtonColumn";
            this.RentalDeleteButtonColumn.ReadOnly = true;
            // 
            // RentalsReturnsCartUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GridViewsTableLayoutPanel);
            this.Controls.Add(this.HeadersTableLayoutPanel);
            this.Controls.Add(this.ButtonGroupsTableLayoutPanel);
            this.Name = "RentalsReturnsCartUserControl";
            this.Size = new System.Drawing.Size(849, 426);
            this.Load += new System.EventHandler(this.RentalsReturnsCartUserControl_Load);
            this.ButtonGroupsTableLayoutPanel.ResumeLayout(false);
            this.ButtonGroupsTableLayoutPanel.PerformLayout();
            this.ReturnButtonsFlowLayoutPanel.ResumeLayout(false);
            this.ReturnButtonsFlowLayoutPanel.PerformLayout();
            this.RentalButtonsFlowLayoutPanel.ResumeLayout(false);
            this.RentalButtonsFlowLayoutPanel.PerformLayout();
            this.HeadersTableLayoutPanel.ResumeLayout(false);
            this.HeadersTableLayoutPanel.PerformLayout();
            this.ReturnSumsFlowLayoutPanel.ResumeLayout(false);
            this.ReturnSumsFlowLayoutPanel.PerformLayout();
            this.ReturnCountFlowLayoutPanel.ResumeLayout(false);
            this.ReturnCountFlowLayoutPanel.PerformLayout();
            this.ReturnBalanceFlowLayoutPanel.ResumeLayout(false);
            this.ReturnBalanceFlowLayoutPanel.PerformLayout();
            this.RentalDueDateFlowLayoutPanel.ResumeLayout(false);
            this.RentalDueDateFlowLayoutPanel.PerformLayout();
            this.RentalSumsFlowLayoutPanel.ResumeLayout(false);
            this.RentalSumsFlowLayoutPanel.PerformLayout();
            this.RentalCountFlowLayoutPanel.ResumeLayout(false);
            this.RentalCountFlowLayoutPanel.PerformLayout();
            this.RentalTotalFlowLayoutPanel.ResumeLayout(false);
            this.RentalTotalFlowLayoutPanel.PerformLayout();
            this.GridViewsTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReturnsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentalsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ButtonGroupsTableLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel ReturnButtonsFlowLayoutPanel;
        private System.Windows.Forms.Button CompleteReturnButton;
        private System.Windows.Forms.Button ViewReturnItemButton;
        private System.Windows.Forms.Button ClearReturnsButton;
        private System.Windows.Forms.FlowLayoutPanel RentalButtonsFlowLayoutPanel;
        private System.Windows.Forms.Button CompleteRentalButton;
        private System.Windows.Forms.Button ViewRentalItemButton;
        private System.Windows.Forms.Button ClearRentalsButton;
        private System.Windows.Forms.Label ErrorMessage;
        private System.Windows.Forms.TableLayoutPanel HeadersTableLayoutPanel;
        private System.Windows.Forms.Label ReturnsHeaderLabel;
        private System.Windows.Forms.Label RentalsHeaderLabel;
        private System.Windows.Forms.FlowLayoutPanel RentalCountFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel RentalDueDateFlowLayoutPanel;
        private System.Windows.Forms.Label RentalDueDateLabel;
        private System.Windows.Forms.DateTimePicker DueDateDateTimePicker;
        private System.Windows.Forms.Label RentalCountLabelLabel;
        private System.Windows.Forms.Label RentalCountValueLabel;
        private System.Windows.Forms.FlowLayoutPanel ReturnSumsFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel ReturnCountFlowLayoutPanel;
        private System.Windows.Forms.Label ReturnCountLabelLabel;
        private System.Windows.Forms.Label ReturnCountValueLabel;
        private System.Windows.Forms.FlowLayoutPanel ReturnBalanceFlowLayoutPanel;
        private System.Windows.Forms.Label ReturnBalanceLabelLabel;
        private System.Windows.Forms.Label ReturnBalanceValueLabel;
        private System.Windows.Forms.FlowLayoutPanel RentalSumsFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel RentalTotalFlowLayoutPanel;
        private System.Windows.Forms.Label RentalTotalLabelLabel;
        private System.Windows.Forms.Label RentalTotalValueLabel;
        private System.Windows.Forms.TableLayoutPanel GridViewsTableLayoutPanel;
        private System.Windows.Forms.DataGridView RentalsDataGridView;
        private System.Windows.Forms.DataGridView ReturnsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnIDColumn;
        private System.Windows.Forms.DataGridViewImageColumn ReturnImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnQuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnBalanceColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ReturnDeleteButtonColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalIDColumn;
        private System.Windows.Forms.DataGridViewImageColumn RentalImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalQuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalRateColumn;
        private System.Windows.Forms.DataGridViewButtonColumn RentalDeleteButtonColumn;
    }
}
