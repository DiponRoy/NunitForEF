using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace FRGS.Db.SeedSerializers
{
    class EntitySeedSerializer <TEntity> where TEntity : class 
    {
        public List<TEntity> Entities { get; set; }

        public EntitySeedSerializer()
        {
            Entities = new List<TEntity>();
        }

        protected void Seed(TEntity entity)
        {
            Entities.Add(entity);
        }

        protected void Seed(List<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                Seed(entity);
            }
        }

        public virtual void SerializeInto(DbContext context)
        {
            foreach (var aEntity in Entities)
            {
                try
                {
                    context.Set<TEntity>().Add(aEntity);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    string msg = String.Format("Error to serialize {0} seeds.", typeof(TEntity).Name);
                    throw new Exception(msg, ex);
                }
            }
        }
    }
}
