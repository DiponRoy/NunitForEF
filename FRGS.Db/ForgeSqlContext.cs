using System.Data.Entity;
using FRGS.Db.Contexts.Shared;
using FRGS.Db.Initializers;

namespace FRGS.Db
{
    public class ForgeSqlContext : Context
    {
        public ForgeSqlContext() : base(nameOrConnectionString: "DbFRGS")
        {

        }

        static ForgeSqlContext()
        {
            Database.SetInitializer(new ForgeSqlContextInitializer());
        }
    }
}
