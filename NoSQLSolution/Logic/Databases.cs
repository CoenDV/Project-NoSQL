using DAL;
using Model;
using System.Collections.Generic;

namespace Logic
{
    public class Databases
    {
        private DAO dao;
        public Databases()
        {
            dao = new DAO();
        }

        public List<Ticket> GetAllTickets()
        {
            return dao.GetAllTickets();
        }

        public List<Ticket> getTicketsByEmail(string Email, List<Ticket> tickets)
        {
            List<Ticket> ticketsByEmail = new List<Ticket>();

            foreach (Ticket ticket in tickets)
            {
                if(ticket.User.Email == Email)
                    ticketsByEmail.Add(ticket);
            }

            return ticketsByEmail;
        }
    }
}
