using System.Linq;
using FRGS.Model;

namespace FRGS.Data.Contracts
{
    public interface IQuestionSetRepo : IRepository<QuestionSet>
    {
        bool IsNameUsed(string name);
    }
}
