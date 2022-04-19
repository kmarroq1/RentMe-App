
namespace RentMe_App.UserControls.MemberDashboardUCs
{
    partial class RentalCartUserControl
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
            this.rentalCartDataGridView = new System.Windows.Forms.DataGridView();
            this.rentalCartHeaderLabel = new System.Windows.Forms.Label();
            this.completeRentalButton = new System.Windows.Forms.Button();
            this.clearRentalsButton = new System.Windows.Forms.Button();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.buttonFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.totalItemsInCartLabel = new System.Windows.Forms.Label();
            this.totalItemsInCartValuelabel = new System.Windows.Forms.Label();
            this.currentTotalLabel = new System.Windows.Forms.Label();
            this.currentTotalValueLabel = new System.Windows.Forms.Label();
            this.dueDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dueDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rentalCartDataGridView)).BeginInit();
            this.buttonFlowLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rentalCartDataGridView
            // 
            this.rentalCartDataGridView.AllowUserToAddRows = false;
            this.rentalCartDataGridView.AllowUserToDeleteRows = false;
            this.rentalCartDataGridView.AllowUserToOrderColumns = true;
            this.rentalCartDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rentalCartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentalCartDataGridView.Location = new System.Drawing.Point(16, 151);
            this.rentalCartDataGridView.Name = "rentalCartDataGridView";
            this.rentalCartDataGridView.ReadOnly = true;
            this.rentalCartDataGridView.Size = new System.Drawing.Size(797, 265);
            this.rentalCartDataGridView.TabIndex = 37;
            this.rentalCartDataGridView.VisibleChanged += new System.EventHandler(this.RentalCartDataGridView_VisibleChanged);
            // 
            // rentalCartHeaderLabel
            // 
            this.rentalCartHeaderLabel.AutoSize = true;
            this.rentalCartHeaderLabel.BackColor = System.Drawing.SystemColors.Control;
            this.rentalCartHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.rentalCartHeaderLabel.Location = new System.Drawing.Point(20, 18);
            this.rentalCartHeaderLabel.Name = "rentalCartHeaderLabel";
            this.rentalCartHeaderLabel.Size = new System.Drawing.Size(90, 17);
            this.rentalCartHeaderLabel.TabIndex = 0;
            this.rentalCartHeaderLabel.Text = "Rental Cart";
            // 
            // completeRentalButton
            // 
            this.completeRentalButton.AutoSize = true;
            this.completeRentalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.completeRentalButton.Location = new System.Drawing.Point(3, 3);
            this.completeRentalButton.Name = "completeRentalButton";
            this.completeRentalButton.Size = new System.Drawing.Size(95, 23);
            this.completeRentalButton.TabIndex = 31;
            this.completeRentalButton.Text = "Complete Rental";
            this.completeRentalButton.UseVisualStyleBackColor = true;
            this.completeRentalButton.Click += new System.EventHandler(this.CompleteRentalButton_Click);
            // 
            // clearRentalsButton
            // 
            this.clearRentalsButton.AutoSize = true;
            this.clearRentalsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.clearRentalsButton.Location = new System.Drawing.Point(104, 3);
            this.clearRentalsButton.Name = "clearRentalsButton";
            this.clearRentalsButton.Size = new System.Drawing.Size(80, 23);
            this.clearRentalsButton.TabIndex = 32;
            this.clearRentalsButton.Text = "Clear Rentals";
            this.clearRentalsButton.UseVisualStyleBackColor = true;
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.errorMessageLabel.AutoSize = true;
            this.errorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.errorMessageLabel.Location = new System.Drawing.Point(372, 8);
            this.errorMessageLabel.MaximumSize = new System.Drawing.Size(400, 0);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(16, 13);
            this.errorMessageLabel.TabIndex = 26;
            this.errorMessageLabel.Text = "   ";
            this.errorMessageLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonFlowLayoutPanel
            // 
            this.buttonFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonFlowLayoutPanel.AutoSize = true;
            this.buttonFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonFlowLayoutPanel.Controls.Add(this.completeRentalButton);
            this.buttonFlowLayoutPanel.Controls.Add(this.clearRentalsButton);
            this.buttonFlowLayoutPanel.Location = new System.Drawing.Point(326, 458);
            this.buttonFlowLayoutPanel.Name = "buttonFlowLayoutPanel";
            this.buttonFlowLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonFlowLayoutPanel.Size = new System.Drawing.Size(187, 29);
            this.buttonFlowLayoutPanel.TabIndex = 40;
            this.buttonFlowLayoutPanel.WrapContents = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.errorMessageLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(32, 422);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 30);
            this.tableLayoutPanel1.TabIndex = 38;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.09524F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.90476F));
            this.tableLayoutPanel2.Controls.Add(this.currentTotalValueLabel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.currentTotalLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.totalItemsInCartValuelabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.totalItemsInCartLabel, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(16, 53);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(357, 60);
            this.tableLayoutPanel2.TabIndex = 41;
            // 
            // totalItemsInCartLabel
            // 
            this.totalItemsInCartLabel.AutoSize = true;
            this.totalItemsInCartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalItemsInCartLabel.Location = new System.Drawing.Point(3, 0);
            this.totalItemsInCartLabel.Name = "totalItemsInCartLabel";
            this.totalItemsInCartLabel.Size = new System.Drawing.Size(115, 13);
            this.totalItemsInCartLabel.TabIndex = 42;
            this.totalItemsInCartLabel.Text = "Total Items in Cart:";
            // 
            // totalItemsInCartValuelabel
            // 
            this.totalItemsInCartValuelabel.AutoSize = true;
            this.totalItemsInCartValuelabel.Location = new System.Drawing.Point(138, 0);
            this.totalItemsInCartValuelabel.Name = "totalItemsInCartValuelabel";
            this.totalItemsInCartValuelabel.Size = new System.Drawing.Size(13, 13);
            this.totalItemsInCartValuelabel.TabIndex = 43;
            this.totalItemsInCartValuelabel.Text = "  ";
            // 
            // currentTotalLabel
            // 
            this.currentTotalLabel.AutoSize = true;
            this.currentTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTotalLabel.Location = new System.Drawing.Point(3, 30);
            this.currentTotalLabel.Name = "currentTotalLabel";
            this.currentTotalLabel.Size = new System.Drawing.Size(85, 13);
            this.currentTotalLabel.TabIndex = 44;
            this.currentTotalLabel.Text = "Current Total:";
            // 
            // currentTotalValueLabel
            // 
            this.currentTotalValueLabel.AutoSize = true;
            this.currentTotalValueLabel.Location = new System.Drawing.Point(138, 30);
            this.currentTotalValueLabel.Name = "currentTotalValueLabel";
            this.currentTotalValueLabel.Size = new System.Drawing.Size(13, 13);
            this.currentTotalValueLabel.TabIndex = 45;
            this.currentTotalValueLabel.Text = "  ";
            // 
            // dueDateTimePicker
            // 
            this.dueDateTimePicker.Location = new System.Drawing.Point(88, 120);
            this.dueDateTimePicker.Name = "dueDateTimePicker";
            this.dueDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dueDateTimePicker.TabIndex = 42;
            // 
            // dueDateLabel
            // 
            this.dueDateLabel.AutoSize = true;
            this.dueDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueDateLabel.Location = new System.Drawing.Point(19, 123);
            this.dueDateLabel.Name = "dueDateLabel";
            this.dueDateLabel.Size = new System.Drawing.Size(65, 13);
            this.dueDateLabel.TabIndex = 45;
            this.dueDateLabel.Text = "Due Date:";
            // 
            // RentalCartUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dueDateLabel);
            this.Controls.Add(this.dueDateTimePicker);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.rentalCartHeaderLabel);
            this.Controls.Add(this.rentalCartDataGridView);
            this.Controls.Add(this.buttonFlowLayoutPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RentalCartUserControl";
            this.Size = new System.Drawing.Size(828, 502);
            this.Load += new System.EventHandler(this.RentalCartUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rentalCartDataGridView)).EndInit();
            this.buttonFlowLayoutPanel.ResumeLayout(false);
            this.buttonFlowLayoutPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView rentalCartDataGridView;
        private System.Windows.Forms.Label rentalCartHeaderLabel;
        private System.Windows.Forms.Button completeRentalButton;
        private System.Windows.Forms.Button clearRentalsButton;
        private System.Windows.Forms.Label errorMessageLabel;
        private System.Windows.Forms.FlowLayoutPanel buttonFlowLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label currentTotalValueLabel;
        private System.Windows.Forms.Label currentTotalLabel;
        private System.Windows.Forms.Label totalItemsInCartValuelabel;
        private System.Windows.Forms.Label totalItemsInCartLabel;
        private System.Windows.Forms.DateTimePicker dueDateTimePicker;
        private System.Windows.Forms.Label dueDateLabel;
    }
}
