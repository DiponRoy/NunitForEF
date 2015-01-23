using System.Data.Entity;
using FRGS.Db.Contexts;
using FRGS.Db.Seeds;
using FRGS.Db.SeedSerializers;
using FRGS.Model;

namespace FRGS.Db.Initializers
{
    internal class SeededInitializer : DropCreateDatabaseAlways<SeededContext>
    {
        private DbSeedSerializer _dbSeedSerializer;

        public SeededInitializer()
        {
        }

        protected override void Seed(SeededContext context)
        {
            _dbSeedSerializer = new DbSeedSerializer(context);

            _dbSeedSerializer.Serialize(new QuestionSetSeed());
        }
    }
}