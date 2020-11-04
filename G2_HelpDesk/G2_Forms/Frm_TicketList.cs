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
using G2_Logic;

namespace G2_Forms
{
    public partial class Frm_TicketList : Form
    {
        TicketLogic ticketDB;
        public Frm_TicketList()
        {
            InitializeComponent();
            Uc_Menu.Window = this;
            ticketDB = new TicketLogic();

            Uc_List.GetButton.Text = "Add Ticket";
            Uc_List.GetButton.Show();
            Uc_List.GetButton.Click += GetButton_Click;
        }

        private void GetButton_Click(object sender, EventArgs e)
        {
            AddIncident inc = new AddIncident();
            inc.ShowDialog();
        }

        private void Frm_TicketList_Load(object sender, EventArgs e)
        {
            List<string> Headers = new List<string>();
            Headers.Add("Date");
            Headers.Add("Subject");
            Headers.Add("Type");
            Headers.Add("Priority");
            Headers.Add("Description");

            Uc_Menu.Window = this;
            Uc_List.SetHeaders(Headers);
            Uc_List.SetMode(typeof(Ticket));
            RefreshTicketList();
        }

        public void RefreshTicketList()
        {
            Uc_List.ClearTable();
            ticketDB.GetAllTickets().ForEach(x => {
                Uc_List.AddElement(x);
                });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_TicketOverview overview = new Frm_TicketOverview();
            overview.ShowDialog();
            this.Hide();
        }
    }
}
