using System.Data.Entity;
using FRGS.Db.Contexts.Shared;
using FRGS.Db.Initializers;

namespace FRGS.Db.Contexts
{
    class SeededContext : Context
    {
        public SeededContext(string connectionStringName)
            : base(connectionStringName)
        {

        }

        static SeededContext()
        {
            Database.SetInitializer(new SeededInitializer());
        }
    }
}
