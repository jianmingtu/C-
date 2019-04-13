using System;

namespace Udemy.DbConnection
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
            Console.WriteLine("OracleConnection initialized");
        }
        public override void Open()
        {
            Console.WriteLine("OracleConnection open");
        }
        public override void Close()
        {
            Console.WriteLine("OracleConnection close");
        }
    }

}
