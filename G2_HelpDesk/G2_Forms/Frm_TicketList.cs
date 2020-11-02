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
    public partial class Frm_TicketList : Form
    {
        public Frm_TicketList()
        {
            InitializeComponent();

            Uc_Menu.Window = this;

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

        }
    }
}
