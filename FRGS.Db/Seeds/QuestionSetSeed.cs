using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FRGS.Db.SeedSerializers;
using FRGS.Model;

namespace FRGS.Db.Seeds
{
    class QuestionSetSeed : EntitySeedSerializer<QuestionSet>
    {
        public QuestionSetSeed()
        {
            List<QuestionSet> list = new List<QuestionSet>()
            {
                new QuestionSet(){Name = "Practice Problems"}
            };
            Seed(list);
        }
    }
}
