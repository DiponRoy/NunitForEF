using System.Data.Entity;

namespace FRGS.Db.SeedSerializers
{
    internal class DbSeedSerializer
    {
        public readonly DbContext Context;

        public DbSeedSerializer()
        {
            
        }

        public DbSeedSerializer(DbContext context)
        {
            Context = context;
        }

        public void Serialize<TEntity>(DbContext context, EntitySeedSerializer<TEntity> entitySeedSerializer) where TEntity : class 
        {
            entitySeedSerializer.SerializeInto(context);
        }

        public void Serialize<TEntity>(EntitySeedSerializer<TEntity> entitySeedSerializer) where TEntity : class
        {
            entitySeedSerializer.SerializeInto(Context);
        }
    }
}
