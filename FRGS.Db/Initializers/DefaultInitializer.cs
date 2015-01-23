using System.Data.Entity;
using FRGS.Db.Contexts;
using FRGS.Db.Seeds;
using FRGS.Db.SeedSerializers;
using FRGS.Model;

namespace FRGS.Db.Initializers
{
    internal class DefaultInitializer : DropCreateDatabaseAlways<DefaultContext>
    {
        public DefaultInitializer()
        {
        }

        protected override void Seed(DefaultContext context)
        {
        }
    }
}