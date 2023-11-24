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
    // classes and methods added by Coen de Vries
    public class TicketsDao : DAO
    {
        private IMongoCollection<Ticket> ticketCollection;
        public TicketsDao()
        {
            ticketCollection = database.GetCollection<Ticket>("Tickets");
        }

        public List<Ticket> GetAllTickets()
        {
            var filter = Builders<Ticket>.Filter.Gt("Priority", TicketPriority.Closed); // Only check for tickets that are relevant
            return ticketCollection.Find(filter).ToList();
        }

        public List<Ticket> getTicketsByEmail(string Email)
        {
            var filter = Builders<Ticket>.Filter.Eq("Email", Email);
            return ticketCollection.Find(filter).ToList();
        }

        public void insertTicket(Ticket ticket)
        {
            ticket.TicketId = (int)ticketCollection.CountDocuments(new BsonDocument());
            ticketCollection.InsertOne(ticket);
        }

        public void updateTicket(Ticket ticket)
        {
                var filter = Builders<Ticket>.Filter.Eq("TicketId", ticket.TicketId);
                var update = Builders<Ticket>.Update
                    .Set("Email", ticket.Email)
                    .Set("Date", ticket.Date)
                    .Set("Incident", ticket.Incident)
                    .Set("Priority", ticket.Priority)
                    .Set("Deadline", ticket.Deadline)
                    .Set("Description", ticket.Description);
            if (!ticketCollection.UpdateOne(filter, update).IsAcknowledged)
                throw new Exception("Ticket could not be updated");
        }

        public void deleteTicket(Ticket ticket)
        {
            FilterDefinition<Ticket> filter = Builders<Ticket>.Filter.Eq("_id", ticket._id);
            ticketCollection.DeleteOne(filter);
        }
    }
}
