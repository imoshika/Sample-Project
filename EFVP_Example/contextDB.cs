namespace EFVP_Example
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using EFVP_Example.Configurations;

    public partial class contextDB : DbContext
    {
        public contextDB()
            : base("name=DbContext")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<specification> specifications { get; set; }
        public virtual DbSet<Specification_Type> Specification_Type { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /*modelBuilder.Entity<Category>()
                .HasMany(e => e.products)
                .WithMany(e => e.Categories)
                .Map(m => m.ToTable("product_to_category").MapLeftKey("categoryId").MapRightKey("product_Id"));

            modelBuilder.Entity<product>()
                .HasMany(e => e.Vendors)
                .WithMany(e => e.products)
                .Map(m => m.ToTable("product_to_vendor").MapLeftKey("product_Id").MapRightKey("vendor_Id"));

            modelBuilder.Entity<Specification_Type>()
                .HasMany(e => e.specifications)
                .WithRequired(e => e.Specification_Type)
                .WillCascadeOnDelete(false);*/

            modelBuilder.Configurations.Add(new ProductEntityConfiguration());
            modelBuilder.Configurations.Add(new CategoryEntityConfiguration());
            modelBuilder.Configurations.Add(new VendorEntityConfiguration());

        }
    }
}
