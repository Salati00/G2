using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using G2_DAL;
using G2_Model;

namespace G2_Logic
{
    public class AdminLogic
    {
        UserDAO db = new UserDAO();
        public AdminLogic()
        {
            db.ConnString();
        }
        public void AddAdmin(Admin user)
        {
            user.Password = sha256_hash(user.Password);
            db.DbAddAdmin(user);
        }
        public void AddEmployee(Employee employee)
        {
            db.DbAddEmployee(employee);
        }
        public List<Person> GetAllUsers()
        {
            return db.DbGetAllUsers();
        }
        public Admin LoginUser(string username, string password)
        {
            return db.DbLoginUser(username, sha256_hash(password));
        }
        public bool UsernameExists(string username)
        {
            return db.DbUsernameExists(username);
        }
        public void DeleteUser(Admin user)
        {
            db.DbDeleteUser(user);
        }
        public int GetAmountOfTickets(Person person)
        {
            TicketLogic ticketDB = new TicketLogic();
            List<Ticket> tickets = ticketDB.GetAllTickets();
            int count = 0;
            foreach (var item in tickets)
            {
                if (item.User._id == person._id)
                    count++;
            }
            return count;
        }

        private static String sha256_hash(String value)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return String.Concat(hash
                  .ComputeHash(Encoding.UTF8.GetBytes(value))
                  .Select(item => item.ToString("x2")));
            }
        }
    }
}
