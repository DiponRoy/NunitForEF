using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FRGS.Model;

namespace FRGS.Db.Configurations
{
    class QuestionSetConfig : EntityTypeConfiguration<QuestionSet>
    {
        public QuestionSetConfig()
        {
            HasKey(x => x.Id);
            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(25);
        }
    }
}
