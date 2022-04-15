
namespace RentMe_App.UserControls
{
    partial class SearchInventoryUserControl
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
            this.searchFurnitureDataGridView = new System.Windows.Forms.DataGridView();
            this.searchHeaderLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.styleLabel = new System.Windows.Forms.Label();
            this.styleComboBox = new System.Windows.Forms.ComboBox();
            this.furnitureIDTextBox = new System.Windows.Forms.TextBox();
            this.furnitureIDLabel = new System.Windows.Forms.Label();
            this.clearSearchButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.itemDetailsButton = new System.Windows.Forms.Button();
            this.buttonFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.searchFurnitureDataGridView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.buttonFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchFurnitureDataGridView
            // 
            this.searchFurnitureDataGridView.AllowUserToAddRows = false;
            this.searchFurnitureDataGridView.AllowUserToDeleteRows = false;
            this.searchFurnitureDataGridView.AllowUserToOrderColumns = true;
            this.searchFurnitureDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.searchFurnitureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchFurnitureDataGridView.Location = new System.Drawing.Point(16, 96);
            this.searchFurnitureDataGridView.Name = "searchFurnitureDataGridView";
            this.searchFurnitureDataGridView.ReadOnly = true;
            this.searchFurnitureDataGridView.Size = new System.Drawing.Size(797, 319);
            this.searchFurnitureDataGridView.TabIndex = 30;
            // 
            // searchHeaderLabel
            // 
            this.searchHeaderLabel.AutoSize = true;
            this.searchHeaderLabel.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel2.SetColumnSpan(this.searchHeaderLabel, 2);
            this.searchHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.searchHeaderLabel.Location = new System.Drawing.Point(3, 0);
            this.searchHeaderLabel.Name = "searchHeaderLabel";
            this.searchHeaderLabel.Size = new System.Drawing.Size(134, 13);
            this.searchHeaderLabel.TabIndex = 0;
            this.searchHeaderLabel.Text = "Search Available Inventory";
            // 
            // categoryLabel
            // 
            this.categoryLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.categoryLabel.Location = new System.Drawing.Point(53, 55);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(49, 13);
            this.categoryLabel.TabIndex = 4;
            this.categoryLabel.Text = "Category";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.categoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(108, 51);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(100, 21);
            this.categoryComboBox.TabIndex = 5;
            // 
            // styleLabel
            // 
            this.styleLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.styleLabel.AutoSize = true;
            this.styleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.styleLabel.Location = new System.Drawing.Point(306, 55);
            this.styleLabel.Name = "styleLabel";
            this.styleLabel.Size = new System.Drawing.Size(30, 13);
            this.styleLabel.TabIndex = 2;
            this.styleLabel.Text = "Style";
            // 
            // styleComboBox
            // 
            this.styleComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.styleComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.styleComboBox.FormattingEnabled = true;
            this.styleComboBox.Location = new System.Drawing.Point(342, 51);
            this.styleComboBox.Name = "styleComboBox";
            this.styleComboBox.Size = new System.Drawing.Size(100, 21);
            this.styleComboBox.TabIndex = 3;
            // 
            // furnitureIDTextBox
            // 
            this.furnitureIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.furnitureIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.furnitureIDTextBox.Location = new System.Drawing.Point(608, 51);
            this.furnitureIDTextBox.Name = "furnitureIDTextBox";
            this.furnitureIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.furnitureIDTextBox.TabIndex = 7;
            // 
            // furnitureIDLabel
            // 
            this.furnitureIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.furnitureIDLabel.AutoSize = true;
            this.furnitureIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.furnitureIDLabel.Location = new System.Drawing.Point(540, 55);
            this.furnitureIDLabel.Name = "furnitureIDLabel";
            this.furnitureIDLabel.Size = new System.Drawing.Size(62, 13);
            this.furnitureIDLabel.TabIndex = 6;
            this.furnitureIDLabel.Text = "Furniture ID";
            // 
            // clearSearchButton
            // 
            this.clearSearchButton.AutoSize = true;
            this.clearSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.clearSearchButton.Location = new System.Drawing.Point(165, 3);
            this.clearSearchButton.Name = "clearSearchButton";
            this.clearSearchButton.Size = new System.Drawing.Size(78, 23);
            this.clearSearchButton.TabIndex = 32;
            this.clearSearchButton.Text = "Clear Search";
            this.clearSearchButton.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.AutoSize = true;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.searchButton.Location = new System.Drawing.Point(3, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 31;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.35013F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.89924F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.823678F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.42569F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.32746F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.67758F));
            this.tableLayoutPanel2.Controls.Add(this.searchHeaderLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.categoryLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.categoryComboBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.styleLabel, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.styleComboBox, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.furnitureIDTextBox, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.furnitureIDLabel, 4, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(16, 14);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.7907F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.2093F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 76);
            this.tableLayoutPanel2.TabIndex = 34;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.errorMessageLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(32, 421);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 30);
            this.tableLayoutPanel1.TabIndex = 33;
            // 
            // itemDetailsButton
            // 
            this.itemDetailsButton.AutoSize = true;
            this.itemDetailsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.itemDetailsButton.Location = new System.Drawing.Point(84, 3);
            this.itemDetailsButton.Name = "itemDetailsButton";
            this.itemDetailsButton.Size = new System.Drawing.Size(75, 23);
            this.itemDetailsButton.TabIndex = 35;
            this.itemDetailsButton.Text = "Item Details";
            this.itemDetailsButton.UseVisualStyleBackColor = true;
            // 
            // buttonFlowLayoutPanel
            // 
            this.buttonFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonFlowLayoutPanel.AutoSize = true;
            this.buttonFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonFlowLayoutPanel.Controls.Add(this.searchButton);
            this.buttonFlowLayoutPanel.Controls.Add(this.itemDetailsButton);
            this.buttonFlowLayoutPanel.Controls.Add(this.clearSearchButton);
            this.buttonFlowLayoutPanel.Location = new System.Drawing.Point(287, 457);
            this.buttonFlowLayoutPanel.Name = "buttonFlowLayoutPanel";
            this.buttonFlowLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonFlowLayoutPanel.Size = new System.Drawing.Size(246, 29);
            this.buttonFlowLayoutPanel.TabIndex = 36;
            this.buttonFlowLayoutPanel.WrapContents = false;
            // 
            // SearchInventoryUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonFlowLayoutPanel);
            this.Controls.Add(this.searchFurnitureDataGridView);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SearchInventoryUserControl";
            this.Size = new System.Drawing.Size(828, 502);
            ((System.ComponentModel.ISupportInitialize)(this.searchFurnitureDataGridView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.buttonFlowLayoutPanel.ResumeLayout(false);
            this.buttonFlowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView searchFurnitureDataGridView;
        private System.Windows.Forms.Label searchHeaderLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label styleLabel;
        private System.Windows.Forms.ComboBox styleComboBox;
        private System.Windows.Forms.TextBox furnitureIDTextBox;
        private System.Windows.Forms.Label furnitureIDLabel;
        private System.Windows.Forms.Button clearSearchButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label errorMessageLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button itemDetailsButton;
        private System.Windows.Forms.FlowLayoutPanel buttonFlowLayoutPanel;
    }
}
