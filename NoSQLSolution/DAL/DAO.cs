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
        private IMongoDatabase database;
        private string connectionString = "mongodb://admin1:Admin123@ac-ttxolj5-shard-00-00.nfoidg5.mongodb.net:27017,ac-ttxolj5-shard-00-01.nfoidg5.mongodb.net:27017,ac-ttxolj5-shard-00-02.nfoidg5.mongodb.net:27017/?replicaSet=atlas-13zm8m-shard-0&ssl=true&authSource=admin";

        public DAO()
        {
            client = new MongoClient(connectionString);
            database = client.GetDatabase("NoSQL");
        }

        // Ticket model class moet nog aangemaakt worden, moet precies het zelfde als hoe alles in de json docs komt, dan werkt deze functie automatisch
        // de "Collection moet aangepast worden naar de naam van aan te maken collection"
        public List<Ticket> GetAllTickets()
        {
            return database.GetCollection<Ticket>("Tickets").Find(new BsonDocument()).ToList();
        }

        public List<Ticket> getTicketsByEmail(string Email)
        {
            var filter = Builders<Ticket>.Filter.Eq("User", Email);
            return database.GetCollection<Ticket>("Les2").Find(filter).ToList();
        }
    }
}
