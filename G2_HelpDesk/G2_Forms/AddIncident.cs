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
            Frm_TicketList ticketList = new Frm_TicketList();
            ticketList.ShowDialog();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ticketlogic = new TicketLogic();

            G2_Model.Ticket t = new G2_Model.Ticket()
            {
                ReportDate = BTD_reportedDate.Value,
                Subject = txtSubject.Text,
                Type = (TicketTypes)cbType.SelectedItem,
                Priority = (TicketPriority)cbPriority.SelectedItem,
                Description = txtDescription.Text,
                User = (cbUser.SelectedItem as ComboBoxItem).user,
                Deadline = int.Parse(txtDeadline.Text)
            };
            
            ticketlogic.AddTicket(t);

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
