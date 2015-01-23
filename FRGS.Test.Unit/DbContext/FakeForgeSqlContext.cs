using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using FRGS.Db.Contracts;
using FRGS.Model;

namespace FRGS.Test.Unit.DbContext
{
    class FakeForgeSqlContext : IForgeSqlContext
    {
        public DbSet<QuestionSet> QuestionSet { get; set; }
        public DbSet<Question> Question { get; set; }


        public void Add<TSource>(DbSet<TSource> dbSet, TSource entity) where TSource : class
        {
            dbSet.Add(entity);
        }

        public void Replace<TSource>(DbSet<TSource> dbSet, TSource entity) where TSource : class
        {
        }

        public void Remove<TSource>(DbSet<TSource> dbSet, TSource entity) where TSource : class
        {
            dbSet.Remove(entity);
        }

        public int SaveChanges()
        {
            return 1;
        }

        public void Dispose()
        {
        }
    }
}
