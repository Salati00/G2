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
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ticketlogic = new TicketLogic();

            G2_Model.Ticket t = new G2_Model.Ticket()
            {
                ReportDate = DTP_reportedDate.Value,
                Subject = txtSubject.Text,
                Type = (TicketTypes)cbType.SelectedItem,
                Priority = (TicketPriority)cbPriority.SelectedItem,
                Description = txtDescription.Text,
                User = (cbUser.SelectedItem as ComboBoxItem).user,
                Deadline = DTP_Deadline.Value
            };
            
            ticketlogic.AddTicket(t);

            this.Close();
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
