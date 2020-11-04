using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using G2_Logic;
using G2_Model;

namespace G2_Forms
{
    public partial class Frm_TransferTicket : Form
    {
        TransferTicketLogic transferLogic;
        G2_Model.Ticket ticket;
        Employee employee;
        List<Employee> employees;
        public Frm_TransferTicket(G2_Model.Ticket ticket)
        {
            InitializeComponent();
            employee = new Employee();
            transferLogic = new TransferTicketLogic();
            this.ticket = ticket;
            employees = transferLogic.GetAllEmployees();
            cmb_selectUser.DropDownStyle = ComboBoxStyle.DropDownList;

            ticket_description.Text = ticket.Description;
            ticket_subject.Text = ticket.Subject;
            deadline.Text = $"{ticket.Deadline.ToString()} days";
            transferFrom.Text = $"{ticket.User.Firstname} {ticket.User.Lastname}";
            foreach (Employee emp in employees)
            {
                ComboBoxItem item = new ComboBoxItem();
                string fullname = $"{emp.Firstname} {emp.Lastname}";
                item.Text = fullname;
                item.Value = emp;
                cmb_selectUser.Items.Add(item);
            }
        }

        private void btn_transfer_Click(object sender, EventArgs e)
        {
            if (employee.Firstname != null)
            {
                transferLogic.TransferTicket(ticket, employee);
                Close();
            }
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

        private void cmb_selectUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            employee = (cmb_selectUser.SelectedItem as ComboBoxItem).Value;
        }
    }
}
