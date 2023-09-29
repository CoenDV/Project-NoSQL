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
        protected TicketsLogic ticketsLogic;
        public AddTicketForm()
        {
            InitializeComponent();

            dateTimePickerTicket.MaxDate = DateTime.Now;
            ticketsLogic = new TicketsLogic();

            loadComboBoxType();
            loadComboBoxUsers();
            loadComboBoxPriority();
            loadComboBoxDeadline();
        }

        protected void loadComboBoxType()
        {
            comboBoxType.Items.Clear();
            foreach (TypeOfIncident incident in Enum.GetValues(typeof(TypeOfIncident)))
            {
                comboBoxUser.Tag = incident;
                comboBoxType.Items.Add(incident);
            }
        }

        protected void loadComboBoxUsers()
        {
            comboBoxUser.Items.Clear();
            EmployeeLogic employeeLogic = new EmployeeLogic();
            List<Employee> employees = employeeLogic.GetAllRegularUsers();
            foreach (Employee employee in employees)
            {
                comboBoxUser.Tag = employee;
                comboBoxUser.Items.Add(employee);
            }
        }

        protected void loadComboBoxPriority()
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

        protected void loadComboBoxDeadline()
        {
            comboBoxDeadline.Items.Clear();
            foreach (Deadlines deadline in Enum.GetValues(typeof(Deadlines)))
            {
                comboBoxDeadline.Tag = deadline;
                comboBoxDeadline.Items.Add(deadline);
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected virtual void btnSubmit_Click(object sender, EventArgs e)
        {
            // the description must not be empty before sending it to the database
            if (textBoxDescription.Text.Length <= 0)
                MessageBox.Show("No valid description was given", "Error occured");
            else
            {
                ticketsLogic.insertTicket(new Ticket(MongoDB.Bson.ObjectId.Empty, -1, (Employee)comboBoxUser.SelectedItem, dateTimePickerTicket.Value, (TypeOfIncident)Enum.Parse(typeof(TypeOfIncident), comboBoxType.Text), (TicketPriority)Enum.Parse(typeof(TicketPriority), comboBoxPriority.Text), (Deadlines)Enum.Parse(typeof(Deadlines), comboBoxDeadline.Text), textBoxDescription.Text));
                this.Close();
                MessageBox.Show("ticket is added", "");
            }
        }
    }
}
