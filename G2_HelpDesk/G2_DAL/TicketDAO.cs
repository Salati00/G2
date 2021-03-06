﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using G2_Model;

namespace G2_DAL
{
    public class TicketDAO : BaseDAO
    {
        public void DbAddTicket(Ticket ticket)
        {
            var document = new BsonDocument {
                { "ReportDate", ticket.ReportDate },
                { "Subject", ticket.Subject },
                { "Type", ticket.Type},
                { "Priority", ticket.Priority},
                { "Description", ticket.Description},
                { "Deadline", ticket.Deadline},
                { "User_id", ObjectId.Parse(ticket.User._id)} };
            collectionTicket.InsertOne(document);
        }
        public List<Ticket> DbGetAllTickets()
        {
            List<Ticket> tickets = new List<Ticket>();
            Ticket ticket;
            var aggregate = new BsonDocument { { "$lookup", new BsonDocument { { "from", "Users" }, { "localField", "User_id" }, { "foreignField", "_id" }, { "as", "User" } } } };
            var pipeline = new[] { aggregate };
            var result = collectionTicket.Aggregate<BsonDocument>(pipeline).ToList(); ;
            foreach (BsonDocument doc in result)
            {
                //Person user = new Person();
                Person user = new Employee();
                BsonArray userDocs = doc.GetValue("User").AsBsonArray;
                foreach (BsonDocument userDoc in userDocs)
                {
                    user = GetEmployee(userDoc);
                }
                ticket = new Ticket(
                    doc.GetValue("_id", new BsonString(string.Empty)).ToString(),
                    (DateTime)(doc.GetValue("ReportDate", new BsonString(string.Empty))),
                    doc.GetValue("Subject", new BsonString(string.Empty)).ToString(),
                    (TicketTypes)(doc.GetValue("Type", new BsonString(string.Empty)).ToInt32()),
                    (TicketPriority)(doc.GetValue("Priority", new BsonString(string.Empty)).ToInt32()),
                    doc.GetValue("Description", new BsonString(string.Empty)).ToString(),
                    user,
                    (DateTime)(doc.GetValue("Deadline", new BsonString(string.Empty))));
                tickets.Add(ticket);
            }
            return tickets;
        }
        public void DeleteTicket(Ticket ticket) //not tested
        {
            var deleteFilter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(ticket._Id));
            collectionTicket.DeleteOne(deleteFilter);
        }

        public void DbUpdateTicket(Ticket ticket)
        {
            ObjectId Id = new ObjectId(ticket._Id);
            var filter = Builders<BsonDocument>.Filter.Eq("_id", Id);
            var update = Builders<BsonDocument>.Update.Set("ReportDate", ticket.ReportDate)
                                                      .Set("Subject", ticket.Subject)
                                                      .Set("Type", ticket.Type)
                                                      .Set("Priority", ticket.Priority)
                                                      .Set("Description", ticket.Description)
                                                      .Set("Deadline", ticket.Deadline)
                                                      .Set("User_id", ObjectId.Parse(ticket.User._id));

            collectionTicket.UpdateOne(filter, update);
        }
    }
}
