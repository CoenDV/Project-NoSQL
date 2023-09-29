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
        /*
         * The employees are embedded so that database lookups are limited to getting tickets and filtering tickets. 
         * Also only tickets that are not yet closed can be displayed so the amount of tickets to be loaded is limited.
         */
        public ObjectId _id { get; set; }
        public int TicketId;
        public Employee User;
        public DateTime Date;
        public TypeOfIncident Incident;
        public TicketPriority Priority;
        public Deadlines Deadline;
        public string Description;

        public Ticket(ObjectId id, int ticketId, Employee user, DateTime date, TypeOfIncident typeOfIncident,TicketPriority priority, Deadlines deadline, string description)
        {
            _id = id;
            TicketId = ticketId;
            User = user;
            Date = date;
            Incident = typeOfIncident;
            Priority = priority;
            Deadline = deadline;
            Description = description;
        }
    }
}
