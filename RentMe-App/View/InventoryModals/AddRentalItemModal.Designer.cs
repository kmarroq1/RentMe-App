
namespace RentMe_App.View.InventoryModals
{
    partial class AddRentalItemModal
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
            this.addToCartButton = new System.Windows.Forms.Button();
            this.buttonFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.furnitureIDLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.furnitureIDValueLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.styleLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.dailyRentalRateLabel = new System.Windows.Forms.Label();
            this.nameValueLabel = new System.Windows.Forms.Label();
            this.descriptionValueLabel = new System.Windows.Forms.Label();
            this.styleValueLabel = new System.Windows.Forms.Label();
            this.categoryValueLabel = new System.Windows.Forms.Label();
            this.dailyRentalRateValueLabel = new System.Windows.Forms.Label();
            this.quantityToRentLabel = new System.Windows.Forms.Label();
            this.quantityToRentNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.quantityInStockLabel = new System.Windows.Forms.Label();
            this.quantityInStockValueLabel = new System.Windows.Forms.Label();
            this.buttonFlowLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityToRentNumericUpDown)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // addToCartButton
            // 
            this.addToCartButton.Location = new System.Drawing.Point(3, 3);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(75, 23);
            this.addToCartButton.TabIndex = 0;
            this.addToCartButton.Text = "Add to Cart";
            this.addToCartButton.UseVisualStyleBackColor = true;
            // 
            // buttonFlowLayoutPanel
            // 
            this.buttonFlowLayoutPanel.AutoSize = true;
            this.buttonFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonFlowLayoutPanel.Controls.Add(this.addToCartButton);
            this.buttonFlowLayoutPanel.Controls.Add(this.cancelButton);
            this.buttonFlowLayoutPanel.Location = new System.Drawing.Point(132, 434);
            this.buttonFlowLayoutPanel.Name = "buttonFlowLayoutPanel";
            this.buttonFlowLayoutPanel.Size = new System.Drawing.Size(162, 29);
            this.buttonFlowLayoutPanel.TabIndex = 1;
            this.buttonFlowLayoutPanel.WrapContents = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(84, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // furnitureIDLabel
            // 
            this.furnitureIDLabel.AutoSize = true;
            this.furnitureIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.furnitureIDLabel.Location = new System.Drawing.Point(3, 0);
            this.furnitureIDLabel.Name = "furnitureIDLabel";
            this.furnitureIDLabel.Size = new System.Drawing.Size(146, 17);
            this.furnitureIDLabel.TabIndex = 2;
            this.furnitureIDLabel.Text = "Rental FurnitureID:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.01453F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.98547F));
            this.tableLayoutPanel1.Controls.Add(this.furnitureIDValueLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.furnitureIDLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nameLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.descriptionLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.styleLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.categoryLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.dailyRentalRateLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.nameValueLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.descriptionValueLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.styleValueLabel, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.categoryValueLabel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.dailyRentalRateValueLabel, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.quantityInStockValueLabel, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.quantityInStockLabel, 0, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.17391F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.82609F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 151F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(413, 326);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // furnitureIDValueLabel
            // 
            this.furnitureIDValueLabel.AutoSize = true;
            this.furnitureIDValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.furnitureIDValueLabel.Location = new System.Drawing.Point(160, 0);
            this.furnitureIDValueLabel.Name = "furnitureIDValueLabel";
            this.furnitureIDValueLabel.Size = new System.Drawing.Size(16, 17);
            this.furnitureIDValueLabel.TabIndex = 8;
            this.furnitureIDValueLabel.Text = "  ";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(3, 37);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(39, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(3, 63);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(71, 13);
            this.descriptionLabel.TabIndex = 4;
            this.descriptionLabel.Text = "Description";
            // 
            // styleLabel
            // 
            this.styleLabel.AutoSize = true;
            this.styleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.styleLabel.Location = new System.Drawing.Point(3, 214);
            this.styleLabel.Name = "styleLabel";
            this.styleLabel.Size = new System.Drawing.Size(35, 13);
            this.styleLabel.TabIndex = 5;
            this.styleLabel.Text = "Style";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.Location = new System.Drawing.Point(3, 236);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(57, 13);
            this.categoryLabel.TabIndex = 6;
            this.categoryLabel.Text = "Category";
            // 
            // dailyRentalRateLabel
            // 
            this.dailyRentalRateLabel.AutoSize = true;
            this.dailyRentalRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyRentalRateLabel.Location = new System.Drawing.Point(3, 262);
            this.dailyRentalRateLabel.Name = "dailyRentalRateLabel";
            this.dailyRentalRateLabel.Size = new System.Drawing.Size(107, 13);
            this.dailyRentalRateLabel.TabIndex = 7;
            this.dailyRentalRateLabel.Text = "Daily Rental Rate";
            // 
            // nameValueLabel
            // 
            this.nameValueLabel.AutoSize = true;
            this.nameValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameValueLabel.Location = new System.Drawing.Point(160, 37);
            this.nameValueLabel.Name = "nameValueLabel";
            this.nameValueLabel.Size = new System.Drawing.Size(13, 13);
            this.nameValueLabel.TabIndex = 9;
            this.nameValueLabel.Text = "  ";
            // 
            // descriptionValueLabel
            // 
            this.descriptionValueLabel.AutoSize = true;
            this.descriptionValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionValueLabel.Location = new System.Drawing.Point(160, 63);
            this.descriptionValueLabel.Name = "descriptionValueLabel";
            this.descriptionValueLabel.Size = new System.Drawing.Size(13, 13);
            this.descriptionValueLabel.TabIndex = 10;
            this.descriptionValueLabel.Text = "  ";
            // 
            // styleValueLabel
            // 
            this.styleValueLabel.AutoSize = true;
            this.styleValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.styleValueLabel.Location = new System.Drawing.Point(160, 214);
            this.styleValueLabel.Name = "styleValueLabel";
            this.styleValueLabel.Size = new System.Drawing.Size(13, 13);
            this.styleValueLabel.TabIndex = 11;
            this.styleValueLabel.Text = "  ";
            // 
            // categoryValueLabel
            // 
            this.categoryValueLabel.AutoSize = true;
            this.categoryValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryValueLabel.Location = new System.Drawing.Point(160, 236);
            this.categoryValueLabel.Name = "categoryValueLabel";
            this.categoryValueLabel.Size = new System.Drawing.Size(13, 13);
            this.categoryValueLabel.TabIndex = 12;
            this.categoryValueLabel.Text = "  ";
            // 
            // dailyRentalRateValueLabel
            // 
            this.dailyRentalRateValueLabel.AutoSize = true;
            this.dailyRentalRateValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyRentalRateValueLabel.Location = new System.Drawing.Point(160, 262);
            this.dailyRentalRateValueLabel.Name = "dailyRentalRateValueLabel";
            this.dailyRentalRateValueLabel.Size = new System.Drawing.Size(13, 13);
            this.dailyRentalRateValueLabel.TabIndex = 13;
            this.dailyRentalRateValueLabel.Text = "  ";
            // 
            // quantityToRentLabel
            // 
            this.quantityToRentLabel.AutoSize = true;
            this.quantityToRentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityToRentLabel.Location = new System.Drawing.Point(15, 368);
            this.quantityToRentLabel.Name = "quantityToRentLabel";
            this.quantityToRentLabel.Size = new System.Drawing.Size(100, 13);
            this.quantityToRentLabel.TabIndex = 8;
            this.quantityToRentLabel.Text = "Quantity to Rent";
            // 
            // quantityToRentNumericUpDown
            // 
            this.quantityToRentNumericUpDown.Location = new System.Drawing.Point(124, 366);
            this.quantityToRentNumericUpDown.Name = "quantityToRentNumericUpDown";
            this.quantityToRentNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.quantityToRentNumericUpDown.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.errorMessageLabel, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 395);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(413, 30);
            this.tableLayoutPanel2.TabIndex = 34;
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.errorMessageLabel.AutoSize = true;
            this.errorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.errorMessageLabel.Location = new System.Drawing.Point(198, 8);
            this.errorMessageLabel.MaximumSize = new System.Drawing.Size(400, 0);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(16, 13);
            this.errorMessageLabel.TabIndex = 26;
            this.errorMessageLabel.Text = "   ";
            this.errorMessageLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // quantityInStockLabel
            // 
            this.quantityInStockLabel.AutoSize = true;
            this.quantityInStockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityInStockLabel.Location = new System.Drawing.Point(3, 294);
            this.quantityInStockLabel.Name = "quantityInStockLabel";
            this.quantityInStockLabel.Size = new System.Drawing.Size(106, 13);
            this.quantityInStockLabel.TabIndex = 14;
            this.quantityInStockLabel.Text = "Quantity In Stock";
            // 
            // quantityInStockValueLabel
            // 
            this.quantityInStockValueLabel.AutoSize = true;
            this.quantityInStockValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityInStockValueLabel.Location = new System.Drawing.Point(160, 294);
            this.quantityInStockValueLabel.Name = "quantityInStockValueLabel";
            this.quantityInStockValueLabel.Size = new System.Drawing.Size(13, 13);
            this.quantityInStockValueLabel.TabIndex = 15;
            this.quantityInStockValueLabel.Text = "  ";
            // 
            // AddRentalItemModal
            // 
            this.ClientSize = new System.Drawing.Size(437, 478);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.quantityToRentNumericUpDown);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonFlowLayoutPanel);
            this.Controls.Add(this.quantityToRentLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRentalItemModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentMe: Rent Furniture";
            this.Load += new System.EventHandler(this.AddRentalItemModal_Load);
            this.buttonFlowLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityToRentNumericUpDown)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.FlowLayoutPanel buttonFlowLayoutPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label furnitureIDLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label styleLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label dailyRentalRateLabel;
        private System.Windows.Forms.Label quantityToRentLabel;
        private System.Windows.Forms.NumericUpDown quantityToRentNumericUpDown;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label errorMessageLabel;
        private System.Windows.Forms.Label furnitureIDValueLabel;
        private System.Windows.Forms.Label nameValueLabel;
        private System.Windows.Forms.Label descriptionValueLabel;
        private System.Windows.Forms.Label styleValueLabel;
        private System.Windows.Forms.Label categoryValueLabel;
        private System.Windows.Forms.Label dailyRentalRateValueLabel;
        private System.Windows.Forms.Label quantityInStockValueLabel;
        private System.Windows.Forms.Label quantityInStockLabel;
    }
}