using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class EmployeeLogic
    {
        private EmployeeDao employeeDao;

        public EmployeeLogic()
        {
            employeeDao = new EmployeeDao();
        }
        public List<Employee> GetAllRegularUsers()
        {
            return employeeDao.GetAllRegularUsers();
        }
    }
}
