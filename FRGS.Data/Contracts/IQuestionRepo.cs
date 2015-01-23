using System.Linq;
using FRGS.Model;

namespace FRGS.Data.Contracts
{
    public interface IQuestionRepo : IRepository<Question>
    {
        IQueryable<Question> AllWithIncludes();
    }
}
