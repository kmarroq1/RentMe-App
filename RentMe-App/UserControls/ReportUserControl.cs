using Microsoft.Reporting.WinForms;
using RentMe_App.Controller;
using System;
using System.Data;
using System.Windows.Forms;

namespace RentMe_App.UserControls
{
    /// <summary>
    /// class for report user control
    /// Author: cs6232-g5
    /// Version: Spring 2022
    /// </summary>
    public partial class ReportUserControl : UserControl
    {
        #region Data Members

        private readonly ReportController reportController;

        #endregion

        #region Constructors

        /// <summary>
        /// create a Constructor
        /// </summary>
        public ReportUserControl()
        {
            InitializeComponent();
            reportController = new ReportController();
        }

        #endregion

        #region Methods

        private void RunButton_Click(object sender, EventArgs e)
        {
            DataTable reportTable = reportController.GetMostPopularFurnitureDuringDates(startDateTimePicker.Value, endDateTimePicker.Value);
            ReportDataSource datasource = new ReportDataSource("RentMeDataSet", reportTable);
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(datasource);
            reportViewer.RefreshReport();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            startDateTimePicker.Value = DateTime.Now;
            endDateTimePicker.Value = DateTime.Now;
            reportViewer.Clear();

        }

        private void ReportUserControl_VisibleChanged(object sender, EventArgs e)
        {
            ClearForm();
        }

        #endregion
    }
}
