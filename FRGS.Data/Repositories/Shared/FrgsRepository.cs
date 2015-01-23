using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using FRGS.Data.Contracts;
using FRGS.Db.Contracts;

namespace FRGS.Data.Repositories.Shared
{
    public class FrgsRepository<T> : IRepository<T> where T : class
    {
        public FrgsRepository(IForgeSqlContext dbContext)
        {
            if (dbContext == null) 
                throw new ArgumentNullException("dbContext");
            DbContext = dbContext;
        }

        protected IForgeSqlContext DbContext { get; set; }

        protected DbSet<T> DbSet { get; set; }

        public virtual IQueryable<T> All()
        {
            return DbSet;
        }

        public virtual T Get(long id)
        {
            return DbSet.Find(id);
        }

        public virtual void Add(T entity)
        {
            DbContext.Add(DbSet, entity);
        }

        public virtual void Replace(T entity)
        {
            DbContext.Replace(DbSet, entity);
        }

        public virtual void Remove(T entity)
        {
            DbContext.Remove(DbSet, entity);
        }
    }
}
