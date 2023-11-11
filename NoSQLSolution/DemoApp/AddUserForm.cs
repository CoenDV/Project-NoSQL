using System;
using System.Windows.Forms;
using Model;
using Logic;
using System.IO;



namespace DemoApp
{
    public partial class AddUserForm : Form
    {
        private EmployeeLogic employeeLogic;
        private ManageUsersForm manageUsersForm;

        public AddUserForm(ManageUsersForm umForm)
        {
            InitializeComponent();
            this.manageUsersForm = umForm;
            employeeLogic = new EmployeeLogic();
            cbUserType.DataSource = Enum.GetValues(typeof(UserType));
            cbLocationBranch.DataSource = Enum.GetValues(typeof(LocationBranch));
        }
        public void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtboxFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtboxLastName.Text) ||
                string.IsNullOrWhiteSpace(txtboxEmail.Text) ||
                string.IsNullOrWhiteSpace(txtboxPhoneNumber.Text))
            {
                MessageBox.Show("All fields are required. Please fill in all fields.", "Input Validation Failed");
                return; 
            }

            string password = GenerateRandomPassword();

            Employee newEmployee = new Employee
            {
                Firstname = txtboxFirstName.Text.Trim(),
                Lastname = txtboxLastName.Text.Trim(),
                Email = txtboxEmail.Text.Trim(),
                Phonenumber = txtboxPhoneNumber.Text.Trim(),
                UserType = (UserType)cbUserType.SelectedItem,
                BranchLocation = (LocationBranch)cbLocationBranch.SelectedItem,
                Password = password, 
            };

            try
            {
                employeeLogic.AddEmployee(newEmployee);
                manageUsersForm.AddUserToListView(newEmployee, password);
                MessageBox.Show("Employee added successfully");
                this.DialogResult = DialogResult.OK; 
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding employee: {ex.Message}", "Error");
            }
        }

        private string GenerateRandomPassword()
        {
            return Path.GetRandomFileName().Replace(".", "").Substring(0, 8);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
