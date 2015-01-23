using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FRGS.Model.Contracts;
using FRGS.Model.Contracts.Shared;

namespace FRGS.Model
{
    public class Question : IPrimaryKey
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public long QuestionSetId { get; set; }

        public virtual QuestionSet QuestionSet { get; set; }
    }
}
