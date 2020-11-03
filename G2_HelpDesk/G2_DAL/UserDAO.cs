using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using G2_Model;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace G2_DAL
{
    public class UserDAO : BaseDAO
    {
        SHA256 mySHA256 = SHA256.Create();

        public void DbAddAdmin(Admin user)
        {
            var document = new BsonDocument {
                { "Firstname", user.Firstname },
                { "Lastname", user.Lastname },
                { "Username", user.Username},
                { "Password", user.Password},
                { "PhoneNumber", user.PhoneNumber},
                { "Email", user.Email} };
            collectionUser.InsertOne(document);
        }
        public void DbAddEmployee(Employee user)
        {
            var document = new BsonDocument {
                { "Firstname", user.Firstname },
                { "Lastname", user.Lastname },
                { "PhoneNumber", user.PhoneNumber},
                { "Email", user.Email},
                { "Branch", user.Branch}};
            collectionUser.InsertOne(document);
        }
        public void DbDeleteUser(Admin user)
        {
            collectionUser.DeleteOne(Builders<BsonDocument>.Filter.Eq("_id", user._id));
        }
        public List<Person> DbGetAllUsers()
        {
            List<Person> users = new List<Person>();
            var docs = collectionUser.Find(Builders<BsonDocument>.Filter.Empty).ToList();
            foreach (BsonDocument doc in docs)
            {
                if (doc.Contains("Username"))
                {
                    {
                        users.Add(GetAdmin(doc));
                    }
                }
                else
                {
                    users.Add(GetEmployee(doc));
                }
            }
            return users;
        }
        public bool DbUsernameExists(string username)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("Username", username);
            var result = collectionUser.Find(filter).FirstOrDefault();
            if (result > 0)
            {
                return true;
            }
            return false;
        }
        public Admin DbLoginUser(string username, string password)
        {
            var filterUser = Builders<BsonDocument>.Filter.Eq("Username", username);
            var filterPass = Builders<BsonDocument>.Filter.Eq("Password", password);
            var filter = Builders<BsonDocument>.Filter.And(filterUser, filterPass);
            var result = collectionUser.Find(filter).FirstOrDefault();
            if (result > 0)
            {
                return new Admin(
                    result.GetValue("_id", new BsonString(string.Empty)).ToString(),
                    result.GetValue("Firstname", new BsonString(string.Empty)).ToString(),
                    result.GetValue("Lastname", new BsonString(string.Empty)).ToString(),
                    result.GetValue("Username", new BsonString(string.Empty)).ToString(),
                    result.GetValue("Password", new BsonString(string.Empty)).ToString(),
                    result.GetValue("PhoneNumber", new BsonString(string.Empty)).ToString(),
                    result.GetValue("Email", new BsonString(string.Empty)).ToString());
            }
            return null;
        }
    }
}
