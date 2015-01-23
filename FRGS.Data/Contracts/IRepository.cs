using System.Linq;

namespace FRGS.Data.Contracts
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> All();
        T Get(long id);
        void Add(T entity);
        void Replace(T entity);
        void Remove(T entity);
    }
}
