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

        public TicketView(Employee employee, Ticket ticket) : base(employee)
        {
            InitializeComponent();

            this.ticket = ticket;
            lblCreateticket.Text = $"Details of ticket {ticket.TicketId}";
            btnSubmit.Text = "Update ticket"; // overrides text from base form
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
            try
            {
                dateTimePickerTicket.Value = ticket.Date;
                comboBoxType.Text = ticket.Incident.ToString();
                comboBoxUser.Text = ticket.Email;
                comboBoxPriority.Text = ticket.Priority.ToString();
                comboBoxDeadline.Text = ticket.Deadline.ToString();
                textBoxDescription.Text = ticket.Description;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ocurred");
            }
        }

        protected override void btnSubmit_Click(object sender, EventArgs e)
        {
            // fields must not be empty before sending object to database
            if (comboBoxType.Text.Length <= 0 || comboBoxPriority.Text.Length <= 0 || comboBoxDeadline.Text.Length <= 0 || textBoxDescription.Text.Length <= 0)
                MessageBox.Show("Some fields have not been filled properly", "Error occured");
            else
            {
                DialogResult dr = MessageBox.Show($"Are you sure you want to update ticket #{ticket.TicketId}",
                      "Warning", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        ticketsLogic.updateTicket(new Ticket(MongoDB.Bson.ObjectId.Empty, ticket.TicketId, employee._id, employee.Email, dateTimePickerTicket.Value, (TypeOfIncident)Enum.Parse(typeof(TypeOfIncident), comboBoxType.Text), (TicketPriority)Enum.Parse(typeof(TicketPriority), comboBoxPriority.Text), (Deadlines)Enum.Parse(typeof(Deadlines), comboBoxDeadline.Text), textBoxDescription.Text));
                        this.Close();
                        MessageBox.Show("ticket is updated", "");
                        break;
                    case DialogResult.No:
                        break;
                }
            }
        }
    }
}