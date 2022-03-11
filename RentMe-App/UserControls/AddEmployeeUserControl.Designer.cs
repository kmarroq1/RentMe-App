
namespace RentMe_App.UserControls
{
    partial class AddEmployeeUserControl
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
            this.PrimaryFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.FormTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameFormGroup = new System.Windows.Forms.TableLayoutPanel();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameFormGroup = new System.Windows.Forms.TableLayoutPanel();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.BirthdayFormGroup = new System.Windows.Forms.TableLayoutPanel();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.BirthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PhoneFormGroup = new System.Windows.Forms.TableLayoutPanel();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.ZipFormGroup = new System.Windows.Forms.TableLayoutPanel();
            this.ZipLabel = new System.Windows.Forms.Label();
            this.ZipTextBox = new System.Windows.Forms.TextBox();
            this.StateFormGroup = new System.Windows.Forms.TableLayoutPanel();
            this.StateLabel = new System.Windows.Forms.Label();
            this.StateComboBox = new System.Windows.Forms.ComboBox();
            this.CityFormGroup = new System.Windows.Forms.TableLayoutPanel();
            this.CityLabel = new System.Windows.Forms.Label();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.Address2FormGroup = new System.Windows.Forms.TableLayoutPanel();
            this.Address2Label = new System.Windows.Forms.Label();
            this.Address2TextBox = new System.Windows.Forms.TextBox();
            this.Address1FormGroup = new System.Windows.Forms.TableLayoutPanel();
            this.Address1Label = new System.Windows.Forms.Label();
            this.Address1TextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.ErrorMessage = new System.Windows.Forms.Label();
            this.ControlsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.PrimaryFlowLayoutPanel.SuspendLayout();
            this.FormTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.FirstNameFormGroup.SuspendLayout();
            this.LastNameFormGroup.SuspendLayout();
            this.BirthdayFormGroup.SuspendLayout();
            this.PhoneFormGroup.SuspendLayout();
            this.ZipFormGroup.SuspendLayout();
            this.StateFormGroup.SuspendLayout();
            this.CityFormGroup.SuspendLayout();
            this.Address2FormGroup.SuspendLayout();
            this.Address1FormGroup.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.ControlsFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrimaryFlowLayoutPanel
            // 
            this.PrimaryFlowLayoutPanel.AutoSize = true;
            this.PrimaryFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PrimaryFlowLayoutPanel.Controls.Add(this.HeaderLabel);
            this.PrimaryFlowLayoutPanel.Controls.Add(this.FormTableLayoutPanel);
            this.PrimaryFlowLayoutPanel.Controls.Add(this.ErrorMessage);
            this.PrimaryFlowLayoutPanel.Controls.Add(this.ControlsFlowLayoutPanel);
            this.PrimaryFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrimaryFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PrimaryFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.PrimaryFlowLayoutPanel.Name = "PrimaryFlowLayoutPanel";
            this.PrimaryFlowLayoutPanel.Size = new System.Drawing.Size(335, 400);
            this.PrimaryFlowLayoutPanel.TabIndex = 0;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.Location = new System.Drawing.Point(3, 0);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(124, 20);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Add Employee";
            // 
            // FormTableLayoutPanel
            // 
            this.FormTableLayoutPanel.AutoSize = true;
            this.FormTableLayoutPanel.ColumnCount = 2;
            this.FormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FormTableLayoutPanel.Controls.Add(this.tableLayoutPanel2, 0, 9);
            this.FormTableLayoutPanel.Controls.Add(this.FirstNameFormGroup, 0, 0);
            this.FormTableLayoutPanel.Controls.Add(this.LastNameFormGroup, 0, 1);
            this.FormTableLayoutPanel.Controls.Add(this.BirthdayFormGroup, 0, 7);
            this.FormTableLayoutPanel.Controls.Add(this.PhoneFormGroup, 0, 6);
            this.FormTableLayoutPanel.Controls.Add(this.ZipFormGroup, 0, 5);
            this.FormTableLayoutPanel.Controls.Add(this.StateFormGroup, 1, 4);
            this.FormTableLayoutPanel.Controls.Add(this.CityFormGroup, 0, 4);
            this.FormTableLayoutPanel.Controls.Add(this.Address2FormGroup, 0, 3);
            this.FormTableLayoutPanel.Controls.Add(this.Address1FormGroup, 0, 2);
            this.FormTableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 8);
            this.FormTableLayoutPanel.Location = new System.Drawing.Point(3, 23);
            this.FormTableLayoutPanel.Name = "FormTableLayoutPanel";
            this.FormTableLayoutPanel.RowCount = 10;
            this.FormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FormTableLayoutPanel.Size = new System.Drawing.Size(324, 321);
            this.FormTableLayoutPanel.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.ConfirmPasswordLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ConfirmPasswordTextBox, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 292);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(196, 26);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // ConfirmPasswordLabel
            // 
            this.ConfirmPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ConfirmPasswordLabel.AutoSize = true;
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(4, 6);
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.ConfirmPasswordLabel.Size = new System.Drawing.Size(91, 13);
            this.ConfirmPasswordLabel.TabIndex = 0;
            this.ConfirmPasswordLabel.Text = "Confirm Password";
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(101, 3);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.PasswordChar = '*';
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(92, 20);
            this.ConfirmPasswordTextBox.TabIndex = 1;
            // 
            // FirstNameFormGroup
            // 
            this.FirstNameFormGroup.AutoSize = true;
            this.FirstNameFormGroup.ColumnCount = 2;
            this.FirstNameFormGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FirstNameFormGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FirstNameFormGroup.Controls.Add(this.FirstNameLabel, 0, 0);
            this.FirstNameFormGroup.Controls.Add(this.FirstNameTextBox, 1, 0);
            this.FirstNameFormGroup.Location = new System.Drawing.Point(3, 3);
            this.FirstNameFormGroup.Name = "FirstNameFormGroup";
            this.FirstNameFormGroup.RowCount = 1;
            this.FirstNameFormGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FirstNameFormGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.FirstNameFormGroup.Size = new System.Drawing.Size(196, 26);
            this.FirstNameFormGroup.TabIndex = 1;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(38, 6);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(101, 3);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(92, 20);
            this.FirstNameTextBox.TabIndex = 1;
            // 
            // LastNameFormGroup
            // 
            this.LastNameFormGroup.AutoSize = true;
            this.LastNameFormGroup.ColumnCount = 2;
            this.LastNameFormGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LastNameFormGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LastNameFormGroup.Controls.Add(this.LastNameLabel, 0, 0);
            this.LastNameFormGroup.Controls.Add(this.LastNameTextBox, 1, 0);
            this.LastNameFormGroup.Location = new System.Drawing.Point(3, 35);
            this.LastNameFormGroup.Name = "LastNameFormGroup";
            this.LastNameFormGroup.RowCount = 1;
            this.LastNameFormGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LastNameFormGroup.Size = new System.Drawing.Size(196, 26);
            this.LastNameFormGroup.TabIndex = 2;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(37, 6);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.LastNameLabel.TabIndex = 0;
            this.LastNameLabel.Text = "Last Name";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(101, 3);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(92, 20);
            this.LastNameTextBox.TabIndex = 1;
            // 
            // BirthdayFormGroup
            // 
            this.BirthdayFormGroup.ColumnCount = 2;
            this.BirthdayFormGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BirthdayFormGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BirthdayFormGroup.Controls.Add(this.BirthdayLabel, 0, 0);
            this.BirthdayFormGroup.Controls.Add(this.BirthdayDateTimePicker, 1, 0);
            this.BirthdayFormGroup.Location = new System.Drawing.Point(3, 228);
            this.BirthdayFormGroup.Name = "BirthdayFormGroup";
            this.BirthdayFormGroup.RowCount = 1;
            this.BirthdayFormGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BirthdayFormGroup.Size = new System.Drawing.Size(196, 26);
            this.BirthdayFormGroup.TabIndex = 9;
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BirthdayLabel.AutoSize = true;
            this.BirthdayLabel.Location = new System.Drawing.Point(50, 6);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(45, 13);
            this.BirthdayLabel.TabIndex = 0;
            this.BirthdayLabel.Text = "Birthday";
            // 
            // BirthdayDateTimePicker
            // 
            this.BirthdayDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthdayDateTimePicker.Location = new System.Drawing.Point(101, 3);
            this.BirthdayDateTimePicker.MaxDate = new System.DateTime(2004, 3, 7, 0, 0, 0, 0);
            this.BirthdayDateTimePicker.Name = "BirthdayDateTimePicker";
            this.BirthdayDateTimePicker.Size = new System.Drawing.Size(92, 20);
            this.BirthdayDateTimePicker.TabIndex = 1;
            this.BirthdayDateTimePicker.Value = new System.DateTime(2004, 3, 7, 0, 0, 0, 0);
            // 
            // PhoneFormGroup
            // 
            this.PhoneFormGroup.AutoSize = true;
            this.PhoneFormGroup.ColumnCount = 2;
            this.PhoneFormGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PhoneFormGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PhoneFormGroup.Controls.Add(this.PhoneLabel, 0, 0);
            this.PhoneFormGroup.Controls.Add(this.PhoneTextBox, 1, 0);
            this.PhoneFormGroup.Location = new System.Drawing.Point(3, 196);
            this.PhoneFormGroup.Name = "PhoneFormGroup";
            this.PhoneFormGroup.RowCount = 1;
            this.PhoneFormGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PhoneFormGroup.Size = new System.Drawing.Size(196, 26);
            this.PhoneFormGroup.TabIndex = 8;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(57, 6);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(38, 13);
            this.PhoneLabel.TabIndex = 0;
            this.PhoneLabel.Text = "Phone";
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(101, 3);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(92, 20);
            this.PhoneTextBox.TabIndex = 1;
            // 
            // ZipFormGroup
            // 
            this.ZipFormGroup.AutoSize = true;
            this.ZipFormGroup.ColumnCount = 2;
            this.ZipFormGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ZipFormGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ZipFormGroup.Controls.Add(this.ZipLabel, 0, 0);
            this.ZipFormGroup.Controls.Add(this.ZipTextBox, 1, 0);
            this.ZipFormGroup.Location = new System.Drawing.Point(3, 164);
            this.ZipFormGroup.Name = "ZipFormGroup";
            this.ZipFormGroup.RowCount = 1;
            this.ZipFormGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ZipFormGroup.Size = new System.Drawing.Size(196, 26);
            this.ZipFormGroup.TabIndex = 7;
            // 
            // ZipLabel
            // 
            this.ZipLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ZipLabel.AutoSize = true;
            this.ZipLabel.Location = new System.Drawing.Point(73, 6);
            this.ZipLabel.Name = "ZipLabel";
            this.ZipLabel.Size = new System.Drawing.Size(22, 13);
            this.ZipLabel.TabIndex = 0;
            this.ZipLabel.Text = "Zip";
            // 
            // ZipTextBox
            // 
            this.ZipTextBox.Location = new System.Drawing.Point(101, 3);
            this.ZipTextBox.Name = "ZipTextBox";
            this.ZipTextBox.Size = new System.Drawing.Size(92, 20);
            this.ZipTextBox.TabIndex = 1;
            // 
            // StateFormGroup
            // 
            this.StateFormGroup.AutoSize = true;
            this.StateFormGroup.ColumnCount = 2;
            this.StateFormGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.StateFormGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.StateFormGroup.Controls.Add(this.StateLabel, 0, 0);
            this.StateFormGroup.Controls.Add(this.StateComboBox, 1, 0);
            this.StateFormGroup.Location = new System.Drawing.Point(205, 131);
            this.StateFormGroup.Name = "StateFormGroup";
            this.StateFormGroup.RowCount = 1;
            this.StateFormGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.StateFormGroup.Size = new System.Drawing.Size(116, 27);
            this.StateFormGroup.TabIndex = 6;
            // 
            // StateLabel
            // 
            this.StateLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.StateLabel.AutoSize = true;
            this.StateLabel.Location = new System.Drawing.Point(23, 7);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(32, 13);
            this.StateLabel.TabIndex = 0;
            this.StateLabel.Text = "State";
            // 
            // StateComboBox
            // 
            this.StateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StateComboBox.FormattingEnabled = true;
            this.StateComboBox.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "DC",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WE",
            "WV",
            "WI",
            "WY"});
            this.StateComboBox.Location = new System.Drawing.Point(61, 3);
            this.StateComboBox.Name = "StateComboBox";
            this.StateComboBox.Size = new System.Drawing.Size(52, 21);
            this.StateComboBox.TabIndex = 1;
            // 
            // CityFormGroup
            // 
            this.CityFormGroup.AutoSize = true;
            this.CityFormGroup.ColumnCount = 2;
            this.CityFormGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CityFormGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CityFormGroup.Controls.Add(this.CityLabel, 0, 0);
            this.CityFormGroup.Controls.Add(this.CityTextBox, 1, 0);
            this.CityFormGroup.Location = new System.Drawing.Point(3, 131);
            this.CityFormGroup.Name = "CityFormGroup";
            this.CityFormGroup.RowCount = 1;
            this.CityFormGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CityFormGroup.Size = new System.Drawing.Size(196, 26);
            this.CityFormGroup.TabIndex = 5;
            // 
            // CityLabel
            // 
            this.CityLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(71, 6);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(24, 13);
            this.CityLabel.TabIndex = 0;
            this.CityLabel.Text = "City";
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(101, 3);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(92, 20);
            this.CityTextBox.TabIndex = 1;
            // 
            // Address2FormGroup
            // 
            this.Address2FormGroup.AutoSize = true;
            this.Address2FormGroup.ColumnCount = 2;
            this.Address2FormGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Address2FormGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Address2FormGroup.Controls.Add(this.Address2Label, 0, 0);
            this.Address2FormGroup.Controls.Add(this.Address2TextBox, 1, 0);
            this.Address2FormGroup.Location = new System.Drawing.Point(3, 99);
            this.Address2FormGroup.Name = "Address2FormGroup";
            this.Address2FormGroup.RowCount = 1;
            this.Address2FormGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Address2FormGroup.Size = new System.Drawing.Size(196, 26);
            this.Address2FormGroup.TabIndex = 4;
            // 
            // Address2Label
            // 
            this.Address2Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Address2Label.AutoSize = true;
            this.Address2Label.Location = new System.Drawing.Point(41, 6);
            this.Address2Label.Name = "Address2Label";
            this.Address2Label.Size = new System.Drawing.Size(54, 13);
            this.Address2Label.TabIndex = 0;
            this.Address2Label.Text = "Address 2";
            // 
            // Address2TextBox
            // 
            this.Address2TextBox.Location = new System.Drawing.Point(101, 3);
            this.Address2TextBox.Name = "Address2TextBox";
            this.Address2TextBox.Size = new System.Drawing.Size(92, 20);
            this.Address2TextBox.TabIndex = 1;
            // 
            // Address1FormGroup
            // 
            this.Address1FormGroup.AutoSize = true;
            this.Address1FormGroup.ColumnCount = 2;
            this.Address1FormGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Address1FormGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Address1FormGroup.Controls.Add(this.Address1Label, 0, 0);
            this.Address1FormGroup.Controls.Add(this.Address1TextBox, 1, 0);
            this.Address1FormGroup.Location = new System.Drawing.Point(3, 67);
            this.Address1FormGroup.Name = "Address1FormGroup";
            this.Address1FormGroup.RowCount = 1;
            this.Address1FormGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Address1FormGroup.Size = new System.Drawing.Size(196, 26);
            this.Address1FormGroup.TabIndex = 3;
            // 
            // Address1Label
            // 
            this.Address1Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Address1Label.AutoSize = true;
            this.Address1Label.Location = new System.Drawing.Point(41, 6);
            this.Address1Label.Name = "Address1Label";
            this.Address1Label.Size = new System.Drawing.Size(54, 13);
            this.Address1Label.TabIndex = 0;
            this.Address1Label.Text = "Address 1";
            // 
            // Address1TextBox
            // 
            this.Address1TextBox.Location = new System.Drawing.Point(101, 3);
            this.Address1TextBox.Name = "Address1TextBox";
            this.Address1TextBox.Size = new System.Drawing.Size(92, 20);
            this.Address1TextBox.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.PasswordLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PasswordTextBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 260);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(196, 26);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(42, 6);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 0;
            this.PasswordLabel.Text = "Password";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(101, 3);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(92, 20);
            this.PasswordTextBox.TabIndex = 1;
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ErrorMessage.AutoSize = true;
            this.ErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessage.Location = new System.Drawing.Point(127, 347);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(75, 13);
            this.ErrorMessage.TabIndex = 12;
            this.ErrorMessage.Text = "Error Message";
            this.ErrorMessage.Visible = false;
            // 
            // ControlsFlowLayoutPanel
            // 
            this.ControlsFlowLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ControlsFlowLayoutPanel.AutoSize = true;
            this.ControlsFlowLayoutPanel.Controls.Add(this.AddButton);
            this.ControlsFlowLayoutPanel.Controls.Add(this.ClearButton);
            this.ControlsFlowLayoutPanel.Controls.Add(this.CloseButton);
            this.ControlsFlowLayoutPanel.Location = new System.Drawing.Point(43, 363);
            this.ControlsFlowLayoutPanel.Name = "ControlsFlowLayoutPanel";
            this.ControlsFlowLayoutPanel.Size = new System.Drawing.Size(243, 29);
            this.ControlsFlowLayoutPanel.TabIndex = 13;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(3, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(84, 3);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(165, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // AddEmployeeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PrimaryFlowLayoutPanel);
            this.Name = "AddEmployeeUserControl";
            this.Size = new System.Drawing.Size(335, 400);
            this.PrimaryFlowLayoutPanel.ResumeLayout(false);
            this.PrimaryFlowLayoutPanel.PerformLayout();
            this.FormTableLayoutPanel.ResumeLayout(false);
            this.FormTableLayoutPanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.FirstNameFormGroup.ResumeLayout(false);
            this.FirstNameFormGroup.PerformLayout();
            this.LastNameFormGroup.ResumeLayout(false);
            this.LastNameFormGroup.PerformLayout();
            this.BirthdayFormGroup.ResumeLayout(false);
            this.BirthdayFormGroup.PerformLayout();
            this.PhoneFormGroup.ResumeLayout(false);
            this.PhoneFormGroup.PerformLayout();
            this.ZipFormGroup.ResumeLayout(false);
            this.ZipFormGroup.PerformLayout();
            this.StateFormGroup.ResumeLayout(false);
            this.StateFormGroup.PerformLayout();
            this.CityFormGroup.ResumeLayout(false);
            this.CityFormGroup.PerformLayout();
            this.Address2FormGroup.ResumeLayout(false);
            this.Address2FormGroup.PerformLayout();
            this.Address1FormGroup.ResumeLayout(false);
            this.Address1FormGroup.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ControlsFlowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PrimaryFlowLayoutPanel;
        protected System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.TableLayoutPanel FirstNameFormGroup;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TableLayoutPanel LastNameFormGroup;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TableLayoutPanel Address1FormGroup;
        private System.Windows.Forms.Label Address1Label;
        private System.Windows.Forms.TextBox Address1TextBox;
        private System.Windows.Forms.TableLayoutPanel Address2FormGroup;
        private System.Windows.Forms.Label Address2Label;
        private System.Windows.Forms.TextBox Address2TextBox;
        private System.Windows.Forms.TableLayoutPanel CityFormGroup;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.TableLayoutPanel StateFormGroup;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.ComboBox StateComboBox;
        private System.Windows.Forms.TableLayoutPanel ZipFormGroup;
        private System.Windows.Forms.Label ZipLabel;
        private System.Windows.Forms.TextBox ZipTextBox;
        private System.Windows.Forms.TableLayoutPanel PhoneFormGroup;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TableLayoutPanel BirthdayFormGroup;
        private System.Windows.Forms.Label BirthdayLabel;
        private System.Windows.Forms.DateTimePicker BirthdayDateTimePicker;
        protected System.Windows.Forms.TableLayoutPanel FormTableLayoutPanel;
        private System.Windows.Forms.Label ErrorMessage;
        protected System.Windows.Forms.FlowLayoutPanel ControlsFlowLayoutPanel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label ConfirmPasswordLabel;
        private System.Windows.Forms.TextBox ConfirmPasswordTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button CloseButton;
    }
}
