using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G2_Model
{
    public class Incident
    {
        DateTime dateReportd;
        string subject;
        enum Type { Technical }
        //User user;
        enum Priority { Urgent, Normal}
        string description;
    }
}
