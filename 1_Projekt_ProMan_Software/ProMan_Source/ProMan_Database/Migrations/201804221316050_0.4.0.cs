namespace ProMan_Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _040 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Arbeitsfolges", "Order", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Arbeitsfolges", "Order");
        }
    }
}
