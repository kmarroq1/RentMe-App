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
            DataTable reportTable = SortDataTable(reportController.GetMostPopularFurnitureDuringDates(startDateTimePicker.Value, endDateTimePicker.Value));
            ReportDataSource datasource = new ReportDataSource("RentMeDataSet", reportTable);
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(datasource);
            reportViewer.RefreshReport();
        }

        private DataTable SortDataTable(DataTable table)
        {
            DataView dv = table.DefaultView;
            Console.WriteLine(dv.ToString());
            dv.Sort = "times_rented_out desc, furniture_id desc";
            DataTable sortedtable = dv.ToTable();
            PrintDataTable(sortedtable);
            return sortedtable;
        }

        public static void PrintDataTable(DataTable tbl)
        {
            string line = "";
            foreach (DataColumn item in tbl.Columns)
            {
                line += item.ColumnName + "   ";
            }
            line += "\n";
            foreach (DataRow row in tbl.Rows)
            {
                for (int i = 0; i < tbl.Columns.Count; i++)
                {
                    line += row[i].ToString() + "   ";
                }
                line += "\n";
            }
            Console.WriteLine(line);
        }

        #endregion
    }
}
