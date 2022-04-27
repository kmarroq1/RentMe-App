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

        private readonly OrdersController _ordersController;
        private List<Order> _orderList;
        private int _currentMemberID;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor for class.
        /// </summary>
        public OrdersAndReturnsUserControl()
        {
            InitializeComponent();

            _ordersController = new OrdersController();
            errorMsgLabel.Text = "";
            _currentMemberID = 0;
            ViewButton.Enabled = false;
            PopulateComboBox();
        }

        #endregion

        #region Methods

        private void SearchButton_Click(object sender, EventArgs e)
        {
            errorMsgLabel.Text = "";
            ViewButton.Enabled = false;
            orderHistoryDataGridView.DataSource = null;
            orderHistoryDataGridView.Rows.Clear();
            if (_orderList != null)
            {
                _orderList.Clear();
            }

            _currentMemberID = int.Parse(SharedFormInfo.MemberIDForm.ToString());
            errorMsgLabel.Text = "";
            try
            {
                if (!string.IsNullOrEmpty(transactionIdTextBox.Text) && int.Parse(transactionIdTextBox.Text) < 0)
                {
                    throw new Exception("Transaction ID must be a positive number");
                }
                else if (string.IsNullOrEmpty(transactionIdTextBox.Text))
                {
                    throw new Exception("Must enter a transaction ID");
                }
                //is this where we want this conditional to go?
                /*else if (pendingOrdersCheckbox.Checked)
                {
                    //_orderList = _ordersController.getPendingOrders(_currentMemberID);
                }*/
                else
                {
                    _orderList = _ordersController.GetOrdersByTransactionId(_currentMemberID, int.Parse(transactionIdTextBox.Text));
                    RefreshData();
                }
            }
            catch (Exception exception)
            {
                errorMsgLabel.Text = exception.Message;
            }

            RefreshData();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            var selectedOrderID = int.Parse(orderHistoryDataGridView.SelectedRows[0].Cells["ID"].Value.ToString());
            var selectedOrderType = orderHistoryDataGridView.SelectedRows[0].Cells["Type"].Value.ToString();
            var selectedOrder = _orderList.Find(x => x.TransactionID == selectedOrderID && x.OrderType == selectedOrderType);

            ViewOrderModal newForm = new ViewOrderModal(selectedOrder);
            orderHistoryDataGridView.DataSource = null;
            orderHistoryDataGridView.Rows.Clear();
            errorMsgLabel.Text = "";
            ViewButton.Enabled = false;

            newForm.ShowDialog();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            transactionIdTextBox.Text = "";
            pendingOrdersCheckbox.Checked = false;
            yearsComboBox.SelectedIndex = -1;
            orderHistoryDataGridView.DataSource = null;
            orderHistoryDataGridView.Rows.Clear();
            errorMsgLabel.Text = "";
            ViewButton.Enabled = false;
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewButton.Enabled = true;
            errorMsgLabel.Text = "";
            orderHistoryDataGridView.CurrentRow.Selected = true;
        }

        private void PopulateComboBox()
        {
            var years = new List<string>() { "--Select--", "2022", "2021", "2020" };
            yearsComboBox.DataSource = new BindingSource(years, null);
            yearsComboBox.SelectedIndex = 1;
        }

        private void RefreshData()
        {
            orderHistoryDataGridView.DataSource = null;
            orderHistoryDataGridView.Rows.Clear();

            try
            {
                if (_orderList == null || _orderList.Count == 0)
                {
                    throw new Exception("No orders");
                }
                foreach (var order in _orderList)
                {
                    orderHistoryDataGridView.Rows.Add(order.TransactionID, order.OrderType, order.OrderDate, order.DueDate, order.DateReturned, order.OrderTotal, order.Open, order.Balance);
                }
            }
            catch (Exception exception)
            {
                errorMsgLabel.Text = exception.Message;
            }
        }

        private void PopulateDataGridView()
        {
            try
            {
                _currentMemberID = int.Parse(SharedFormInfo.MemberIDForm.ToString());
                _orderList = _ordersController.GetOrderHistory(_currentMemberID);
                if (_orderList == null || _orderList.Count == 0)
                {
                    throw new Exception("No orders");
                }
                foreach (var order in _orderList)
                {
                    orderHistoryDataGridView.Rows.Add(order.TransactionID, order.OrderType, order.OrderDate.ToShortDateString(), order.DueDate.ToShortDateString(), order.DateReturned, "$ " + order.OrderTotal, order.Open);
                }
            }
            catch (Exception exception)
            {
                errorMsgLabel.Text = exception.Message;
            }
        }

        private void ViewAllButton_Click(object sender, EventArgs e)
        {
            errorMsgLabel.Text = "";
            ViewButton.Enabled = false;
            orderHistoryDataGridView.DataSource = null;
            orderHistoryDataGridView.Rows.Clear();
            if (_orderList != null)
            {
                _orderList.Clear();
            }
            PopulateDataGridView();
        }

        #endregion
    }
}
