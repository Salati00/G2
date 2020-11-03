using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using G2_Model;
using G2_DAL;
using G2_Logic;




namespace G2_Forms
{
    public partial class AddIncident : Form
    {
        G2_Model.Ticket ticket;
        TicketLogic ticketlogic;
        TransferTicketLogic ticketLogic;
        public AddIncident()
        {
            InitializeComponent();
            ticketLogic = new TransferTicketLogic();
            cbType.DataSource = Enum.GetValues(typeof(TicketTypes));
            cbPriority.DataSource = Enum.GetValues(typeof(TicketPriority));
            foreach (Employee e in ticketLogic.GetAllEmployees())
            {
                cbUser.Items.Add(new ComboBoxItem(e.Firstname + " " + e.Lastname, e));
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_TicketList ticketList = new Frm_TicketList();
            ticketList.ShowDialog();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            string subject = txtSubject.Text;
            TicketTypes type = (TicketTypes)cbType.SelectedItem;
            Employee user = (cbUser.SelectedItem as ComboBoxItem).user;
            TicketPriority priority = (TicketPriority)cbPriority.SelectedItem;
            int deadline = int.Parse(txtDeadline.Text);
            string description = txtDescription.Text;

            ticket = new G2_Model.Ticket(date, subject, type, priority, description, user, deadline);
            ticketlogic.AddTicket(ticket);

            this.Close();
            Frm_TicketList ticketList = new Frm_TicketList();
            ticketList.ShowDialog();
        }

        public class ComboBoxItem : object
        {
            public string name;
            public Employee user;

            public ComboBoxItem(string name, Employee user)
            {
                this.name = name;
                this.user = user;
            }

            public override string ToString()
            {
                return name;
            }
        }
    }
}
