using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G2_Model
{
    public class Employee
    {
        public string _id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Branch Branch { get; set; }

        public Employee(string firstname, string lastname, string phonenumber, string email, Branch branch)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.PhoneNumber = phonenumber;
            this.Email = email;
            this.Branch = branch;
        }
        public Employee(string id, string firstname, string lastname, string phonenumber, string email, Branch branch)
        {
            this._id = id;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.PhoneNumber = phonenumber;
            this.Email = email;
            this.Branch = branch;
        }

    }
}
 