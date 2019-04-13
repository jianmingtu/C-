using System;

namespace Udemy.DbConnection
{
    public class DbCommand
    {
        private readonly DbConnection _dbConnection;
        private readonly string _dbCommand;

        public DbCommand(DbConnection dbConnection, string dbCommand)
        {
            if(dbConnection == null || string.IsNullOrEmpty(dbCommand))
            {
                throw new System.InvalidOperationException("fail to instantiate a db connection");
            }
            this._dbConnection = dbConnection;
            this._dbCommand = dbCommand;
        }

        private void Run()
        {
            Console.WriteLine(_dbCommand);
        }

        public void Execute()
        {
            _dbConnection.Open();
            Run();
            _dbConnection.Close();

        }
    }
}
