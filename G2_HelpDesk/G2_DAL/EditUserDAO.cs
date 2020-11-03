using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G2_Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace G2_DAL
{
    public class EditUserDAO : BaseDAO
    {
        public void DbUpdateEmployee(Person person)
        {
            ObjectId id = new ObjectId(person._id);
            var filter = Builders<BsonDocument>.Filter.Eq("_id", id);
            var update = Builders<BsonDocument>.Update.Set("Firstname", person.Firstname)
                                                      .Set("Lastname", person.Lastname)
                                                      .Set("PhoneNumber", person.PhoneNumber)
                                                      .Set("Email", person.Email);
            collectionUser.UpdateOne(filter,update);
        }

        public void DbUpdateAdmin(Admin admin)
        {
            ObjectId id = new ObjectId(admin._id);
            var filter = Builders<BsonDocument>.Filter.Eq("_id", id);
            var update = Builders<BsonDocument>.Update.Set("Firstname", admin.Firstname)
                                                      .Set("Lastname", admin.Lastname)
                                                      .Set("Username",admin.Username)
                                                      .Set("PhoneNumber", admin.PhoneNumber)
                                                      .Set("Email", admin.Email);
            collectionUser.UpdateOne(filter, update);

            if(admin.Password != null)
            {
                var pass = Builders<BsonDocument>.Update.Set("Password", admin.Password);
                collectionUser.UpdateOne(filter, update);
            }
        }

        public void DeletePerson(Person person)
        {
            ObjectId id = new ObjectId(person._id);
            var deletePerson = Builders<BsonDocument>.Filter.Eq("_id", id);
            var deleteTickets = Builders<BsonDocument>.Filter.Eq("User_id", id);
            collectionUser.DeleteOne(deletePerson);
            collectionTicket.DeleteMany(deleteTickets);
        }
    }
}
