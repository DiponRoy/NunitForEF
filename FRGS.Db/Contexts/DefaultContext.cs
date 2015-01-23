using System.Data.Entity;
using FRGS.Db.Contexts.Shared;
using FRGS.Db.Initializers;

namespace FRGS.Db.Contexts
{
    class DefaultContext : Context
    {
        public DefaultContext(string connectionStringName)
            : base(connectionStringName)
        {

        }

        static DefaultContext()
        {
            Database.SetInitializer(new DefaultInitializer());
        }
    }
}
