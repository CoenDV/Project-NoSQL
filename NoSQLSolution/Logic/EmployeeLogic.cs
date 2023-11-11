using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class EmployeeLogic
    {
        private EmployeeDao employeeDao;
        private TicketsDao ticketsDao;

        public EmployeeLogic()
        {
            employeeDao = new EmployeeDao();
        }
        public List<Employee> GetAllRegularUsers()
        {
            return employeeDao.GetAllRegularUsers();
        }
        public void AddEmployee(Employee employee)
        {
            employeeDao.Insert(employee);

        }
    }
}
