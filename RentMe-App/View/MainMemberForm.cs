using System.Windows.Forms;

namespace RentMe_App.View
{
    /// <summary>
    /// class for main member form
    /// Author: cs6232-g5
    /// Version: Spring 2022
    /// </summary>
    public partial class MainMemberForm : Form
    {
        #region Data members

        /// <summary>
        /// Member MemberID
        /// </summary>
        public int memberIDForm;

        private readonly MainEmployeeForm mainEmployeeForm;
        private bool _killApp;

        #endregion

        #region Constructors

        /// <summary>
        /// constructor used to initialize the MainMemberForm class
        /// </summary>
        /// <param name="mainEmployeeForm">main employee form passed to main member form</param>
        public MainMemberForm(MainEmployeeForm mainEmployeeForm)
        {
            InitializeComponent();
            this.mainEmployeeForm = mainEmployeeForm;
            _killApp = true;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Logs the user out.
        /// </summary>
        public void Logout()
        {
            _killApp = false;
            SharedFormInfo.MainEmployeeForm.Logout();
            Close();
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// method used to get the member ID to show on the form
        /// </summary>
        /// <returns>member ID</returns>
        public int GetMemberID()
        {
            return memberIDForm;
        }

        #endregion

        #region Event Handlers

        private void LogoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Logout();
        }

        private void MainMemberForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_killApp) Application.Exit();
        }

        private void MainMemberForm_Load(object sender, System.EventArgs e)
        {
            usernameValueLabel.Text = SharedFormInfo.UsernameForm;
            employeeNameValueLabel.Text = SharedFormInfo.EmployeeNameForm;
            memberIDValueLabel.Text = SharedFormInfo.MemberIDForm.ToString();

            SharedFormInfo.MainEmployeeForm.Hide();
        }

        #endregion
    }
}
