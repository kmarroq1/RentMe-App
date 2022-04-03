
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
            ((System.ComponentModel.ISupportInitialize)(this.searchMemberDataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.bottomButtonsTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // clearSearchButton
            // 
            this.clearSearchButton.AutoSize = true;
            this.clearSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearSearchButton.Location = new System.Drawing.Point(392, 125);
            this.clearSearchButton.Name = "clearSearchButton";
            this.clearSearchButton.Size = new System.Drawing.Size(129, 34);
            this.clearSearchButton.TabIndex = 38;
            this.clearSearchButton.Text = "Clear Search";
            this.clearSearchButton.UseVisualStyleBackColor = true;
            this.clearSearchButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.AutoSize = true;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(285, 124);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(80, 34);
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
            this.searchMemberDataGridView.Location = new System.Drawing.Point(21, 171);
            this.searchMemberDataGridView.Name = "searchMemberDataGridView";
            this.searchMemberDataGridView.ReadOnly = true;
            this.searchMemberDataGridView.Size = new System.Drawing.Size(763, 258);
            this.searchMemberDataGridView.TabIndex = 36;
            this.searchMemberDataGridView.VisibleChanged += new System.EventHandler(this.SearchMemberDataGridView_VisibleChanged);
            // 
            // memberIDTextBox
            // 
            this.memberIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberIDTextBox.Location = new System.Drawing.Point(117, 48);
            this.memberIDTextBox.Name = "memberIDTextBox";
            this.memberIDTextBox.Size = new System.Drawing.Size(136, 26);
            this.memberIDTextBox.TabIndex = 35;
            this.memberIDTextBox.Enter += new System.EventHandler(this.MemberID_Enter);
            // 
            // memberIDLabel
            // 
            this.memberIDLabel.AutoSize = true;
            this.memberIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberIDLabel.Location = new System.Drawing.Point(23, 51);
            this.memberIDLabel.Name = "memberIDLabel";
            this.memberIDLabel.Size = new System.Drawing.Size(88, 20);
            this.memberIDLabel.TabIndex = 34;
            this.memberIDLabel.Text = "Member ID";
            // 
            // searchHeaderLabel
            // 
            this.searchHeaderLabel.AutoSize = true;
            this.searchHeaderLabel.BackColor = System.Drawing.SystemColors.Control;
            this.searchHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchHeaderLabel.Location = new System.Drawing.Point(17, 8);
            this.searchHeaderLabel.Name = "searchHeaderLabel";
            this.searchHeaderLabel.Size = new System.Drawing.Size(146, 24);
            this.searchHeaderLabel.TabIndex = 29;
            this.searchHeaderLabel.Text = "Search Member";
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.errorMessageLabel.AutoSize = true;
            this.errorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageLabel.Location = new System.Drawing.Point(371, 9);
            this.errorMessageLabel.MaximumSize = new System.Drawing.Size(400, 0);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(21, 20);
            this.errorMessageLabel.TabIndex = 26;
            this.errorMessageLabel.Text = "   ";
            this.errorMessageLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.errorMessageLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(21, 436);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(763, 39);
            this.tableLayoutPanel1.TabIndex = 39;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(377, 48);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(172, 26);
            this.firstNameTextBox.TabIndex = 41;
            this.firstNameTextBox.Enter += new System.EventHandler(this.Fname_Enter);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(285, 51);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(86, 20);
            this.firstNameLabel.TabIndex = 40;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(377, 80);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(172, 26);
            this.lastNameTextBox.TabIndex = 43;
            this.lastNameTextBox.Enter += new System.EventHandler(this.Lname_Enter);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(285, 83);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(86, 20);
            this.lastNameLabel.TabIndex = 42;
            this.lastNameLabel.Text = "Last Name";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(648, 48);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(136, 26);
            this.phoneTextBox.TabIndex = 45;
            this.phoneTextBox.Enter += new System.EventHandler(this.Phone_Enter);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(587, 51);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(55, 20);
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
            this.bottomButtonsTableLayoutPanel.Location = new System.Drawing.Point(21, 481);
            this.bottomButtonsTableLayoutPanel.Name = "bottomButtonsTableLayoutPanel";
            this.bottomButtonsTableLayoutPanel.RowCount = 1;
            this.bottomButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottomButtonsTableLayoutPanel.Size = new System.Drawing.Size(763, 46);
            this.bottomButtonsTableLayoutPanel.TabIndex = 47;
            // 
            // editButton
            // 
            this.editButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.editButton.AutoSize = true;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Location = new System.Drawing.Point(341, 3);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(80, 34);
            this.editButton.TabIndex = 48;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // SearchMemberUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bottomButtonsTableLayoutPanel);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.clearSearchButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchMemberDataGridView);
            this.Controls.Add(this.memberIDTextBox);
            this.Controls.Add(this.memberIDLabel);
            this.Controls.Add(this.searchHeaderLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SearchMemberUserControl";
            this.Size = new System.Drawing.Size(800, 533);
            ((System.ComponentModel.ISupportInitialize)(this.searchMemberDataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.bottomButtonsTableLayoutPanel.ResumeLayout(false);
            this.bottomButtonsTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}
