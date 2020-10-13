using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace G2_Model
{
    public class User
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int PhoneNumber { get; set; } 
        public string Email { get; set; }

        public User(string firstname, string lastname, string username, string password,int phonenumber, string email)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Username = username;
            this.Password = password;
            this.PhoneNumber = phonenumber;
            this.Email = email;
        }

        

    }
}
