namespace ProMan_Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _020 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Werks",
                c => new
                    {
                        WerkID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Adresse = c.String(),
                        Postleitzahl = c.Int(nullable: false),
                        Ort = c.String(),
                    })
                .PrimaryKey(t => t.WerkID);
            
            AddColumn("dbo.Abteilungs", "Werk_WerkID", c => c.Int());
            AddColumn("dbo.Bauteils", "NachfolderId", c => c.Int(nullable: false));
            AddColumn("dbo.Bauteils", "Index", c => c.String());
            AddColumn("dbo.Bauteils", "Status", c => c.String());
            AddColumn("dbo.Bauteils", "Nummer", c => c.String());
            AddColumn("dbo.Mitarbeiters", "Abteilung_AbteilungID", c => c.Int());
            AddColumn("dbo.Logins", "UserStatus", c => c.Int(nullable: false));
            AddColumn("dbo.Nachrichts", "NachrichtenStatus", c => c.Int(nullable: false));
            AddColumn("dbo.Audits", "Bewertung", c => c.String());
            AddColumn("dbo.Audits", "Turnus", c => c.Int(nullable: false));
            AddColumn("dbo.Audits", "Status", c => c.Int(nullable: false));
            AddColumn("dbo.Audits", "AuditArt", c => c.String());
            AddColumn("dbo.Audits", "Abteilung_AbteilungID", c => c.Int());
            AddColumn("dbo.Wartungs", "Status", c => c.Int(nullable: false));
            AddColumn("dbo.Wartungs", "Turnus", c => c.Int(nullable: false));
            CreateIndex("dbo.Abteilungs", "Werk_WerkID");
            CreateIndex("dbo.Mitarbeiters", "Abteilung_AbteilungID");
            CreateIndex("dbo.Audits", "Abteilung_AbteilungID");
            AddForeignKey("dbo.Mitarbeiters", "Abteilung_AbteilungID", "dbo.Abteilungs", "AbteilungID");
            AddForeignKey("dbo.Audits", "Abteilung_AbteilungID", "dbo.Abteilungs", "AbteilungID");
            AddForeignKey("dbo.Abteilungs", "Werk_WerkID", "dbo.Werks", "WerkID");
            DropColumn("dbo.Abteilungs", "Werk");
            DropColumn("dbo.Nachrichts", "Gelesen");
            DropColumn("dbo.Audits", "Abschlussnote");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Audits", "Abschlussnote", c => c.Int(nullable: false));
            AddColumn("dbo.Nachrichts", "Gelesen", c => c.Boolean(nullable: false));
            AddColumn("dbo.Abteilungs", "Werk", c => c.String(maxLength: 100));
            DropForeignKey("dbo.Abteilungs", "Werk_WerkID", "dbo.Werks");
            DropForeignKey("dbo.Audits", "Abteilung_AbteilungID", "dbo.Abteilungs");
            DropForeignKey("dbo.Mitarbeiters", "Abteilung_AbteilungID", "dbo.Abteilungs");
            DropIndex("dbo.Audits", new[] { "Abteilung_AbteilungID" });
            DropIndex("dbo.Mitarbeiters", new[] { "Abteilung_AbteilungID" });
            DropIndex("dbo.Abteilungs", new[] { "Werk_WerkID" });
            DropColumn("dbo.Wartungs", "Turnus");
            DropColumn("dbo.Wartungs", "Status");
            DropColumn("dbo.Audits", "Abteilung_AbteilungID");
            DropColumn("dbo.Audits", "AuditArt");
            DropColumn("dbo.Audits", "Status");
            DropColumn("dbo.Audits", "Turnus");
            DropColumn("dbo.Audits", "Bewertung");
            DropColumn("dbo.Nachrichts", "NachrichtenStatus");
            DropColumn("dbo.Logins", "UserStatus");
            DropColumn("dbo.Mitarbeiters", "Abteilung_AbteilungID");
            DropColumn("dbo.Bauteils", "Nummer");
            DropColumn("dbo.Bauteils", "Status");
            DropColumn("dbo.Bauteils", "Index");
            DropColumn("dbo.Bauteils", "NachfolderId");
            DropColumn("dbo.Abteilungs", "Werk_WerkID");
            DropTable("dbo.Werks");
        }
    }
}
