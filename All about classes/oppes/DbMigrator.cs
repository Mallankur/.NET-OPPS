using System;
using System.Runtime.CompilerServices;

namespace oppes
{

    public class DbMigrator
    {
       private readonly ILogger _logger;
        public DbMigrator(ILogger logger)
        {
            _logger = logger;
            
        }
        public void Migrate()
        {
            _logger.LogInfo("migration started time is  ........." + DateTime.Now);
           // Console.WriteLine ("migration started time is  ........." + DateTime.Now);

            _logger.LogInfo("migration finshied  time is  ........." + DateTime.Now);
            // Detils of migrating the database
            //Console.WriteLine ("migration finished is  ........." + DateTime.Now);
        }
    }
   

}
