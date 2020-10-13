﻿using System;
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
        IMongoClient client;
        IMongoDatabase database;
        IMongoCollection<BsonDocument> collection;
        public void TestingDAO()
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

        public void DbAddUser(string name, string surname)
        {
            TestingDAO();
            var document = new BsonDocument { { "Name", name }, { "Surname", surname } };
            collection.InsertOne(document);
        }

    }

}