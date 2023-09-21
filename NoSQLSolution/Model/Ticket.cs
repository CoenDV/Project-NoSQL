using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Ticket
    {
        public ObjectId _id { get; set; }
        public int TicketId;
        public Employee User;
        public DateTime Date;
        public TicketPriority Priority;
        public int Deadline;
        public string Description;

        public Ticket(ObjectId id, int ticketId, Employee user, DateTime date, TicketPriority priority, int deadline, string description)
        {
            _id = id;
            TicketId = ticketId;
            User = user;
            Date = date;
            Priority = priority;
            Deadline = deadline;
            Description = description;
        }
    }
}
