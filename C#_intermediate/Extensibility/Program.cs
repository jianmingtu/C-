using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensibility
{

    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DBMigrator(new ConsoleLogger());
            dbMigrator.Migrate();

            // write to \debug\log.txt
            // Log info: Migrating start4/13/2019 6:05:13 PM
            // Log info: Migrating finish4/ 13 / 2019 6:05:13 PM
                           dbMigrator = new DBMigrator(new FileLogger(".\\log.txt"));
            dbMigrator.Migrate();

        }
    }
}
