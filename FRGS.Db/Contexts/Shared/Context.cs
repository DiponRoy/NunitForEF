using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using FRGS.Db.Configurations;
using FRGS.Db.Contracts;
using FRGS.Model;

namespace FRGS.Db.Contexts.Shared
{
    public class Context : DbContext, IForgeSqlContext
    {
        public DbSet<QuestionSet> QuestionSet { get; set; }
        public DbSet<Question> Question { get; set; }


        public void Add<TSource>(DbSet<TSource> dbSet, TSource entity) where TSource : class
        {
            DbEntityEntry dbEntityEntry = Entry(entity);
            if (dbEntityEntry.State != EntityState.Detached)
            {
                dbEntityEntry.State = EntityState.Added;
            }
            else
            {
                dbSet.Add(entity);
            }
        }

        public void Replace<TSource>(DbSet<TSource> dbSet, TSource entity) where TSource : class
        {
            DbEntityEntry dbEntityEntry = Entry(entity);
            if (dbEntityEntry.State == EntityState.Detached)
            {
                dbSet.Attach(entity);
            }
            dbEntityEntry.State = EntityState.Modified;
        }

        public void Remove<TSource>(DbSet<TSource> dbSet, TSource entity) where TSource : class
        {
            DbEntityEntry dbEntityEntry = Entry(entity);
            if (dbEntityEntry.State != EntityState.Deleted)
            {
                dbEntityEntry.State = EntityState.Deleted;
            }
            else
            {
                dbSet.Attach(entity);
                dbSet.Remove(entity);
            }
        }

        protected Context(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new QuestionSetConfig());
            modelBuilder.Configurations.Add(new QuestionConfig());
        }
    }
}
