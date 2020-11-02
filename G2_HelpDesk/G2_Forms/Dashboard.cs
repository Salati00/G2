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

namespace G2_Forms
{
    public partial class Dashboard : Form
    {
        static Admin admin;

        private static readonly Lazy<Dashboard> lazyInstance = new Lazy<Dashboard>(() => new Dashboard(admin));

        public static Dashboard GetInstance()
        {
            return lazyInstance.Value;
        }

        public static Dashboard GetInstance(Admin admin)
        {
            Dashboard.admin = admin;
            return lazyInstance.Value;
        }

        private Dashboard(Admin admin)
        {
            InitializeComponent();
            Dashboard.admin = admin;
            lbl_Username.Text = admin.Firstname + " " + admin.Lastname;
        }

        private void btb_Logout_Click(object sender, EventArgs e)
        {
            LoginPage.Instance.Clear();
            LoginPage.Instance.Show();
            this.Hide();
        }

        private void btn_CreateUser_Click(object sender, EventArgs e)
        {
            AddUser newUser = new AddUser(admin);
            newUser.Show();
            this.Hide();
        }

        private void btn_account_Click(object sender, EventArgs e)
        {
            AccountInfo account = new AccountInfo(admin);
            account.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket();
            ticket.Show();
            this.Hide();
        }

        private void btb_EmployeeList_Click(object sender, EventArgs e)
        {
            Frm_EmployeeList employees = new Frm_EmployeeList();
            employees.Show();
            this.Hide();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginPage.Instance.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_TicketList tickets = new Frm_TicketList();
            tickets.Show();
            this.Hide();
        }
    }
}
