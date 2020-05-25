using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Luxorna.Entities
{
   public  class ResturantPackageMenuItemConfiguration:EntityTypeConfiguration<ResturantPackageMenuItem>
    {
        public ResturantPackageMenuItemConfiguration()
        {
            ToTable("ResturantPackageMenuItem");
            HasRequired(i => i.ResturantMenuItem)
                .WithMany(i => i.ResturantPackageMenuItems)
                .HasForeignKey(i => i.ResturantMenuItemID);
            HasRequired(i => i.ResturantPacakge)
                .WithMany(i => i.ResturantPackageMenuItems)
                .HasForeignKey(i => i.ResturantPackageID);
        }
    }
}
