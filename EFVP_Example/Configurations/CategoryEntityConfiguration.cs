using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace EFVP_Example.Configurations
{
    public class CategoryEntityConfiguration : EntityTypeConfiguration<EFVP_Example.Category>
    {
        public CategoryEntityConfiguration()
        {
            this.ToTable("Category", "dbo")
                .HasKey(c => c.categoryID);

            this.Property(c => c.categoryID)
                .HasColumnName("categoryId")
                .IsRequired();

            this.Property(c => c.CategoryName)
                .HasColumnName("category_name")
                .HasMaxLength(255);

            this.Property(c => c.Created)
                .HasColumnName("created");
        }
    }
}
