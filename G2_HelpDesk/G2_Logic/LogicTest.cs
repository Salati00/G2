using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G2_DAL;
using G2_Model;

namespace G2_Logic
{
    public class LogicTest
    {
        UserDAO db = new UserDAO();

        public LogicTest()
        {
            db.ConnUser();
        }
        public void AddUser(User user)
        {
            db.DbAddUser(user);
        }
        public List<User> GetAllUsers()
        {
            return db.DbGetAllUsers();
        }
        public User LoginUser(string username, string password)
        {
            return db.DbLoginUser(username, password);
        }
        public bool UsernameExists(string username)
        {
            return db.DbUsernameExists(username);
        }
    }
}
