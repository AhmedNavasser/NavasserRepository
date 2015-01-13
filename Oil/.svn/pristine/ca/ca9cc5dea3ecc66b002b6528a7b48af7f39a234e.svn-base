using System.Data.Entity;
using OilContext;
using OilContext.Migrations;

namespace Client
{
    class Migrations
    {
        public static void Migrate()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<OilDbContext,Configuration>());
        }
    }
}
