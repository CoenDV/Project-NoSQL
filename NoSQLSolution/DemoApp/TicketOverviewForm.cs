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

            this.employee = employee;
            ticketsLogic = new TicketsLogic();

            // set settings for the listview
            listViewResults.View = View.Details;
            listViewResults.FullRowSelect = true;
            listViewResults.MultiSelect = false;
                
            // checks usertype and only shows allowed tickets
            // for now only servicedesk users can see all tickets and all the others can only view own tickets
            if(employee.UserType == UserType.ServiceDesk)
                loadTickets(ticketsLogic.GetAllTickets());
            else
            {
                loadTickets(ticketsLogic.getTicketsByEmail(employee.Email));
                lblFilter.Visible = false;
                txtBoxFilter.Visible = false;
            }
        }

        private void loadTickets(List<Ticket> tickets)
        {
            try
            {
                listViewResults.Items.Clear(); // making sure there is no duplicate date in the listview

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
            // Only use filter if text is entered, otherwise just show everything
            if (txtBoxFilter.Text.Length > 0)
            {
                loadTickets(ticketsLogic.getTicketsByEmail(txtBoxFilter.Text));
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
            try
            {
                AddTicketForm addTicketForm = new AddTicketForm(employee);
                addTicketForm.ShowDialog();
                loadTickets(ticketsLogic.GetAllTickets());
            }
            catch(Exception ex)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ocurred");
            }
        }
    }
}
