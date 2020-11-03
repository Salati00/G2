using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace G2_Model
{
    public class Admin : Person
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Admin(string firstname, string lastname, string username, string password, string phonenumber, string email)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Username = username;
            this.Password = password;
            this.PhoneNumber = phonenumber;
            this.Email = email;
        }
        public Admin(string id, string firstname, string lastname, string username, string password, string phonenumber, string email)
        {
            this._id = id;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Username = username;
            this.Password = password;
            this.PhoneNumber = phonenumber;
            this.Email = email;
        }
        public Admin()
        { }

        public override List<object> ToList()
        {
            List<object> lst = base.ToList();/*
            lst.Add(Username.ToString());
            lst.Add(Password.ToString());*/

            return lst;
        }
    }
}
