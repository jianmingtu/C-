using System;

namespace Udemy.DbConnection
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
            Console.WriteLine("SqlConnection initialized");
        }
        public override void Open()
        {
            Console.WriteLine("sqlconnect open");
        }
        public override void Close()
        {
            Console.WriteLine("sqlconnect close");
        }
    }

}
