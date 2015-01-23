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
    public class QuestionSetRepo : FrgsRepository<QuestionSet>, IQuestionSetRepo
    {

        public QuestionSetRepo(IForgeSqlContext context)
            : base(context)
        {
            DbSet = context.QuestionSet;
        }

        public bool IsNameUsed(string name)
        {
            return All().Any(x => x.Name.Equals(name));
        }
    }
}
