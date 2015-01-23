using System.Data.Entity;
using FRGS.Db.Contexts;

namespace FRGS.Db.Initializers
{
    internal class ForgeSqlContextInitializer: CreateDatabaseIfNotExists<ForgeSqlContext>
    {
    }
}
