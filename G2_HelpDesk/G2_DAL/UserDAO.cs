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
    public class UserDAO
    {
        IMongoClient client;
        IMongoDatabase database;
        IMongoCollection<BsonDocument> collectionUser;
        public void ConnUser()
        {
            client = new MongoClient("mongodb+srv://dbUser:noww6w4agyqOhr4s@g2.kxnnm.azure.mongodb.net/g2Database?retryWrites=true&w=majority");
            database = client.GetDatabase("g2Database");
            collectionUser = database.GetCollection<BsonDocument>("Users");
        }
        public void DeleteUser(int id) //not tested
        {
            collectionUser.DeleteOneAsync(Builders<BsonDocument>.Filter.Eq("_id", id));
        }

        public void DbAddUser(User user)
        {
            var document = new BsonDocument {
                { "Firstname", user.Firstname },
                { "Lastname", user.Lastname },
                { "Username", user.Username},
                { "Password", user.Password},
                { "PhoneNumber", user.PhoneNumber},
                { "Email", user.Email} };
            ConnUser();
            collectionUser.InsertOne(document);
        }
        public List<User> DbGetAllUsers() //not tested
        {
            List<User> users = new List<User>();
            User user;
            foreach (BsonDocument collection in database.ListCollectionsAsync().Result.ToListAsync<BsonDocument>().Result)
            {
                user = new User(
                    (int)collection["_id"],
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
        public async Task<bool> UsernameExists(string username) //not tested
        {
            var filter = Builders<BsonDocument>.Filter.Eq("Username", username);
            var result = await collectionUser.Find(filter).FirstOrDefaultAsync();
            if (result > 0)
            {
                return true;
            }
            return false;
        }
        public async Task<User> LoginUser(string username, string password) //not tested
        {
            var filterUser = Builders<BsonDocument>.Filter.Eq("Username", username);
            var filterPass = Builders<BsonDocument>.Filter.Eq("Password", password);
            var filter = Builders<BsonDocument>.Filter.And(filterUser, filterPass);
            var result = await collectionUser.Find(filter).FirstOrDefaultAsync();
            if(result > 0)
            {
                return new User(
                    (int)result["_id"],
                    result["Fistname"].AsString,
                    result["Lastname"].AsString,
                    result["Username"].AsString,
                    result["Password"].AsString,
                    result["PhoneNumber"].AsString,
                    result["Email"].AsString);
            }
            return null;
        }
    }
}
