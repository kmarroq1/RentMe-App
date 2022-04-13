using RentMe_App.View.EmployeeModals;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RentMe_App.UserControls.MemberDashboardUCs
{
    /// <summary>
    /// User control for orders and returns.
    /// </summary>
    public partial class OrdersAndReturnsUserControl : UserControl
    {
        #region Data Members

        //private readonly OrdersController _ordersController;
        //private List<Order> _orderList;
        private readonly int _currentMemberID;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor for class.
        /// </summary>
        public OrdersAndReturnsUserControl(int memberID)
        {
            if (memberID < 0)
            {
                throw new ArgumentException("Invalid member");
            }

            InitializeComponent();

            //_ordersController = new OrdersController(memberID);
            //_orderList = _ordersController.getOrderHistory();
            _currentMemberID = memberID;

            PopulateDataGridView();
            PopulateComboBox();
        }

        #endregion

        #region Methods

        private void SearchButton_Click(object sender, EventArgs e)
        {
            errorMsgLabel.Text = "";
            try
            {
                if (!string.IsNullOrEmpty(transactionIdTextBox.Text) && int.Parse(transactionIdTextBox.Text) < 0)
                {
                    errorMsgLabel.Text = "Transaction ID must be a positive number";
                    return;
                }
                //is this where we want this conditional to go?
                else if (pendingOrdersCheckbox.Checked)
                {
                    //_orderList = _ordersController.getPendingOrders(_currentMemberID);
                }
                else
                {
                    //_orderList = _ordersController.getOrdersByTransactionId(_currentMemberID, int.Parse(transactionIdTextBox.Text));
                }
            }
            catch (Exception)
            {
                errorMsgLabel.Text = "Search failed";
            }

            RefreshData();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            ViewOrderModal newForm = new ViewOrderModal(/*_selectedOrder*/);
            orderHistoryDataGridView.DataSource = null;
            orderHistoryDataGridView.Rows.Clear();
            errorMsgLabel.Text = "";
            _ = newForm.ShowDialog();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            transactionIdTextBox.Text = "";
            pendingOrdersCheckbox.Checked = false;
            yearsComboBox.SelectedIndex = -1;
            orderHistoryDataGridView.DataSource = null;
            orderHistoryDataGridView.Rows.Clear();
            errorMsgLabel.Text = "";
        }

        private void PopulateComboBox()
        {
            var years = new List<string>() { "--Select--", "2022", "2021", "2020" };
            yearsComboBox.DataSource = new BindingSource(years, null);
            yearsComboBox.SelectedIndex = -1;
        }

        private void YearsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorMsgLabel.Text = "";
            //_orderList = _ordersController.getOrdersByYear(yearsComboBox.SelectedValue.ToString());
            RefreshData();
        }

        private void RefreshData()
        {
            //if (_orderList == null || _orderList.Count = 0)
            //{
            //errorMsgLabel.Text = "No orders found...";
            //return;
            //}

            orderHistoryDataGridView.DataSource = null;
            orderHistoryDataGridView.Rows.Clear();

            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            /*
              foreach (Order order in _orderList)
                {
                    orderHistoryDataGridView.Rows.Add([add columns here]);
                }
             */
        }

        #endregion
    }
}
