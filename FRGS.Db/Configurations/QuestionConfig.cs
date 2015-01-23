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
    class QuestionConfig : EntityTypeConfiguration<Question>
    {
        public QuestionConfig()
        {
            HasKey(x => x.Id);
            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(250);

            HasRequired(x => x.QuestionSet)
                .WithMany(l => l.Questions)
                .HasForeignKey(x => x.QuestionSetId)
                .WillCascadeOnDelete(true);
        }
    }
}
