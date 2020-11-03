using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G2_Model;

namespace G2_Logic
{
    public static class SortingTicketFunctionalityLogic
    {
        public static List<object> SortTickets(List<object> tickets)
        {
            List<object> returnList = new List<object>(tickets.OrderBy(o => ((Ticket)o).Priority).ToList());
            return returnList;
        }
    }
}
