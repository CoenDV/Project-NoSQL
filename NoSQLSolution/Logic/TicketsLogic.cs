using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class TicketsLogic
    {
        private TicketsDao ticketsDao;

        public TicketsLogic()
        {
            ticketsDao = new TicketsDao();
        }

        public List<Ticket> GetAllTickets()
        {
            return ticketsDao.GetAllTickets();
        }

        public List<Ticket> getTicketsByEmail(string Email)
        {
            return ticketsDao.getTicketsByEmail(Email);
        }

        public void insertTicket(Ticket ticket)
        {
            ticketsDao.insertTicket(ticket);
        }

        public void updateTicket(Ticket ticket)
        {
            ticketsDao.updateTicket(ticket);
        }
    }
}
