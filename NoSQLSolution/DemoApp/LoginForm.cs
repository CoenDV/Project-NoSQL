using Logic;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoApp
{
    public partial class LoginForm : Form
    {
        InlogService inlogService;
        Databases databases = new Databases();
        List<Employee> employees;
        public LoginForm()
        {
            InitializeComponent();
            employees = databases.GetAllEmployees();
            inlogService = new InlogService();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtBoxUsername.Text;
            string password = txtBoxPassword.Text;
            if (password == "" || username == "")
            {
                MessageBox.Show("Please fill in all fields");
            }
            else
            {
                try
                {
                    Employee employee = inlogService.LogUserIn(username, password);
                    MessageBox.Show(employee.Firstname + " is ingelogd");
                }
                catch (Exception fout)
                {
                    MessageBox.Show(fout.Message);
                    throw;
                }
                
            }                       
        }
        private void LogUserIn()
        {
            int count = 0;
            foreach (var employee in employees)
            {
                inlogService.SetDBWachtwoord(employees[count], "test" + $"{count + 1}");
                count++;
            }
        }
    }
}
