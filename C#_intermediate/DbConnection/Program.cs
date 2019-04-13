using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.DbConnection
{

    class Program
    {
        static void Main(string[] args)
        {
            OracleConnection oracleCon = new OracleConnection("Connect string");
            DbCommand dbCommand = new DbCommand(oracleCon, "Oracle command string");
            dbCommand.Execute();

        }
    }
}
