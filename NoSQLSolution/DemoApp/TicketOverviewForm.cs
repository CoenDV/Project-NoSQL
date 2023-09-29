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
        private TicketsLogic ticketsLogic;
        private List<Ticket> tickets;

        public TicketOverviewForm()
        {
            InitializeComponent();

            ticketsLogic = new TicketsLogic();
            tickets = ticketsLogic.GetAllTickets();
            listViewResults.View = View.Details;
            listViewResults.FullRowSelect = true;
            listViewResults.MultiSelect = false;

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
                ticketItem.SubItems.Add($"{ticket.Date:dd-MM-yyyy}");
                ticketItem.SubItems.Add($"{ticket.Priority}");
                ticketItem.Tag = ticket;

                
                listViewResults.Items.Add(ticketItem);
            }
        }

        private void txtBoxFilter_Leave(object sender, EventArgs e)
        {
            // Only use filter if text is entered, otherwise just show everything
            if (txtBoxFilter.Text.Length > 0)
            {
                loadTickets(ticketsLogic.getTicketsByEmail(txtBoxFilter.Text, tickets));
            }
            else
                loadTickets(ticketsLogic.GetAllTickets());
        }

        private void listViewResults_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem selectedItem = listViewResults.SelectedItems[0];

        }

        private void btnCreateIncident_Click(object sender, EventArgs e)
        {
            AddTicketForm addTicketForm = new AddTicketForm();
            addTicketForm.ShowDialog();
        }

        private void listViewResults_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TicketView ticketView = new TicketView(listViewResults.SelectedItems[0].Tag as Ticket);
            ticketView.ShowDialog();
        }
    }
}
