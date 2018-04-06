namespace ProMan_Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _010 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Nachrichts",
                c => new
                    {
                        NachrichtID = c.Int(nullable: false, identity: true),
                        SendDate = c.DateTime(),
                        Gelesen = c.Boolean(nullable: false),
                        Betreff = c.String(maxLength: 255),
                        Text = c.String(maxLength: 450),
                        Type = c.Int(nullable: false),
                        Antwort_NachrichtID = c.Int(),
                        From_MitarbeiterID = c.Int(),
                        To_MitarbeiterID = c.Int(),
                        Mitarbeiter_MitarbeiterID = c.Int(),
                    })
                .PrimaryKey(t => t.NachrichtID)
                .ForeignKey("dbo.Nachrichts", t => t.Antwort_NachrichtID)
                .ForeignKey("dbo.Mitarbeiters", t => t.From_MitarbeiterID)
                .ForeignKey("dbo.Mitarbeiters", t => t.To_MitarbeiterID)
                .ForeignKey("dbo.Mitarbeiters", t => t.Mitarbeiter_MitarbeiterID)
                .Index(t => t.Antwort_NachrichtID)
                .Index(t => t.From_MitarbeiterID)
                .Index(t => t.To_MitarbeiterID)
                .Index(t => t.Mitarbeiter_MitarbeiterID);
            
            AddColumn("dbo.Logins", "LoginType", c => c.Int(nullable: false));
            AlterColumn("dbo.Abteilungs", "Bezeichnung", c => c.String(maxLength: 100));
            AlterColumn("dbo.Abteilungs", "Werk", c => c.String(maxLength: 100));
            AlterColumn("dbo.Abteilungs", "Ort", c => c.String(maxLength: 100));
            AlterColumn("dbo.Fertigungs", "Bezeichnung", c => c.String(maxLength: 100));
            AlterColumn("dbo.Fertigungs", "Ort", c => c.String(maxLength: 100));
            AlterColumn("dbo.Fertigungslinies", "Bezeichnung", c => c.String(maxLength: 100));
            AlterColumn("dbo.Arbeitsfolges", "ArbeitsfolgeName", c => c.String(maxLength: 450));
            AlterColumn("dbo.Bauteils", "Teilart", c => c.String(maxLength: 100));
            AlterColumn("dbo.Bauteils", "Version", c => c.String(maxLength: 100));
            AlterColumn("dbo.Bauteils", "Verwendungsort", c => c.String(maxLength: 100));
            AlterColumn("dbo.Maschines", "Inventarnummer", c => c.String(maxLength: 100));
            AlterColumn("dbo.Maschines", "Hersteller", c => c.String(maxLength: 100));
            AlterColumn("dbo.Maschines", "Version", c => c.String(maxLength: 100));
            AlterColumn("dbo.Maschines", "Zeichnungsnummer", c => c.String(maxLength: 100));
            AlterColumn("dbo.Maschines", "Standort", c => c.String(maxLength: 100));
            AlterColumn("dbo.Reparaturs", "Auftragstext", c => c.String(maxLength: 450));
            AlterColumn("dbo.Reparaturs", "Bearbeitungstext", c => c.String(maxLength: 450));
            AlterColumn("dbo.Mitarbeiters", "Vorname", c => c.String(maxLength: 50));
            AlterColumn("dbo.Mitarbeiters", "Nachname", c => c.String(maxLength: 50));
            AlterColumn("dbo.Mitarbeiters", "Festnetz", c => c.String(maxLength: 50));
            AlterColumn("dbo.Mitarbeiters", "Mobil", c => c.String(maxLength: 50));
            AlterColumn("dbo.Mitarbeiters", "eMail", c => c.String(maxLength: 50));
            AlterColumn("dbo.Mitarbeiters", "Bemerkung", c => c.String(maxLength: 255));
            AlterColumn("dbo.Logins", "Username", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Logins", "Password", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Audits", "Aufgabe", c => c.String(maxLength: 100));
            AlterColumn("dbo.Audits", "Bereich", c => c.String(maxLength: 100));
            AlterColumn("dbo.Wartungs", "Aufgabe", c => c.String(maxLength: 100));
            AlterColumn("dbo.Wartungs", "Bereich", c => c.String(maxLength: 100));
            CreateIndex("dbo.Abteilungs", "Bezeichnung", unique: true);
            CreateIndex("dbo.Arbeitsfolges", "ArbeitsfolgeName", unique: true);
            CreateIndex("dbo.Maschines", "Inventarnummer", unique: true);
            CreateIndex("dbo.Logins", "Username", unique: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Nachrichts", "Mitarbeiter_MitarbeiterID", "dbo.Mitarbeiters");
            DropForeignKey("dbo.Nachrichts", "To_MitarbeiterID", "dbo.Mitarbeiters");
            DropForeignKey("dbo.Nachrichts", "From_MitarbeiterID", "dbo.Mitarbeiters");
            DropForeignKey("dbo.Nachrichts", "Antwort_NachrichtID", "dbo.Nachrichts");
            DropIndex("dbo.Nachrichts", new[] { "Mitarbeiter_MitarbeiterID" });
            DropIndex("dbo.Nachrichts", new[] { "To_MitarbeiterID" });
            DropIndex("dbo.Nachrichts", new[] { "From_MitarbeiterID" });
            DropIndex("dbo.Nachrichts", new[] { "Antwort_NachrichtID" });
            DropIndex("dbo.Logins", new[] { "Username" });
            DropIndex("dbo.Maschines", new[] { "Inventarnummer" });
            DropIndex("dbo.Arbeitsfolges", new[] { "ArbeitsfolgeName" });
            DropIndex("dbo.Abteilungs", new[] { "Bezeichnung" });
            AlterColumn("dbo.Wartungs", "Bereich", c => c.String());
            AlterColumn("dbo.Wartungs", "Aufgabe", c => c.String());
            AlterColumn("dbo.Audits", "Bereich", c => c.String());
            AlterColumn("dbo.Audits", "Aufgabe", c => c.String());
            AlterColumn("dbo.Logins", "Password", c => c.String());
            AlterColumn("dbo.Logins", "Username", c => c.String());
            AlterColumn("dbo.Mitarbeiters", "Bemerkung", c => c.String());
            AlterColumn("dbo.Mitarbeiters", "eMail", c => c.String());
            AlterColumn("dbo.Mitarbeiters", "Mobil", c => c.String());
            AlterColumn("dbo.Mitarbeiters", "Festnetz", c => c.String());
            AlterColumn("dbo.Mitarbeiters", "Nachname", c => c.String());
            AlterColumn("dbo.Mitarbeiters", "Vorname", c => c.String());
            AlterColumn("dbo.Reparaturs", "Bearbeitungstext", c => c.String());
            AlterColumn("dbo.Reparaturs", "Auftragstext", c => c.String());
            AlterColumn("dbo.Maschines", "Standort", c => c.String());
            AlterColumn("dbo.Maschines", "Zeichnungsnummer", c => c.String());
            AlterColumn("dbo.Maschines", "Version", c => c.String());
            AlterColumn("dbo.Maschines", "Hersteller", c => c.String());
            AlterColumn("dbo.Maschines", "Inventarnummer", c => c.String());
            AlterColumn("dbo.Bauteils", "Verwendungsort", c => c.String());
            AlterColumn("dbo.Bauteils", "Version", c => c.String());
            AlterColumn("dbo.Bauteils", "Teilart", c => c.String());
            AlterColumn("dbo.Arbeitsfolges", "ArbeitsfolgeName", c => c.String());
            AlterColumn("dbo.Fertigungslinies", "Bezeichnung", c => c.String());
            AlterColumn("dbo.Fertigungs", "Ort", c => c.String());
            AlterColumn("dbo.Fertigungs", "Bezeichnung", c => c.String());
            AlterColumn("dbo.Abteilungs", "Ort", c => c.String());
            AlterColumn("dbo.Abteilungs", "Werk", c => c.String());
            AlterColumn("dbo.Abteilungs", "Bezeichnung", c => c.String());
            DropColumn("dbo.Logins", "LoginType");
            DropTable("dbo.Nachrichts");
        }
    }
}
