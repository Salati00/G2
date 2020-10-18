using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G2_Model
{
    public class Ticket : IListable
    {
        private DateTime reportDate;
        private string subject;
        private TicketTypes type;
        private TicketPriority priority;
        private string description;
        private User user;

        public DateTime ReportDate { get => reportDate; set => reportDate = value; }
        public string Subject { get => subject; set => subject = value; }
        public TicketTypes Type { get => type; set => type = value; }
        public TicketPriority Priority { get => priority; set => priority = value; }
        public string Description { get => description; set => description = value; }
        public User User { get => user; set => user = value; }

        /// <summary>
        /// Method to get a list from the current object
        /// </summary>
        /// <param name="model">specifies which objects to return based off of which are null or empty</param>
        /// <returns></returns>
        public List<object> ToList(IListable model)
        {
            List<object> lst = new List<object>();
            
            lst.Add((((Ticket)model).ReportDate != null) ? ReportDate.ToString() : null);
            lst.Add((((Ticket)model).Subject != null) ? Subject.ToString() : null);
            lst.Add((((Ticket)model).Type != TicketTypes.Empty) ? Type.ToString() : null);
            lst.Add((((Ticket)model).Priority != TicketPriority.Empty) ? Priority.ToString() : null);
            lst.Add((((Ticket)model).Description != null) ? Description.ToString() : null);
            //probably display something from users too idk
            return lst;
        }

        /// <summary>
        /// Method to get a list from the current object
        /// </summary>
        /// <returns></returns>
        public List<object> ToList()
        {
            List<object> lst = new List<object>();

            lst.Add(ReportDate.ToString());
            lst.Add(Subject.ToString());
            lst.Add(Type.ToString());
            lst.Add(Priority.ToString());
            lst.Add(Description.ToString());
            //probably display something from users too idk

            return lst;
        }
    }
}
