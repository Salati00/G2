﻿using System;
using System.Collections.Generic;
using System.Linq;
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
        public void AddUser(Admin user)
        {
            db.DbAddUser(user);
        }
        public List<Person> GetAllUsers()
        {
            return db.DbGetAllUsers();
        }
        public Admin LoginUser(string username, string password)
        {
            return db.DbLoginUser(username, password);
        }
        public bool UsernameExists(string username)
        {
            return db.DbUsernameExists(username);
        }
        public void DeleteUser(Admin user)
        {
            db.DbDeleteUser(user);
        }
    }
}