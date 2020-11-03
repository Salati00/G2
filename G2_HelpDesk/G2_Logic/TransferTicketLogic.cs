using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G2_DAL;
using G2_Model;

namespace G2_Logic
{
    public class TransferTicketLogic
    {
        TransferTicketDAO db = new TransferTicketDAO();
        public void TransferTicket(Ticket from, Employee to)
        {
            db.DbTransferTicket(from, to);
        }
        public List<Employee> GetAllEmployees()
        {
            return db.DbGetAllEmployees();
        }
    }
}
