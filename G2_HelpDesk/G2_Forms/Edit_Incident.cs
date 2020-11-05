using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using G2_Forms;
using G2_Logic;
using G2_Model;

namespace G2_Forms
{
    
    public partial class Edit_Incident : Form
    {
        TransferTicketLogic logic;
        TicketLogic ticketLogic;
        Ticket ticket;
        public Edit_Incident(Ticket ticket)
        {
            InitializeComponent();
            ticketLogic = new TicketLogic();
            logic = new TransferTicketLogic();
            this.ticket = ticket;
            FillTicketDetails();
        }

        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            ticketLogic.DeleteTicket(ticket);
            this.Close();
        }
        private void FillTicketDetails()
        {
            DTP_reportedDate.Value = ticket.ReportDate;
            txtSubject.Text = ticket.Subject;
            
            cbType.DataSource = Enum.GetValues(typeof(TicketTypes));
            cbPriority.DataSource = Enum.GetValues(typeof(TicketPriority));
            foreach (Employee e in logic.GetAllEmployees())
            {
                ComboBoxItem item = new ComboBoxItem(e.Firstname + " " + e.Lastname, e);
                cbUser.Items.Add(item);
                if (e.GetFullName() == ticket.User.GetFullName())
                {
                    cbUser.SelectedItem = item;
                }
            }
            DTP_Deadline.Value = ticket.Deadline;
            txtDescription.Text = ticket.Description;

            cbType.SelectedIndex = (int)ticket.Type;
            cbPriority.SelectedIndex = (int)ticket.Priority;

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

        private void BTN_EDIT_Click(object sender, EventArgs e)
        {
            Ticket newTicket = new Ticket()
            {
                _Id = ticket._Id,
                ReportDate = DTP_reportedDate.Value,
                Subject = txtSubject.Text,
                Type = (TicketTypes)cbType.SelectedItem,
                Priority = (TicketPriority)cbPriority.SelectedItem,
                Description = txtDescription.Text,
                User = (cbUser.SelectedItem as ComboBoxItem).user,
                Deadline = DTP_Deadline.Value
            };
            ticketLogic.EditTicket(newTicket);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
