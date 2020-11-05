using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G2_DAL;
using G2_Model;

namespace G2_Logic
{
    public class TicketLogic
    {
        TicketDAO db = new TicketDAO();
        public TicketLogic()
        {
            db.ConnString();
        }
        public void AddTicket(Ticket ticket)
        {
            db.DbAddTicket(ticket);
        }
        public void DeleteTicket(Ticket ticket)
        {
            db.DeleteTicket(ticket);
        }
        public void EditTicket(Ticket ticket)
        {
            db.DbUpdateTicket(ticket);
        }

        public List<Ticket> GetAllTickets()
        {
            return db.DbGetAllTickets();
        }
    }
}
