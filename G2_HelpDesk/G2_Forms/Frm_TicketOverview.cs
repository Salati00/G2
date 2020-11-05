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
        int closedTicket;
        int ticketPastDeadline;
        List<G2_Model.Ticket> tickets;
        public Frm_TicketOverview()
        {
            InitializeComponent();
            ticketLogic = new TicketLogic();
            tickets = new List<G2_Model.Ticket>();
            tickets = ticketLogic.GetAllTickets();
            foreach (G2_Model.Ticket ticket in tickets)
            {
                if (ticket.Priority == TicketPriority.Closed)
                {
                    closedTicket++;
                }
                else if (DateTime.Now > ticket.Deadline)
                {
                    ticketPastDeadline++;
                }
                else
                {
                    ticketCount++;
                }
            }
            lbl_ClosedTickets.Text = closedTicket.ToString();
            lbl_itemCount.Text = ticketCount.ToString();
            lbl_ticketPastDeadline.Text = ticketPastDeadline.ToString();

        }

        private void BTN_Dashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
