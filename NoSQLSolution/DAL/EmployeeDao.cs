using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    using Model;
    using MongoDB.Bson;
    using MongoDB.Driver;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class EmployeeDao : DAO
    {
        public List<Employee> GetAllUsers()
        {
            return database.GetCollection<Employee>("Employees").Find(new BsonDocument()).ToList();
        }
        public Employee GetPersooneelByUserName(string username)
        {
            var filter = Builders<Employee>.Filter.Eq("Username", username);
            return database.GetCollection<Employee>("Employees").Find(filter).FirstOrDefault();
        }
        public void updatePassword(Employee employee, string newPassword)
        {
            var filter = Builders<Employee>.Filter.Eq("Username", employee.Username);
            var update = Builders<Employee>.Update
                .Set("Password", newPassword);
            database.GetCollection<Employee>("Employees").UpdateOne(filter, update);
        }

    }
}
