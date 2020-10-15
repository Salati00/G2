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
        public void Delete<T>(T item) where T : class, new()
        {
            //WorkAround for DeleteOne parameter
            ObjectFilterDefinition<T> filter = new ObjectFilterDefinition<T>(item);
            // Remove the object.
            database.GetCollection<T>(typeof(T).Name).FindOneAndDelete(filter);
        }

        public void DbAddUser(User user)
        {
<<<<<<< Updated upstream
            TestingDAO();
            var document = new BsonDocument { { "Firstname", user.Firstname }, { "Lastname", user.Lastname }, { "Username", user.Username}, { "Password", user.Password}, { "PhoneNumber", user.PhoneNumber},{ "Email", user.Email} };
=======
            ConnUser();
            var document = new BsonDocument { { "Firstname", firstname }, { "Lastname", lastname }, { "Username", username}, { "Password", password}, { "PhoneNumber", phonenumber},{ "Email", email} };
>>>>>>> Stashed changes
            collection.InsertOne(document);
        }
        public async Task DbGetAllUsers()
        {
            var list = await collection.Find(new BsonDocument()).ToListAsync();
            List<User> users = new List<User>();
        }

    }

}
