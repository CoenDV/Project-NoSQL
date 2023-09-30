using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Employee
    {
        public ObjectId _id { get; set; }
        public int EmployeeId;
        public string Email;
        public string Firstname;
        public string Lastname;
        public string Username;
        public string Password;
        public UserType UserType;

        public Employee(ObjectId id, int ID, string email, string firstname, string lastname, string username, string password, UserType userType)
        {
            _id = id;
            EmployeeId = ID;
            Email = email;
            Firstname = firstname;
            Lastname = lastname;
            Username = username;
            Password = password;
            UserType = userType;
        }

        public override string ToString()
        {
            return this.Username.ToString();
        }
    }
}
