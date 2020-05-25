using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Luxorna.Entities
{
    public class SectionConfiguration:EntityTypeConfiguration<Section>
    {
        public SectionConfiguration()
        {
            ToTable("Section");
            HasMany(i => i.Hotels)
                .WithRequired(i => i.Section)
                .HasForeignKey(i => i.SectionID);
            HasMany(i => i.Temples)
               .WithRequired(i => i.Section)
               .HasForeignKey(i => i.SectionID);
            HasMany(i => i.Museums)
               .WithRequired(i => i.Section)
               .HasForeignKey(i => i.SectionID);
            HasMany(i => i.Resturants)
               .WithRequired(i => i.Section)
               .HasForeignKey(i => i.SectionID);

        }
    }
}
