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
            DataSet dsReport = (DataSet)reportController.GetMostPopularFurnitureDuringDates(startDateTimePicker.Value, endDateTimePicker.Value);
            ReportDataSource datasource = new ReportDataSource("RentMeDataSet", dsReport.Tables[0]);
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(datasource);
            reportViewer.RefreshReport();
        }

        #endregion
    }
}
