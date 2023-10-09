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
    public class TicketsDao : DAO
    {
        private IMongoCollection<Ticket> ticketCollection;
        public TicketsDao() {
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
            ticket.TicketId = (int)database.GetCollection<Ticket>("Tickets").CountDocuments(new BsonDocument());
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
            ticketCollection.UpdateOne(filter, update);
        }
    }
}
