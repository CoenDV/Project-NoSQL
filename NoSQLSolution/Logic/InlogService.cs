using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class InlogService
    {
        
        private EmployeeDao employeeDao = new EmployeeDao();
        public Employee LogUserIn(string userName, string password)
        {
            Employee employee = employeeDao.GetPersooneelByUserName(userName);
            if (employee != null)
            {
                if (employee.Password == ComputeSha256Hash(password))
                {
                    return employee;
                };
                throw new Exception("password");
            }
            throw new Exception("username");
        }
        public void SetDBWachtwoord(Employee employee, string wachtwoord)
        {
            employeeDao.updatePassword(employee, ComputeSha256Hash(wachtwoord));
        }
        private string ComputeSha256Hash(string computeThis)
        {
            SHA256 sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(computeThis));
            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte bit in bytes)
            {
                stringBuilder.Append(bit.ToString("x2"));
            }
            return stringBuilder.ToString();
        }
        
    }
}
