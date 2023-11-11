using Model;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class TicketsDao : DAO
    {
        private IMongoCollection<Ticket> ticketCollection;
        public TicketsDao()
        {
            ticketCollection = database.GetCollection<Ticket>("Tickets");
        }

        public List<Ticket> GetAllTickets()
        {
            var filter = Builders<Ticket>.Filter.Ne(t => t.Priority, TicketPriority.Closed);
            return ticketCollection.Find(filter).ToList();
        }

        public List<Ticket> getTicketsByEmail(string Email)
        {
            FilterDefinition<Ticket> filter = Builders<Ticket>.Filter.Eq("Email", Email);
            return ticketCollection.Find(filter).ToList();
        }

        public void insertTicket(Ticket ticket)
        {
            ticket.TicketId = (int)ticketCollection.CountDocuments(new BsonDocument());
            ticketCollection.InsertOne(ticket);
        }

        public void updateTicket(Ticket ticket)
        {
                FilterDefinition<Ticket> filter = Builders<Ticket>.Filter.Eq("TicketId", ticket.TicketId);
                UpdateDefinition<Ticket> update = Builders<Ticket>.Update
                    .Set("Email", ticket.Email)
                    .Set("Date", ticket.Date)
                    .Set("Incident", ticket.Incident)
                    .Set("Priority", ticket.Priority)
                    .Set("Deadline", ticket.Deadline)
                    .Set("Description", ticket.Description);
            if (!ticketCollection.UpdateOne(filter, update).IsAcknowledged)
                throw new Exception("Ticket could not be updated");
        }
       public void CloseTicket(int ticketId)
    {
        var filter = Builders<Ticket>.Filter.Eq(t => t.TicketId, ticketId);
        var update = Builders<Ticket>.Update.Set(t => t.Priority, TicketPriority.Closed);
        ticketCollection.UpdateOne(filter, update);
    }

    }
}
