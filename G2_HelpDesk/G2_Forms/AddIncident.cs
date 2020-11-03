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
            UserDAO userdao = new UserDAO();
            List<Person> employees = userdao.DbGetAllUsers();
            

            InitializeComponent();
            
            cbType.DataSource = Enum.GetValues(typeof(TicketTypes));
            cbPriority.DataSource = Enum.GetValues(typeof(TicketPriority));
            foreach (Person employee in employees)
            {
                cbUser.Items.Add(employee._id);
            }

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
            UserDAO userdao = new UserDAO();
            List<Person> users = userdao.DbGetAllUsers();
            TicketDAO ticketDao = new TicketDAO();
            

            DateTime date = DateTime.Now;
            string subject = txtSubject.Text;
            TicketTypes type = (TicketTypes)cbType.SelectedItem;
            Employee user = (Employee)cbUser.SelectedValue;
            

            TicketPriority priority = (TicketPriority)cbPriority.SelectedItem;
            int deadline = int.Parse(txtDeadline.Text);
            string description = txtDescription.Text;

            G2_Model.Ticket ticket = new G2_Model.Ticket(date, subject, type, priority, description, user, deadline);
            ticketDao.DbAddTicket(ticket);
            
        }

        private void cbUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
