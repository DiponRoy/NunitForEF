using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using FRGS.Data.Contracts;
using FRGS.Data.Repositories.Shared;
using FRGS.Db.Contracts;
using FRGS.Model;

namespace FRGS.Data.Repositories
{
    public class QuestionRepo : FrgsRepository<Question>, IQuestionRepo
    {

        public QuestionRepo(IForgeSqlContext context)
            : base(context)
        {
            DbSet = context.Question;
        }

        public IQueryable<Question> AllWithIncludes()
        {
            return All().Include(x => x.QuestionSet);
        }
    }
}
