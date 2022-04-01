using RentMe_App.Model;
using System.Windows.Forms;

namespace RentMe_App.UserControls
{
    public partial class EmployeeDetailsUserControl : UserControl
    {
        public EmployeeDetailsUserControl()
        {
            InitializeComponent();
        }

        public void FillDetails(Employee employeeToShow)
        {
            employeeBindingSource.DataSource = employeeToShow;
        }
    }
}
