using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Luxorna.Entities
{
    public class AdminConfiguration:EntityTypeConfiguration<Admin>
    {
        public AdminConfiguration()
        {
            ToTable("Admin");
            Property(i => i.CreateBy)
                .IsRequired();
            Property(i => i.UpdateBy)
                .IsOptional();
            //Property(i=>i.AdminID)
            HasRequired(i => i.admin)
            .WithMany(i => i.Admins)
            .HasForeignKey(i => i.AdminID);
            HasMany(i => i.AdminRoles)
               .WithRequired(i => i.Admin)
               .HasForeignKey(i => i.AdminID);



        }
    }
}
