using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace EFVP_Example.Configurations
{
    public class VendorEntityConfiguration : EntityTypeConfiguration<EFVP_Example.Vendor>
    {
        public VendorEntityConfiguration()
        {
            this.ToTable("Vendor", "dbo")
                .HasKey(v => v.VendorID);

            this.Property(v => v.VendorID)
                .HasColumnName("vendor_Id")
                .IsRequired();

            this.Property(v => v.VendorName)
                .HasColumnName("vendor_name")
                .HasMaxLength(200);

            this.Property(v => v.Created)
                .HasColumnName("created");
        }
    }
}
