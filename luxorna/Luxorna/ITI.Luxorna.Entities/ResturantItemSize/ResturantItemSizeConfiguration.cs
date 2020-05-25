using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Luxorna.Entities
{
    public class ResturantItemSizeConfiguration:EntityTypeConfiguration<ResturantItemSize>
    {
        public ResturantItemSizeConfiguration()
        {
            ToTable("ResturantItemSize");
            Property(i => i.Price)
                .IsRequired();
            HasRequired(i => i.ResturantMenuItem)
                .WithMany(i => i.ResturantItemSizes)
                .HasForeignKey(i => i.ResturantMenuItemID);
            HasRequired(i => i.Size)
               .WithMany(i => i.ResturantItemSizes)
               .HasForeignKey(i => i.SizeID);



        }
    }
}
