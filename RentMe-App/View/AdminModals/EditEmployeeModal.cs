using System.Windows.Forms;

namespace RentMe_App.View.AdminModals
{
    /// <summary>
    /// Class for employee editing modal.
    /// </summary>
    public partial class EditEmployeeModal : Form
    {
        private readonly int employeeID;
        /// <summary>
        /// Constructor for class.
        /// </summary>
        public EditEmployeeModal(int employeeID)
        {
            InitializeComponent(); 
            this.employeeID = employeeID;
        }

        //TODO add editing functionality
    }
}
