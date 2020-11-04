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
    
    public partial class Frm_TicketOverview : Form
    {
        TicketLogic ticketLogic;
        int ticketCount;
        List<G2_Model.Ticket> tickets;
        public Frm_TicketOverview()
        {
            InitializeComponent();
            ticketLogic = new TicketLogic();
            tickets = new List<G2_Model.Ticket>();
            tickets = ticketLogic.GetAllTickets();
            foreach (G2_Model.Ticket ticket in tickets)
            {
                ticketCount++;

            }

            lbl_itemCount.Text = ticketCount.ToString();

        }

    }
}
