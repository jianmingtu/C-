using System;


namespace Udemy.DbConnection
{
    public abstract class DbConnection
    {
        protected readonly string _connectionString;
        protected TimeSpan _timeOut = TimeSpan.FromSeconds(30);

        public DbConnection(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString) || string.IsNullOrWhiteSpace(connectionString))
            {
                throw new InvalidOperationException("Invalid DBConnection");
            }

            _connectionString = connectionString;
            _timeOut = TimeSpan.Zero;
        }

        public abstract void Open();
        public abstract void Close();
    }

}
