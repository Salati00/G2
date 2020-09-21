using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace G2_DAL
{
    public class BaseDAO
    {
        public void TestingDAO()
        {
            var client = new MongoClient("mongodb+srv://dbUser:noww6w4agyqOhr4s@g2.kxnnm.azure.mongodb.net/g2Database?retryWrites=true&w=majority");
            var database = client.GetDatabase("g2Database");

            
        }
    }
}
