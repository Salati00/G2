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
    public class IncidentDAO : BaseDAO
    {
        public void DbAddIncident(Incident incident)
        {
            var document = new BsonDocument {
                { "ReportDate", incident.ReportDate },
                { "Subject", incident.Subject },
                { "Type", incident.Type},
                { "Priority", incident.Priority},
                { "Description", incident.Description},
                { "User_id", incident.user._id} };
            collectionUser.InsertOne(document);
        }
    }
}
