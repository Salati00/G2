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




namespace G2_Forms
{
    public partial class AddIncident : Form
    {
        public AddIncident()
        {
            Ticket incident = new Ticket();


            InitializeComponent();
            
            cbType.DataSource = Enum.GetValues(typeof(TicketTypes));
            cbPriority.DataSource = Enum.GetValues(typeof(TicketPriority));
            
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddIncident_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            TicketDAO ticketDao = new TicketDAO();

            string id = txtID.Text;
            DateTime date = DateTime.Now;
            string subject = txtSubject.Text;
            TicketTypes type = (TicketTypes)cbType.SelectedItem;
            Admin user = (Admin)cbUser.SelectedItem;
            TicketPriority priority = (TicketPriority)cbPriority.SelectedItem;
            string deadline = txtDeadline.Text;
            string description = txtDescription.Text;

            G2_Model.Ticket ticket = new G2_Model.Ticket(id, date, subject, type, priority, description, user);
            ticketDao.DbAddTicket(ticket);

        }
    }
}
