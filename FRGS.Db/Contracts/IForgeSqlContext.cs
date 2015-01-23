using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FRGS.Model;

namespace FRGS.Db.Contracts
{
    public interface IForgeSqlContext : IDisposable
    {
        DbSet<QuestionSet> QuestionSet { get; set; }
        DbSet<Question> Question { get; set; }

        void Add<TSource>(DbSet<TSource> dbSet, TSource entity) where TSource : class;
        void Replace<TSource>(DbSet<TSource> dbSet, TSource entity) where TSource : class;
        void Remove<TSource>(DbSet<TSource> dbSet, TSource entity) where TSource : class;
        int SaveChanges();
    }
}
