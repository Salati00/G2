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
            List<Person> admins = userdao.DbGetAllUsers();
            

            InitializeComponent();
            
            cbType.DataSource = Enum.GetValues(typeof(TicketTypes));
            cbPriority.DataSource = Enum.GetValues(typeof(TicketPriority));
            foreach (Admin a in admins)
            {
                cbUser.Items.Add(a.Firstname +" "+ a.Lastname);
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
            List<Person> admins = userdao.DbGetAllUsers();
            TicketDAO ticketDao = new TicketDAO();
            

            DateTime date = DateTime.Now;
            string subject = txtSubject.Text;
            TicketTypes type = (TicketTypes)cbType.SelectedItem;
            Admin user = (Admin)cbUser.SelectedItem;

            

            TicketPriority priority = (TicketPriority)cbPriority.SelectedItem;
            string deadline = txtDeadline.Text;
            string description = txtDescription.Text;

            foreach (Admin a in admins)
            {
                if (user._id == a._id)
                {
                    G2_Model.Ticket ticket = new G2_Model.Ticket(date, subject, type, priority, description, a);
                    ticketDao.DbAddTicket(ticket);
                }
            }
            

        }

    }
}
