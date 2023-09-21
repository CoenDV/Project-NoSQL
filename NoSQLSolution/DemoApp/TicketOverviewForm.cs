using Logic;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DemoApp
{
    public partial class TicketOverviewForm : Form
    {
        private Databases databases;
        private List<Ticket> tickets;

        public TicketOverviewForm()
        {
            InitializeComponent();

            databases = new Databases();
            tickets = databases.GetAllTickets();
            listViewResults.View = View.Details;

            loadTickets(tickets);
        }

        private void loadTickets(List<Ticket> tickets)
        {
            listViewResults.Items.Clear();

            foreach (Ticket ticket in tickets)
            {
                ListViewItem ticketItem = new ListViewItem($"{ticket.TicketId}");
                ticketItem.SubItems.Add($"{ticket.User.Email}");
                ticketItem.SubItems.Add($"{ticket.User.Firstname}");
                ticketItem.SubItems.Add($"{ticket.Date}");
                ticketItem.SubItems.Add($"{ticket.Priority}");

                listViewResults.Items.Add(ticketItem);
            }
        }

        private void txtBoxFilter_Leave(object sender, EventArgs e)
        {
            if (txtBoxFilter.Text.Length > 0)
            {
                loadTickets(databases.getTicketsByEmail(txtBoxFilter.Text, tickets));
            }
            else
                loadTickets(databases.GetAllTickets());
        }
    }
}
