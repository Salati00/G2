using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using G2_Model;

namespace G2_DAL
{
    public class BaseDAO
    {
        protected static IMongoClient client;
        protected static IMongoDatabase database;
        protected static IMongoCollection<BsonDocument> collectionUser;
        protected static IMongoCollection<BsonDocument> collectionTicket;
        protected static bool ConnectionEstablished = false; //Makes sure the ConnUser doesn't run more than once
        public void ConnString()
        {
            if (!ConnectionEstablished)
            {
                client = new MongoClient("mongodb+srv://dbUser:noww6w4agyqOhr4s@g2.kxnnm.azure.mongodb.net/g2Database?retryWrites=true&w=majority");
                database = client.GetDatabase("g2Database");
                collectionUser = database.GetCollection<BsonDocument>("Users");
                collectionTicket = database.GetCollection<BsonDocument>("Tickets");
                ConnectionEstablished = true;
            }
        }
        public Admin GetAdmin(BsonDocument doc)
        {
            Admin user = new Admin(
                    doc.GetValue("_id", new BsonString(string.Empty)).ToString(),
                    doc.GetValue("Firstname", new BsonString(string.Empty)).ToString(),
                    doc.GetValue("Lastname", new BsonString(string.Empty)).ToString(),
                    doc.GetValue("Username", new BsonString(string.Empty)).ToString(),
                    doc.GetValue("Password", new BsonString(string.Empty)).ToString(),
                    doc.GetValue("PhoneNumber", new BsonString(string.Empty)).ToString(),
                    doc.GetValue("Email", new BsonString(string.Empty)).ToString());
            return user;
        }
        public Employee GetEmployee(BsonDocument doc)
        {
            Employee user = new Employee(
                    doc.GetValue("_id", new BsonString(string.Empty)).ToString(),
                    doc.GetValue("Firstname", new BsonString(string.Empty)).ToString(),
                    doc.GetValue("Lastname", new BsonString(string.Empty)).ToString(),
                    doc.GetValue("PhoneNumber", new BsonString(string.Empty)).ToString(),
                    doc.GetValue("Email", new BsonString(string.Empty)).ToString(),
                    (Branch)(doc.GetValue("Branch", new BsonString(string.Empty)).ToInt32()));
            return user;
        }
    }
}
