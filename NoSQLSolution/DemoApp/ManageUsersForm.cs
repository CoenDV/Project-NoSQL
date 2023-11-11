using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using Model;

namespace DemoApp
{
    public partial class ManageUsersForm : Form
    {
        private EmployeeLogic employeeLogic;
        private Employee currentUser; 
        public ManageUsersForm()
        {
            InitializeComponent();
            employeeLogic = new EmployeeLogic();
            btnAddUser.Click += BtnAddUser_Click;
            Load += ManageUsersForm_Load; 
        }
        public ManageUsersForm(Employee currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser; 
            btnAddUser.Enabled = currentUser.UserType == UserType.ServiceDesk; 
        }
        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            if (currentUser != null && currentUser.UserType == UserType.ServiceDesk)
            {
                AddUserForm addUserForm = new AddUserForm(this);
                addUserForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Only serviceDesk users are allowed to add new users.");
            }
        }
        private void ManageUsersForm_Load(object sender, EventArgs e)
        {
            InitializeListViewColumns();
            lvUsers.Items.Clear();
            LoadUsers(); 
        }
        private void InitializeListViewColumns()
        {
            lvUsers.Columns.Clear();

            lvUsers.View = View.Details;
            lvUsers.Columns.Add("Firstname", 120); 
            lvUsers.Columns.Add("Lastname", 120);
            lvUsers.Columns.Add("Email", 200); 
            lvUsers.Columns.Add("Password", 200); 
        }
        private void LoadUsers()
        {
            var employees = employeeLogic.GetAllRegularUsers(); 
            foreach (var employee in employees)
            {
                AddUserToListView(employee, "*****"); 
            }
        }
        public void AddUserToListView(Employee employee, string password)
        {
            var item = new ListViewItem(new[] {
                employee.Firstname,
                employee.Lastname,
                employee.Email,
                employee.Password,
            });
            lvUsers.Items.Add(item);
            lvUsers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
    }
}
