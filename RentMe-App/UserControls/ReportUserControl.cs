using Microsoft.Reporting.WinForms;
using RentMe_App.Controller;
using System;
using System.Data;
using System.Drawing;
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
            try
            {
                if (startDateTimePicker.Value >= endDateTimePicker.Value)
                {
                    reportViewer.Clear();
                    string errorMessage = "End Date must be later than Start Date";
                    ShowInvalidErrorMessage(errorMessage);
                }
                else
                {
                    HideErrorMessage();
                    DataTable reportTable = reportController.GetMostPopularFurnitureDuringDates(startDateTimePicker.Value, endDateTimePicker.Value);
                    ReportDataSource datasource = new ReportDataSource("RentMeDataSet", reportTable);
                    reportViewer.LocalReport.DataSources.Clear();
                    reportViewer.LocalReport.DataSources.Add(datasource);
                    reportViewer.RefreshReport();

                    if (reportTable.Rows.Count == 0)
                    {
                        string errorMessage = "No rentals found";
                        ShowInvalidErrorMessage(errorMessage);
                    }
                }
            }
            catch (Exception)
            {
                string errorMessage = "Invalid Report";
                ShowInvalidErrorMessage(errorMessage);
            }
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
            HideErrorMessage();

        }

        private void ReportUserControl_VisibleChanged(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void HideErrorMessage()
        {
            errorMessageLabel.Text = "";
        }

        private void ShowInvalidErrorMessage(string message)
        {
            errorMessageLabel.Text = message;
            errorMessageLabel.ForeColor = Color.Red;
        }

        #endregion
    }
}
