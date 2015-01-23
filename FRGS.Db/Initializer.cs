using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FRGS.Db.Contexts;
using FRGS.Db.Contexts.Shared;

namespace FRGS.Db
{
    public class Initializer
    {

        private void LoadTables(Context context)
        {
            context.QuestionSet.ToList();
        }

        public void InitializSeededDb()
        {
            using (var db = new SeededContext("DbFRGS"))
            {
                LoadTables(db);
            }
        }

        public void InitializDefaultDb()
        {
            using (var db = new DefaultContext("DbFRGS"))
            {
                LoadTables(db);
            }
        }
    }
}
