using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Luxorna.Entities
{
    public class ResturantMenuItemConfiguration:EntityTypeConfiguration<ResturantMenuItem>
    {
        public ResturantMenuItemConfiguration()
        {
            ToTable("ResturantMenuItem");
            Property(i => i.ItemName)
                .HasMaxLength(500)
                .IsRequired();
            Property(i => i.Image)
               .HasMaxLength(500)
               .IsRequired();

            HasRequired(i => i.Resturant)
                .WithMany(i => i.ResturantMenuItems)
                .HasForeignKey(i => i.RestrantID);

            HasMany(i => i.ResturantItemSizes)
               .WithRequired(i => i.ResturantMenuItem)
               .HasForeignKey(I => I.ResturantMenuItemID);

            HasMany(i => i.ResturantPackageMenuItems)
               .WithRequired(i => i.ResturantMenuItem)
               .HasForeignKey(i => i.ResturantMenuItemID);

        }
    }
}
