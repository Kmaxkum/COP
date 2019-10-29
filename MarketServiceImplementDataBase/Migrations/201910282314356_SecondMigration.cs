namespace MarketServiceImplementDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Sum", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Sum", c => c.Decimal(precision: 18, scale: 2));
        }
    }
}
