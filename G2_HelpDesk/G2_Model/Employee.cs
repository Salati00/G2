      using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G2_Model
{
    public class Employee : Person
    {
        private Branch branch;
        public Branch Branch { get => branch; set => branch = value; }

        public Employee(string firstname, string lastname, string phonenumber, string email, Branch branch) : base(firstname, lastname, phonenumber, email)
        {
            this.Branch = branch;
        }
        public Employee(string firstname, string lastname, string phonenumber, string email) : base(firstname, lastname, phonenumber, email)
        {

        }
        public Employee(string id, string firstname, string lastname, string phonenumber, string email, Branch branch) : base(id, firstname, lastname, phonenumber, email)
        {
            this.Branch = branch;
        }

        public Employee()
        {
        }

        public override List<object> ToList()
        {
            List<object> lst = base.ToList();
            lst.Add(Branch.ToString());

            return lst;
        }
        
    }
}
 