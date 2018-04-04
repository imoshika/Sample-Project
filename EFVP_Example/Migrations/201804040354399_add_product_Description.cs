namespace EFVP_Example.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_product_Description : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.product", "Description", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.product", "Description");
        }
    }
}
