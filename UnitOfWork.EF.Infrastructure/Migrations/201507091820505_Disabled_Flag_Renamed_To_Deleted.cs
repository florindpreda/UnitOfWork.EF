namespace UnitOfWork.EF.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Disabled_Flag_Renamed_To_Deleted : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductReviews", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Products", "IsDeleted", c => c.Boolean(nullable: false));
            DropColumn("dbo.ProductReviews", "IsDisabled");
            DropColumn("dbo.Products", "IsDisabled");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "IsDisabled", c => c.Boolean(nullable: false));
            AddColumn("dbo.ProductReviews", "IsDisabled", c => c.Boolean(nullable: false));
            DropColumn("dbo.Products", "IsDeleted");
            DropColumn("dbo.ProductReviews", "IsDeleted");
        }
    }
}
