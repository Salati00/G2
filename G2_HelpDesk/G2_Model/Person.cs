using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G2_Model
{
    public class Person : IListable
    {
        public string _id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Person(string firstname, string lastname, string phonenumber, string email)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.PhoneNumber = phonenumber;
            this.Email = email;
        }

        public Person(string id, string firstname, string lastname, string phonenumber, string email)
        {
            this._id = id;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.PhoneNumber = phonenumber;
            this.Email = email;
        }

        public Person()
        {
        }

        public virtual List<object> ToList()
        {
            List<object> lst = new List<object>();

            lst.Add(Firstname.ToString());
            lst.Add(Lastname.ToString());
            lst.Add(PhoneNumber.ToString());
            lst.Add(Email.ToString());

            return lst;
        }

        public virtual string GetFullName()
        {
            return this.Firstname + " " + this.Lastname;
        }
    }
}
