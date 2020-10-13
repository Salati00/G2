using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G2_Model
{
    public class Incident
    {
        public DateTime dateReportd;
        public string subject;
        public enum Type { Technical }
        //User user;
        public enum Priority { Urgent, Normal}
        public string description;
    }
}
