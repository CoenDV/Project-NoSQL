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
        private Employee employee;

        public TicketOverviewForm(Employee employee)
        {
            InitializeComponent();

            btnUserManagement.Click += btnUserManagement_Click;
            btnCloseTicket.Click += btnCloseTicket_Click;

            this.employee = employee;
            ticketsLogic = new TicketsLogic();

            listViewResults.View = View.Details;
            listViewResults.FullRowSelect = true;
            listViewResults.MultiSelect = false;

            loadTickets();
            if (employee.UserType == UserType.ServiceDesk)
            {
                lblFilter.Visible = false;
                txtBoxFilter.Visible = false;
            }
        }

        private void loadTickets()
        {
            try
            {
                listViewResults.Items.Clear(); 

                List<Ticket> tickets = ticketsLogic.GetAllTickets();

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
            if (txtBoxFilter.Text.Length > 0)
                loadTickets();
        }

        private void listViewResults_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem selectedItem = listViewResults.SelectedItems[0];
        }

        private void btnCreateIncident_Click(object sender, EventArgs e)
        {
            AddTicketForm addTicketForm = new AddTicketForm(employee);
            var dialogResult = addTicketForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                loadTickets();
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

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            try
            {
                ManageUsersForm manageUsersForm = new ManageUsersForm();
                this.Hide();
                manageUsersForm.ShowDialog();
                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ocurred");
            }
        }
        private void btnCloseTicket_Click(object sender, EventArgs e)
        {
            if (listViewResults.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a ticket to close.");
                return;
            }

            var result = MessageBox.Show("Are you sure you want to close this ticket?", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    var selectedTicketItem = listViewResults.SelectedItems[0];
                    var selectedTicket = (Ticket)selectedTicketItem.Tag;

                    ticketsLogic.CloseTicket(selectedTicket.TicketId);
                    listViewResults.Items.Remove(selectedTicketItem); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error closing ticket: {ex.Message}", "Error");
                }
            }
        }

    }
}
