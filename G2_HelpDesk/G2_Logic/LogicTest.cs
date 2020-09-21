using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G2_DAL;

namespace G2_Logic
{
    public class LogicTest
    {
        BaseDAO testdb = new BaseDAO();

        public void GetDbList()
        {
            testdb.TestingDAO();
        }
    }
}
