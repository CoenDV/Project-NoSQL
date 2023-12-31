﻿using Model;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmployeeDao : DAO
    {
        public List<Employee> GetAllRegularUsers()
        {
            var filter = Builders<Employee>.Filter.Eq("UserType", UserType.RegularUser);
            return database.GetCollection<Employee>("Employees").Find(filter).ToList();
        }
    }
}
