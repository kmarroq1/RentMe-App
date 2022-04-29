
namespace RentMe_App.UserControls
{
    partial class ReportUserControl
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mostPopularFurnitureLabel = new System.Windows.Forms.Label();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.runButton = new System.Windows.Forms.Button();
            this.rentMeDataSet = new RentMe_App.RentMeDataSet();
            this.spGetMostPopularFurnitureDuringDatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spGetMostPopularFurnitureDuringDatesTableAdapter = new RentMe_App.RentMeDataSetTableAdapters.spGetMostPopularFurnitureDuringDatesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rentMeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetMostPopularFurnitureDuringDatesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer
            // 
            reportDataSource1.Name = "RentMeDataSet";
            reportDataSource1.Value = this.spGetMostPopularFurnitureDuringDatesBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "RentMe_App.Report.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(19, 91);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(788, 390);
            this.reportViewer.TabIndex = 0;
            // 
            // mostPopularFurnitureLabel
            // 
            this.mostPopularFurnitureLabel.AutoSize = true;
            this.mostPopularFurnitureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostPopularFurnitureLabel.Location = new System.Drawing.Point(16, 19);
            this.mostPopularFurnitureLabel.Name = "mostPopularFurnitureLabel";
            this.mostPopularFurnitureLabel.Size = new System.Drawing.Size(174, 17);
            this.mostPopularFurnitureLabel.TabIndex = 1;
            this.mostPopularFurnitureLabel.Text = "Most Popular Furniture";
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(77, 49);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.startDateTimePicker.TabIndex = 1;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateLabel.Location = new System.Drawing.Point(16, 53);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(55, 13);
            this.startDateLabel.TabIndex = 3;
            this.startDateLabel.Text = "Start Date";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateLabel.Location = new System.Drawing.Point(302, 53);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(52, 13);
            this.endDateLabel.TabIndex = 5;
            this.endDateLabel.Text = "End Date";
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(363, 49);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.endDateTimePicker.TabIndex = 2;
            // 
            // runButton
            // 
            this.runButton.AutoSize = true;
            this.runButton.Location = new System.Drawing.Point(583, 48);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 23);
            this.runButton.TabIndex = 3;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // rentMeDataSet
            // 
            this.rentMeDataSet.DataSetName = "RentMeDataSet";
            this.rentMeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spGetMostPopularFurnitureDuringDatesBindingSource
            // 
            this.spGetMostPopularFurnitureDuringDatesBindingSource.DataMember = "spGetMostPopularFurnitureDuringDates";
            this.spGetMostPopularFurnitureDuringDatesBindingSource.DataSource = this.rentMeDataSet;
            // 
            // spGetMostPopularFurnitureDuringDatesTableAdapter
            // 
            this.spGetMostPopularFurnitureDuringDatesTableAdapter.ClearBeforeFill = true;
            // 
            // ReportUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.mostPopularFurnitureLabel);
            this.Controls.Add(this.reportViewer);
            this.Name = "ReportUserControl";
            this.Size = new System.Drawing.Size(828, 502);
            ((System.ComponentModel.ISupportInitialize)(this.rentMeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetMostPopularFurnitureDuringDatesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.Label mostPopularFurnitureLabel;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.BindingSource spGetMostPopularFurnitureDuringDatesBindingSource;
        private RentMeDataSet rentMeDataSet;
        private RentMeDataSetTableAdapters.spGetMostPopularFurnitureDuringDatesTableAdapter spGetMostPopularFurnitureDuringDatesTableAdapter;
    }
}
