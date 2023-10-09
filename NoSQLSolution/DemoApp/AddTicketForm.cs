using Logic;
using Model;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoApp
{
    public partial class AddTicketForm : Form
    {
        private Employee employee;

        protected TicketsLogic ticketsLogic;

        // a default contructor is needed for inherited form TicketView
        public AddTicketForm()
        {
            InitializeComponent();
        }
        public AddTicketForm(Employee employee)
        {
            InitializeComponent();

            this.employee = employee;
            dateTimePickerTicket.MaxDate = DateTime.Now;
            ticketsLogic = new TicketsLogic();

            loadComboBoxType();
            loadComboBoxUsers();
            loadComboBoxPriority();
            loadComboBoxDeadline();
        }

        protected void loadComboBoxType()
        {
            try
            {
                comboBoxType.Items.Clear();
                foreach (TypeOfIncident incident in Enum.GetValues(typeof(TypeOfIncident)))
                {
                    comboBoxType.Tag = incident;
                    comboBoxType.Items.Add(incident);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error ocurred");
            }
        }

        protected void loadComboBoxUsers()
        {
            try
            {
                comboBoxUser.Text = employee.Email;
                comboBoxUser.Enabled = false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error ocurred");
            }
        }

        protected void loadComboBoxPriority()
        {
            try
            {
                comboBoxPriority.Items.Clear();
                foreach (TicketPriority priority in Enum.GetValues(typeof(TicketPriority)))
                {
                    if (priority != TicketPriority.Closed)
                    {
                        comboBoxPriority.Tag = priority;
                        comboBoxPriority.Items.Add(priority);
                    }
                }
            }
            catch(Exception e) {
                MessageBox.Show(e.Message, "Error ocurred");
            }
        }

        protected void loadComboBoxDeadline()
        {
            try
            {
                comboBoxDeadline.Items.Clear();
                foreach (Deadlines deadline in Enum.GetValues(typeof(Deadlines)))
                {
                    comboBoxDeadline.Tag = deadline;
                    comboBoxDeadline.Items.Add(deadline);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Error ocurred");
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected virtual void btnSubmit_Click(object sender, EventArgs e)
        {
            // fields must not be empty before sending object to database
            if (comboBoxType.Text.Length <= 0 || comboBoxPriority.Text.Length <= 0 || comboBoxDeadline.Text.Length <= 0 || textBoxDescription.Text.Length <= 0)
                MessageBox.Show("Some fields have not been filled properly", "Error occured");
            else
            {
                ticketsLogic.insertTicket(new Ticket(MongoDB.Bson.ObjectId.Empty, -1, employee._id, employee.Email, dateTimePickerTicket.Value, (TypeOfIncident)Enum.Parse(typeof(TypeOfIncident), comboBoxType.Text), (TicketPriority)Enum.Parse(typeof(TicketPriority), comboBoxPriority.Text), (Deadlines)Enum.Parse(typeof(Deadlines), comboBoxDeadline.Text), textBoxDescription.Text));
                this.Close();
                MessageBox.Show("ticket is added", "");
            }
        }
    }
}
