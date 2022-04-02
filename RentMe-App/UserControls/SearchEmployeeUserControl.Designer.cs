
namespace RentMe_App.UserControls
{
    partial class SearchEmployeeUserControl
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
            this.employeeSearchTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.lNameTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.fNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.searchEmployeeLabel = new System.Windows.Forms.Label();
            this.employeeIdLabel = new System.Windows.Forms.Label();
            this.fNameLabel = new System.Windows.Forms.Label();
            this.lNameLabel = new System.Windows.Forms.Label();
            this.employeeSearchGridView = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.employeeSearchTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSearchGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeSearchTableLayoutPanel
            // 
            this.employeeSearchTableLayoutPanel.ColumnCount = 7;
            this.employeeSearchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.employeeSearchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.employeeSearchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.employeeSearchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.employeeSearchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.employeeSearchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.employeeSearchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.employeeSearchTableLayoutPanel.Controls.Add(this.phoneTextBox, 5, 1);
            this.employeeSearchTableLayoutPanel.Controls.Add(this.idTextBox, 3, 1);
            this.employeeSearchTableLayoutPanel.Controls.Add(this.ClearButton, 6, 2);
            this.employeeSearchTableLayoutPanel.Controls.Add(this.lNameTextBox, 1, 2);
            this.employeeSearchTableLayoutPanel.Controls.Add(this.SearchButton, 6, 1);
            this.employeeSearchTableLayoutPanel.Controls.Add(this.fNameTextBox, 1, 1);
            this.employeeSearchTableLayoutPanel.Controls.Add(this.phoneLabel, 4, 1);
            this.employeeSearchTableLayoutPanel.Controls.Add(this.searchEmployeeLabel, 0, 0);
            this.employeeSearchTableLayoutPanel.Controls.Add(this.employeeIdLabel, 2, 1);
            this.employeeSearchTableLayoutPanel.Controls.Add(this.fNameLabel, 0, 1);
            this.employeeSearchTableLayoutPanel.Controls.Add(this.lNameLabel, 0, 2);
            this.employeeSearchTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.employeeSearchTableLayoutPanel.Name = "employeeSearchTableLayoutPanel";
            this.employeeSearchTableLayoutPanel.RowCount = 3;
            this.employeeSearchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.employeeSearchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.employeeSearchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.employeeSearchTableLayoutPanel.Size = new System.Drawing.Size(800, 182);
            this.employeeSearchTableLayoutPanel.TabIndex = 0;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(573, 63);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneTextBox.TabIndex = 7;
            this.phoneTextBox.TextChanged += new System.EventHandler(this.ClearError);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(345, 63);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 6;
            this.idTextBox.TextChanged += new System.EventHandler(this.ClearError);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(687, 123);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // lNameTextBox
            // 
            this.lNameTextBox.Location = new System.Drawing.Point(117, 123);
            this.lNameTextBox.Name = "lNameTextBox";
            this.lNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lNameTextBox.TabIndex = 5;
            this.lNameTextBox.TextChanged += new System.EventHandler(this.ClearError);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(687, 63);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // fNameTextBox
            // 
            this.fNameTextBox.Location = new System.Drawing.Point(117, 63);
            this.fNameTextBox.Name = "fNameTextBox";
            this.fNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.fNameTextBox.TabIndex = 4;
            this.fNameTextBox.TextChanged += new System.EventHandler(this.ClearError);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(459, 60);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(38, 13);
            this.phoneLabel.TabIndex = 4;
            this.phoneLabel.Text = "Phone";
            // 
            // searchEmployeeLabel
            // 
            this.searchEmployeeLabel.AutoSize = true;
            this.searchEmployeeLabel.Location = new System.Drawing.Point(3, 0);
            this.searchEmployeeLabel.Name = "searchEmployeeLabel";
            this.searchEmployeeLabel.Size = new System.Drawing.Size(90, 13);
            this.searchEmployeeLabel.TabIndex = 0;
            this.searchEmployeeLabel.Text = "Search Employee";
            // 
            // employeeIdLabel
            // 
            this.employeeIdLabel.AutoSize = true;
            this.employeeIdLabel.Location = new System.Drawing.Point(231, 60);
            this.employeeIdLabel.Name = "employeeIdLabel";
            this.employeeIdLabel.Size = new System.Drawing.Size(67, 13);
            this.employeeIdLabel.TabIndex = 3;
            this.employeeIdLabel.Text = "Employee ID";
            // 
            // fNameLabel
            // 
            this.fNameLabel.AutoSize = true;
            this.fNameLabel.Location = new System.Drawing.Point(3, 60);
            this.fNameLabel.Name = "fNameLabel";
            this.fNameLabel.Size = new System.Drawing.Size(57, 13);
            this.fNameLabel.TabIndex = 1;
            this.fNameLabel.Text = "First Name";
            // 
            // lNameLabel
            // 
            this.lNameLabel.AutoSize = true;
            this.lNameLabel.Location = new System.Drawing.Point(3, 120);
            this.lNameLabel.Name = "lNameLabel";
            this.lNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lNameLabel.TabIndex = 2;
            this.lNameLabel.Text = "Last Name";
            // 
            // employeeSearchGridView
            // 
            this.employeeSearchGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeSearchGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.nameColumn,
            this.addressColumn,
            this.cityColumn,
            this.stateColumn,
            this.phoneColumn,
            this.dobColumn,
            this.activeColumn});
            this.employeeSearchGridView.Location = new System.Drawing.Point(0, 179);
            this.employeeSearchGridView.Name = "employeeSearchGridView";
            this.employeeSearchGridView.Size = new System.Drawing.Size(800, 286);
            this.employeeSearchGridView.TabIndex = 1;
            this.employeeSearchGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
            // 
            // IDColumn
            // 
            this.IDColumn.HeaderText = "ID";
            this.IDColumn.Name = "IDColumn";
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "name";
            this.nameColumn.Name = "nameColumn";
            // 
            // addressColumn
            // 
            this.addressColumn.HeaderText = "address";
            this.addressColumn.Name = "addressColumn";
            // 
            // cityColumn
            // 
            this.cityColumn.HeaderText = "city";
            this.cityColumn.Name = "cityColumn";
            // 
            // stateColumn
            // 
            this.stateColumn.HeaderText = "state";
            this.stateColumn.Name = "stateColumn";
            // 
            // phoneColumn
            // 
            this.phoneColumn.HeaderText = "phone";
            this.phoneColumn.Name = "phoneColumn";
            // 
            // dobColumn
            // 
            this.dobColumn.HeaderText = "DOB";
            this.dobColumn.Name = "dobColumn";
            // 
            // activeColumn
            // 
            this.activeColumn.HeaderText = "active";
            this.activeColumn.Name = "activeColumn";
            this.activeColumn.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 214F));
            this.tableLayoutPanel1.Controls.Add(this.AddButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.EditButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.errorLabel, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(298, 471);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(446, 26);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(119, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 20);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add New";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(3, 3);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 20);
            this.EditButton.TabIndex = 4;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(235, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 5;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(153, 473);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 13);
            this.infoLabel.TabIndex = 3;
            // 
            // SearchEmployeeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.employeeSearchGridView);
            this.Controls.Add(this.employeeSearchTableLayoutPanel);
            this.Name = "SearchEmployeeUserControl";
            this.Size = new System.Drawing.Size(800, 500);
            this.employeeSearchTableLayoutPanel.ResumeLayout(false);
            this.employeeSearchTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSearchGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel employeeSearchTableLayoutPanel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label searchEmployeeLabel;
        private System.Windows.Forms.Label employeeIdLabel;
        private System.Windows.Forms.Label fNameLabel;
        private System.Windows.Forms.Label lNameLabel;
        private System.Windows.Forms.DataGridView employeeSearchGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox lNameTextBox;
        private System.Windows.Forms.TextBox fNameTextBox;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeColumn;
        private System.Windows.Forms.Label infoLabel;
    }
}
