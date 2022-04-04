
namespace RentMe_App.UserControls
{
    partial class SearchMemberUserControl
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
            this.clearSearchButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchMemberDataGridView = new System.Windows.Forms.DataGridView();
            this.memberIDTextBox = new System.Windows.Forms.TextBox();
            this.memberIDLabel = new System.Windows.Forms.Label();
            this.searchHeaderLabel = new System.Windows.Forms.Label();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.bottomButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.editButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.searchMemberDataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.bottomButtonsTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // clearSearchButton
            // 
            this.clearSearchButton.AutoSize = true;
            this.clearSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.clearSearchButton.Location = new System.Drawing.Point(681, 121);
            this.clearSearchButton.Name = "clearSearchButton";
            this.clearSearchButton.Size = new System.Drawing.Size(75, 23);
            this.clearSearchButton.TabIndex = 38;
            this.clearSearchButton.Text = "Clear";
            this.clearSearchButton.UseVisualStyleBackColor = true;
            this.clearSearchButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.AutoSize = true;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.searchButton.Location = new System.Drawing.Point(681, 62);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 37;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchMemberDataGridView
            // 
            this.searchMemberDataGridView.AllowUserToAddRows = false;
            this.searchMemberDataGridView.AllowUserToDeleteRows = false;
            this.searchMemberDataGridView.AllowUserToOrderColumns = true;
            this.searchMemberDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.searchMemberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchMemberDataGridView.Location = new System.Drawing.Point(3, 176);
            this.searchMemberDataGridView.Name = "searchMemberDataGridView";
            this.searchMemberDataGridView.ReadOnly = true;
            this.searchMemberDataGridView.Size = new System.Drawing.Size(797, 290);
            this.searchMemberDataGridView.TabIndex = 36;
            this.searchMemberDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SearchMemberDataGridView_CellClick);
            this.searchMemberDataGridView.SelectionChanged += new System.EventHandler(this.SearchMemberDataGridView_SelectionChanged);
            this.searchMemberDataGridView.VisibleChanged += new System.EventHandler(this.SearchMemberDataGridView_VisibleChanged);
            // 
            // memberIDTextBox
            // 
            this.memberIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.memberIDTextBox.Location = new System.Drawing.Point(116, 62);
            this.memberIDTextBox.Name = "memberIDTextBox";
            this.memberIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.memberIDTextBox.TabIndex = 35;
            this.memberIDTextBox.Enter += new System.EventHandler(this.MemberID_Enter);
            // 
            // memberIDLabel
            // 
            this.memberIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.memberIDLabel.AutoSize = true;
            this.memberIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.memberIDLabel.Location = new System.Drawing.Point(51, 59);
            this.memberIDLabel.Name = "memberIDLabel";
            this.memberIDLabel.Size = new System.Drawing.Size(59, 13);
            this.memberIDLabel.TabIndex = 34;
            this.memberIDLabel.Text = "Member ID";
            // 
            // searchHeaderLabel
            // 
            this.searchHeaderLabel.AutoSize = true;
            this.searchHeaderLabel.BackColor = System.Drawing.SystemColors.Control;
            this.searchHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.searchHeaderLabel.Location = new System.Drawing.Point(3, 0);
            this.searchHeaderLabel.Name = "searchHeaderLabel";
            this.searchHeaderLabel.Size = new System.Drawing.Size(82, 13);
            this.searchHeaderLabel.TabIndex = 29;
            this.searchHeaderLabel.Text = "Search Member";
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.errorMessageLabel.AutoSize = true;
            this.errorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.errorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.errorMessageLabel.Location = new System.Drawing.Point(344, 4);
            this.errorMessageLabel.MaximumSize = new System.Drawing.Size(400, 0);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(75, 13);
            this.errorMessageLabel.TabIndex = 26;
            this.errorMessageLabel.Text = "Error Message";
            this.errorMessageLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.errorMessageLabel.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.errorMessageLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(21, 471);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(763, 22);
            this.tableLayoutPanel1.TabIndex = 39;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.firstNameTextBox.Location = new System.Drawing.Point(342, 62);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 41;
            this.firstNameTextBox.Enter += new System.EventHandler(this.Name_Enter);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.firstNameLabel.Location = new System.Drawing.Point(279, 59);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 40;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lastNameTextBox.Location = new System.Drawing.Point(342, 121);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 43;
            this.lastNameTextBox.Enter += new System.EventHandler(this.Name_Enter);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lastNameLabel.Location = new System.Drawing.Point(278, 118);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 42;
            this.lastNameLabel.Text = "Last Name";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.phoneTextBox.Location = new System.Drawing.Point(568, 62);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneTextBox.TabIndex = 45;
            this.phoneTextBox.Enter += new System.EventHandler(this.Phone_Enter);
            // 
            // phoneLabel
            // 
            this.phoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.phoneLabel.Location = new System.Drawing.Point(524, 59);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(38, 13);
            this.phoneLabel.TabIndex = 44;
            this.phoneLabel.Text = "Phone";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 533);
            this.splitter1.TabIndex = 46;
            this.splitter1.TabStop = false;
            // 
            // bottomButtonsTableLayoutPanel
            // 
            this.bottomButtonsTableLayoutPanel.ColumnCount = 1;
            this.bottomButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottomButtonsTableLayoutPanel.Controls.Add(this.editButton, 0, 0);
            this.bottomButtonsTableLayoutPanel.Location = new System.Drawing.Point(21, 496);
            this.bottomButtonsTableLayoutPanel.Name = "bottomButtonsTableLayoutPanel";
            this.bottomButtonsTableLayoutPanel.RowCount = 1;
            this.bottomButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottomButtonsTableLayoutPanel.Size = new System.Drawing.Size(763, 31);
            this.bottomButtonsTableLayoutPanel.TabIndex = 47;
            // 
            // editButton
            // 
            this.editButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.editButton.AutoSize = true;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.editButton.Location = new System.Drawing.Point(344, 3);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 48;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.Controls.Add(this.searchHeaderLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.memberIDLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.memberIDTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.clearSearchButton, 6, 2);
            this.tableLayoutPanel2.Controls.Add(this.phoneTextBox, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.searchButton, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.firstNameLabel, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.phoneLabel, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.lastNameLabel, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.lastNameTextBox, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.firstNameTextBox, 3, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(797, 178);
            this.tableLayoutPanel2.TabIndex = 48;
            // 
            // SearchMemberUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.bottomButtonsTableLayoutPanel);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.searchMemberDataGridView);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SearchMemberUserControl";
            this.Size = new System.Drawing.Size(800, 533);
            ((System.ComponentModel.ISupportInitialize)(this.searchMemberDataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.bottomButtonsTableLayoutPanel.ResumeLayout(false);
            this.bottomButtonsTableLayoutPanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clearSearchButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView searchMemberDataGridView;
        private System.Windows.Forms.TextBox memberIDTextBox;
        private System.Windows.Forms.Label memberIDLabel;
        private System.Windows.Forms.Label searchHeaderLabel;
        private System.Windows.Forms.Label errorMessageLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TableLayoutPanel bottomButtonsTableLayoutPanel;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}
