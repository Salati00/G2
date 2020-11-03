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
        UserDAO userdao;
        List<Person> employees;
        TicketDAO ticketdao;
        G2_Model.Ticket ticket;
        public AddIncident()
        {
            InitializeComponent();

            userdao = new UserDAO();
            employees = new List<Person>();
            employees = userdao.DbGetAllUsers();
            ticketdao = new TicketDAO();


            cbType.DataSource = Enum.GetValues(typeof(TicketTypes));
            cbPriority.DataSource = Enum.GetValues(typeof(TicketPriority));

            foreach (Person p in employees)
            {
                cbUser.Items.Add(p.Firstname);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddIncident_Load(object sender, EventArgs e)
        {

        }
        public class ComboBoxItem
        {
            public string Text { get; set; }
            public Employee Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            string subject = txtSubject.Text;
            TicketTypes type = (TicketTypes)cbType.SelectedItem;
            Employee user = (Employee)cbUser.SelectedValue;
            TicketPriority priority = (TicketPriority)cbPriority.SelectedItem;
            int deadline = int.Parse(txtDeadline.Text);
            string description = txtDescription.Text;


            foreach (Person emp in employees)
            {
                if (emp.Firstname == cbUser.SelectedItem)
                {
                    ticket = new G2_Model.Ticket(date, subject, type, priority, description, emp, deadline);
                    ticketdao.DbAddTicket(ticket);
                }
            }


        }

        private void cbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
