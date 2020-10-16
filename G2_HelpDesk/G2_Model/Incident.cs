using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G2_Model
{
    public class Incident : IListable
    {
        public DateTime ReportDate;
        public string Subject;
        public TicketTypes Type;
        //User user;
        public TicketPriority Priority;
        public string Description;

        /// <summary>
        /// Method to get a list from the current object
        /// </summary>
        /// <param name="model">specifies which objects to return based off of which are null or empty</param>
        /// <returns></returns>
        public List<object> ToList(IListable model)
        {
            List<object> lst = new List<object>();
            
            lst.Add((((Incident)model).ReportDate != null) ? ReportDate.ToString() : null);
            lst.Add((((Incident)model).Subject != null) ? Subject.ToString() : null);
            lst.Add((((Incident)model).Type != TicketTypes.Empty) ? Type.ToString() : null);
            lst.Add((((Incident)model).Priority != TicketPriority.Empty) ? Priority.ToString() : null);
            lst.Add((((Incident)model).Description != null) ? Description.ToString() : null);

            return lst;
        }

        public List<object> ToList()
        {
            List<object> lst = new List<object>();

            lst.Add(ReportDate.ToString());
            lst.Add(Subject.ToString());
            lst.Add(Type.ToString());
            lst.Add(Priority.ToString());
            lst.Add(Description.ToString());

            return lst;
        }
    }
}
