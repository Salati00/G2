using G2_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G2_Forms
{
    public partial class Ticket : Form
    {
        private string id;
        private DateTime date;
        private string subject;
        private TicketTypes type;
        private TicketPriority priority;
        private string description;
        private Admin user;

        public Ticket()
        {
            InitializeComponent();
        }

        public Ticket(string id, DateTime date, string subject, TicketTypes type, TicketPriority priority, string description, Admin user)
        {
            this.id = id;
            this.date = date;
            this.subject = subject;
            this.type = type;
            this.priority = priority;
            this.description = description;
            this.user = user;
        }

        private void btnCreateIncident_Click(object sender, EventArgs e)
        {
            AddIncident incident = new AddIncident();
            incident.ShowDialog();
        }

        private void Ticket_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dashboard.GetInstance().Show();
        }
    }
}
