using System.Windows.Forms;

namespace RentMe_App.View.AdminModals
{
    /// <summary>
    /// Class for employee editing modal.
    /// </summary>
    public partial class EditEmployeeModal : Form
    {
        private readonly int _employeeId;

        /// <summary>
        /// Constructor for class.
        /// </summary>
        public EditEmployeeModal(int employeeID)
        {
            InitializeComponent(); 
            this._employeeId = employeeID;
            PopulateFields();
        }

        private void PopulateFields()
        {
            //populate fields
        }

        private void UpdateButton_Click(object sender, System.EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, System.EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, System.EventArgs e)
        {

        }

        //TODO add editing functionality
    }
}
