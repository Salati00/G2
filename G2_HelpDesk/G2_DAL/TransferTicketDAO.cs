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
    public class TransferTicketDAO : BaseDAO
    {
        public void DbTransferTicket(Ticket from, Employee to)
        {
            ObjectId fromId = new ObjectId(from._Id);
            ObjectId toId = new ObjectId(to._id);
            var filter = Builders<BsonDocument>.Filter.Eq("_id", fromId);
            var update = Builders<BsonDocument>.Update.Set("User_id", toId);
            collectionTicket.UpdateOne(filter, update);
        }
        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();
            var docs = collectionUser.Find(Builders<BsonDocument>.Filter.Empty).ToList();
            foreach (BsonDocument doc in docs)
            {
                if (!doc.Contains("Username"))
                {
                    {
                        employees.Add(GetEmployee(doc));
                    }
                }
            }
            return employees;
        }
    }
}
