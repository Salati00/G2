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
        UserDAO testdb = new UserDAO();

        public void AddUser(User user)
        {
            testdb.DbAddUser(user);
        }
        public List<User> GetAllUsers()
        {
            return testdb.DbGetAllUsers();
        }
    }
}
