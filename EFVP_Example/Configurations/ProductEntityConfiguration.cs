using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace EFVP_Example.Configurations
{
    public class ProductEntityConfiguration : EntityTypeConfiguration<EFVP_Example.product>
    {
        public ProductEntityConfiguration()
        {
            this.ToTable("product", "dbo")
                .HasKey(p => p.ProductId);

            this.Property(p => p.ProductId)
                .HasColumnName("product_Id")
                .IsRequired();

            this.Property(p => p.ProductName)
                .HasColumnName("product_name")
                .HasMaxLength(255);

            this.Property(p => p.Created)
                .HasColumnName("created");

        }
    }
}
