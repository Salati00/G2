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
        protected IMongoClient client;
        protected IMongoDatabase database;
        protected IMongoCollection<BsonDocument> collectionUser;
        protected IMongoCollection<BsonDocument> collectionIncident;
        public void ConnUser()
        {
            client = new MongoClient("mongodb+srv://dbUser:noww6w4agyqOhr4s@g2.kxnnm.azure.mongodb.net/g2Database?retryWrites=true&w=majority");
            database = client.GetDatabase("g2Database");
            collectionUser = database.GetCollection<BsonDocument>("Users");
            collectionIncident = database.GetCollection<BsonDocument>("Incidents");
        }
    }
}
