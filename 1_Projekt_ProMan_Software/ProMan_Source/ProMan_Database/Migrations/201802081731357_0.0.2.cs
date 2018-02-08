namespace ProMan_Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _002 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Abteilungs", "Name", c => c.String());
            AddColumn("dbo.Fertigungs", "Name", c => c.String());
            AddColumn("dbo.Fertigungslinies", "Name", c => c.String());
            DropColumn("dbo.Fertigungs", "InventarID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Fertigungs", "InventarID", c => c.Int(nullable: false));
            DropColumn("dbo.Fertigungslinies", "Name");
            DropColumn("dbo.Fertigungs", "Name");
            DropColumn("dbo.Abteilungs", "Name");
        }
    }
}
