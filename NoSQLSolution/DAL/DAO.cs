using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using Model;
using MongoDB.Bson.Serialization;
using System.Net.Sockets;

namespace DAL
{
    public class DAO
    {
        private MongoClient client;
        protected IMongoDatabase database;
        private string connectionString = "mongodb://admin1:Admin123@ac-ttxolj5-shard-00-00.nfoidg5.mongodb.net:27017,ac-ttxolj5-shard-00-01.nfoidg5.mongodb.net:27017,ac-ttxolj5-shard-00-02.nfoidg5.mongodb.net:27017/?replicaSet=atlas-13zm8m-shard-0&ssl=true&authSource=admin";

        public DAO()
        {
            client = new MongoClient(connectionString);
            database = client.GetDatabase("NoSQL");
        }
    }
}