using Logic;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoApp
{
    public partial class TicketView : AddTicketForm
    {
        private Ticket ticket;
        public TicketView(Ticket ticket)
        {
            InitializeComponent();

            this.ticket = ticket;
            lblCreateticket.Text = $"Details of ticket {ticket.TicketId}";
            btnSubmit.Text = "Update ticket";
            dateTimePickerTicket.MaxDate = DateTime.Now;
            ticketsLogic = new TicketsLogic();

            loadComboBoxType();
            loadComboBoxUsers();
            loadComboBoxPriority();
            loadComboBoxDeadline();

            setControls();
        }

        private void setControls()
        {
            dateTimePickerTicket.Value = ticket.Date;
            comboBoxType.Text = ticket.Incident.ToString();
            comboBoxUser.Text = ticket.User.Username.ToString();
            comboBoxPriority.Text = ticket.Priority.ToString();
            comboBoxDeadline.Text = ticket.Deadline.ToString();
            textBoxDescription.Text = ticket.Description;
        }

        protected override void btnSubmit_Click(object sender, EventArgs e)
        {
            if (textBoxDescription.Text.Length <= 0)
                MessageBox.Show("No valid description was given", "Error occured");
            else
            {
                DialogResult dr = MessageBox.Show($"Are you sure you want to update ticket #{ticket.TicketId}",
                      "Warning", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        ticketsLogic.updateTicket(new Ticket(MongoDB.Bson.ObjectId.Empty, ticket.TicketId, (Employee)comboBoxUser.SelectedItem, dateTimePickerTicket.Value, (TypeOfIncident)Enum.Parse(typeof(TypeOfIncident), comboBoxType.Text), (TicketPriority)Enum.Parse(typeof(TicketPriority), comboBoxPriority.Text), (Deadlines)Enum.Parse(typeof(Deadlines), comboBoxDeadline.Text), textBoxDescription.Text));
                        this.Close();
                        MessageBox.Show("ticket is added", "");
                        break;
                    case DialogResult.No:
                        break;
                }
            }
        }
    }
}