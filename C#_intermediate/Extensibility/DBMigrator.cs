using System;

namespace Extensibility
{
    // DbMigrator does not care who is the actual logger (console or file or db)
    public class DBMigrator
    {
        private readonly ILogger _logger;

        public DBMigrator(ILogger logger)
        {
            this._logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo($"Migrating start{DateTime.Now}");
            _logger.LogInfo($"Migrating finish{DateTime.Now}");
        }
    }
}
