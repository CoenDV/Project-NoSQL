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
    // classes and methods added by Coen de Vries
    public partial class TicketOverviewForm : Form
    {
        private TicketsLogic ticketsLogic;
        private Employee employee;

        public TicketOverviewForm(Employee employee)
        {
            InitializeComponent();

            this.employee = employee;
            ticketsLogic = new TicketsLogic();

            // set settings for the listview
            listViewResults.View = View.Details;
            listViewResults.FullRowSelect = true;
            listViewResults.MultiSelect = false;

            loadTickets();
            // only show filter if user is a servicedesk employee, others can only see their own tickets
            if (employee.UserType == UserType.ServiceDesk)
            {
                lblFilter.Visible = false;
                txtBoxFilter.Visible = false;
            }
        }

        private void loadTickets()
        {
            List<Ticket> tickets = new List<Ticket>();
            try
            {
                listViewResults.Items.Clear(); // making sure there is no duplicate items in the listview

                tickets = ticketsLogic.loadTickets(employee);
                foreach (Ticket ticket in tickets)
                {
                    ListViewItem ticketItem = new ListViewItem($"{ticket.TicketId}");
                    ticketItem.SubItems.Add($"{ticket.Email}");
                    ticketItem.SubItems.Add($"{ticket.Date:dd-MM-yyyy}");
                    ticketItem.SubItems.Add($"{ticket.Priority}");
                    ticketItem.Tag = ticket;

                    listViewResults.Items.Add(ticketItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ocurred");
            }
        }

        private void txtBoxFilter_Leave(object sender, EventArgs e)
        {
            // Only use filter if text is entered
            if (txtBoxFilter.Text.Length > 0)
                loadTickets();
        }

        private void listViewResults_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem selectedItem = listViewResults.SelectedItems[0];
        }

        private void btnCreateIncident_Click(object sender, EventArgs e)
        {
            try
            {
                AddTicketForm addTicketForm = new AddTicketForm(employee);
                addTicketForm.ShowDialog();
                loadTickets();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ocurred");
            }
        }

        private void listViewResults_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                TicketView ticketView = new TicketView(employee, listViewResults.SelectedItems[0].Tag as Ticket);
                ticketView.ShowDialog();
                loadTickets();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ocurred");
            }
        }
    }
}
