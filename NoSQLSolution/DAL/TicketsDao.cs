using Model;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TicketsDao : DAO
    {
        public List<Ticket> GetAllTickets()
        {
            var filter = Builders<Ticket>.Filter.Gt("Priority", TicketPriority.Closed); // Only check for tickets that are relevant
            return database.GetCollection<Ticket>("Tickets").Find(filter).ToList();
        }

        public List<Ticket> getTicketsByEmail(string Email)
        {
            var filter = Builders<Ticket>.Filter.Eq("User", Email);
            return database.GetCollection<Ticket>("Tickets").Find(filter).ToList();
        }

        public void insertTicket(Ticket ticket)
        {
            ticket.TicketId = (int)database.GetCollection<Ticket>("Tickets").CountDocuments(new BsonDocument());
            database.GetCollection<Ticket>("Tickets").InsertOne(ticket);
        }

        public void updateTicket(Ticket ticket)
        {
            var filter = Builders<Ticket>.Filter.Eq("TicketId", ticket.TicketId);
            var update = Builders<Ticket>.Update
                .Set("User", ticket.User)
                .Set("Date", ticket.Date)
                .Set("Incident", ticket.Incident)
                .Set("Priority", ticket.Priority)
                .Set("Deadline", ticket.Deadline)
                .Set("Description", ticket.Description);
            database.GetCollection<Ticket>("Tickets").UpdateOne(filter, update);
        }
    }
}
