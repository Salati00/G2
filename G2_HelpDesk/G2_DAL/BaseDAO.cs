using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace G2_DAL
{
    public class BaseDAO
    {
        MongoClient client;
        IMongoDatabase database;

        public void TestingDAO()
        {
            client = new MongoClient("mongodb+srv://dbUser:noww6w4agyqOhr4s@g2.kxnnm.azure.mongodb.net/g2Database?retryWrites=true&w=majority");
            database = client.GetDatabase("g2Database");
            IMongoCollection<BsonDocument> collection = database.GetCollection<BsonDocument>("Users");
        }

    }

}
