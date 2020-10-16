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
        IMongoClient client;
        IMongoDatabase database;
        IMongoCollection<BsonDocument> collection;
        public void ConnUser()
        {
            client = new MongoClient("mongodb+srv://dbUser:noww6w4agyqOhr4s@g2.kxnnm.azure.mongodb.net/g2Database?retryWrites=true&w=majority");
            database = client.GetDatabase("g2Database");
            collection = database.GetCollection<BsonDocument>("Users");
        }
        public void Delete<User>(User user) //DOES NOT WORK AS YET
        {
            //WorkAround for DeleteOne parameter
            //ObjectFilterDefinition<User> filter = new User();
            // Remove the object.
            /*
            database.GetCollection<User>(typeof(User).Name).FindOneAndDelete(filter);*/
        }

        public void DbAddUser(User user)
        {
            var document = new BsonDocument { { "Firstname", user.Firstname }, { "Lastname", user.Lastname }, { "Username", user.Username}, { "Password", user.Password}, { "PhoneNumber", user.PhoneNumber},{ "Email", user.Email} };
            ConnUser();
            collection.InsertOne(document);
        }
        public List<User> DbGetAllUsers()
        {
            List<User> users = new List<User>();
            User user;
            foreach (BsonDocument collection in database.ListCollectionsAsync().Result.ToListAsync<BsonDocument>().Result)
            {
                user = new User(
                    collection["Fistname"].AsString,
                    collection["Lastname"].AsString,
                    collection["Username"].AsString,
                    collection["Password"].AsString,
                    collection["PhoneNumber"].AsString,
                    collection["Email"].AsString);
                users.Add(user);
            }
            return users;
        }

    }

}
