using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    // classes and methods added by Coen de Vries
    public class TicketsLogic
    {
        private TicketsDao ticketsDao;

        public TicketsLogic()
        {
            ticketsDao = new TicketsDao();
        }

        public List<Ticket> loadTickets(Employee employee)
        {
            if (employee.UserType == UserType.ServiceDesk)
                return GetAllTickets();
            else
                return getTicketsByEmail(employee.Email);
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

        public void deleteTicket(Ticket ticket)
        {
            ticketsDao.deleteTicket(ticket);
        }
    }
}
