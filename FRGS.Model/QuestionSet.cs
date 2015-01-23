using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FRGS.Model.Contracts;
using FRGS.Model.Contracts.Shared;

namespace FRGS.Model
{
    public class QuestionSet : IPrimaryKey
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Question> Questions { get; set; } 
    }
}
