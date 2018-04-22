namespace ProMan_Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _030 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Fertigungslinies", "Fertigungstype", c => c.Int(nullable: false));
            DropColumn("dbo.Fertigungs", "Fertigungstype");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Fertigungs", "Fertigungstype", c => c.Int(nullable: false));
            DropColumn("dbo.Fertigungslinies", "Fertigungstype");
        }
    }
}
