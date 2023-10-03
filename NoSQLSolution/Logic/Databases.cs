using DAL;
using Model;
using System.Collections.Generic;

namespace Logic
{
    public class Databases
    {
        private EmployeeDao employeeDao;
        public Databases()
        {
            employeeDao = new EmployeeDao();
        }
        public List<Employee> GetAllEmployees()
        {
            return employeeDao.GetAllUsers();
        }
        public void ChangePassword(Employee employee, string password)
        {
            employeeDao.updatePassword(employee, password);
        }
        
    }
}
