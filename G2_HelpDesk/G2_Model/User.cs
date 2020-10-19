using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace G2_Model
{
    public class User : IListable
    {
        public string _id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public User(string firstname, string lastname, string username, string password, string phonenumber, string email)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Username = username;
            this.Password = password;
            this.PhoneNumber = phonenumber;
            this.Email = email;
        }
        public User(string id, string firstname, string lastname, string username, string password, string phonenumber, string email)
        {
            this._id = id;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Username = username;
            this.Password = password;
            this.PhoneNumber = phonenumber;
            this.Email = email;
        }
        public User()
        { }

        /// <summary>
        /// Method to get a list from the current object
        /// </summary>
        /// <param name="model">specifies which objects to return based off of which are null</param>
        /// <returns></returns>
        public List<object> ToList(IListable model)
        {
            List<object> lst = new List<object>();

            lst.Add((((User)model).Firstname != null) ? Firstname.ToString() : null);
            lst.Add((((User)model).Lastname != null) ? Lastname.ToString() : null);
            lst.Add((((User)model).Username != null) ? Username.ToString() : null);
            lst.Add((((User)model).Password != null) ? Password.ToString() : null);
            lst.Add((((User)model).PhoneNumber != null) ? PhoneNumber.ToString() : null);
            lst.Add((((User)model).Email != null) ? Email.ToString() : null);

            return lst;
        }

        public List<object> ToList()
        {
            List<object> lst = new List<object>();

            lst.Add(Firstname.ToString());
            lst.Add(Lastname.ToString());
            lst.Add(Username.ToString());
            lst.Add(Password.ToString());
            lst.Add(PhoneNumber.ToString());
            lst.Add(Email.ToString());

            return lst;
        }
    }
}
