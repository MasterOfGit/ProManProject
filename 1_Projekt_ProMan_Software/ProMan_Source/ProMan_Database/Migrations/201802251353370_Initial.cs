namespace ProMan_Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abteilungs",
                c => new
                    {
                        AbteilungID = c.Int(nullable: false, identity: true),
                        Bezeichnung = c.String(),
                        Werk = c.String(),
                        Ort = c.String(),
                    })
                .PrimaryKey(t => t.AbteilungID);
            
            CreateTable(
                "dbo.Fertigungs",
                c => new
                    {
                        FertigungID = c.Int(nullable: false, identity: true),
                        Bezeichnung = c.String(),
                        Ort = c.String(),
                        Fertigungstype = c.Int(nullable: false),
                        Abteilung_AbteilungID = c.Int(),
                    })
                .PrimaryKey(t => t.FertigungID)
                .ForeignKey("dbo.Abteilungs", t => t.Abteilung_AbteilungID)
                .Index(t => t.Abteilung_AbteilungID);
            
            CreateTable(
                "dbo.Fertigungslinies",
                c => new
                    {
                        FertigungslinieID = c.Int(nullable: false, identity: true),
                        Bezeichnung = c.String(),
                        Fertigung_FertigungID = c.Int(),
                    })
                .PrimaryKey(t => t.FertigungslinieID)
                .ForeignKey("dbo.Fertigungs", t => t.Fertigung_FertigungID)
                .Index(t => t.Fertigung_FertigungID);
            
            CreateTable(
                "dbo.Arbeitsfolges",
                c => new
                    {
                        ArbeitsfolgeID = c.Int(nullable: false, identity: true),
                        ArbeitsfolgeName = c.String(),
                        Arbeitsplaene = c.String(),
                        Status = c.Int(nullable: false),
                        Fertigungslinie_FertigungslinieID = c.Int(),
                    })
                .PrimaryKey(t => t.ArbeitsfolgeID)
                .ForeignKey("dbo.Fertigungslinies", t => t.Fertigungslinie_FertigungslinieID)
                .Index(t => t.Fertigungslinie_FertigungslinieID);
            
            CreateTable(
                "dbo.Bauteils",
                c => new
                    {
                        BauteilID = c.Int(nullable: false, identity: true),
                        Teilart = c.String(),
                        Version = c.String(),
                        Verwendungsort = c.String(),
                        Bauteil_BauteilID = c.Int(),
                        Arbeitsfolge_ArbeitsfolgeID = c.Int(),
                    })
                .PrimaryKey(t => t.BauteilID)
                .ForeignKey("dbo.Bauteils", t => t.Bauteil_BauteilID)
                .ForeignKey("dbo.Arbeitsfolges", t => t.Arbeitsfolge_ArbeitsfolgeID)
                .Index(t => t.Bauteil_BauteilID)
                .Index(t => t.Arbeitsfolge_ArbeitsfolgeID);
            
            CreateTable(
                "dbo.Maschines",
                c => new
                    {
                        MaschineID = c.Int(nullable: false, identity: true),
                        Inventarnummer = c.String(),
                        Technologie = c.Int(nullable: false),
                        Hersteller = c.String(),
                        Status = c.Int(nullable: false),
                        Version = c.String(),
                        Zeichnungsnummer = c.String(),
                        Standort = c.String(),
                        Anschaffungsdatum = c.DateTime(),
                        Garantie = c.DateTime(),
                        Bild_EFImageID = c.Int(),
                        Arbeitsfolge_ArbeitsfolgeID = c.Int(),
                        Reparatur_ReparaturID = c.Int(),
                    })
                .PrimaryKey(t => t.MaschineID)
                .ForeignKey("dbo.EFImages", t => t.Bild_EFImageID)
                .ForeignKey("dbo.Arbeitsfolges", t => t.Arbeitsfolge_ArbeitsfolgeID)
                .ForeignKey("dbo.Reparaturs", t => t.Reparatur_ReparaturID)
                .Index(t => t.Bild_EFImageID)
                .Index(t => t.Arbeitsfolge_ArbeitsfolgeID)
                .Index(t => t.Reparatur_ReparaturID);
            
            CreateTable(
                "dbo.EFImages",
                c => new
                    {
                        EFImageID = c.Int(nullable: false, identity: true),
                        Image = c.Binary(),
                    })
                .PrimaryKey(t => t.EFImageID);
            
            CreateTable(
                "dbo.Arbeitsplatzs",
                c => new
                    {
                        ArbeitsplatzID = c.Int(nullable: false, identity: true),
                        MitarbeiterID = c.Int(nullable: false),
                        Fertigungslinie_FertigungslinieID = c.Int(),
                    })
                .PrimaryKey(t => t.ArbeitsplatzID)
                .ForeignKey("dbo.Fertigungslinies", t => t.Fertigungslinie_FertigungslinieID)
                .Index(t => t.Fertigungslinie_FertigungslinieID);
            
            CreateTable(
                "dbo.Supermarkts",
                c => new
                    {
                        SupermarktID = c.Int(nullable: false, identity: true),
                        Iststueckzahl = c.Int(nullable: false),
                        Bauteil_BauteilID = c.Int(),
                        Fertigungslinie_FertigungslinieID = c.Int(),
                    })
                .PrimaryKey(t => t.SupermarktID)
                .ForeignKey("dbo.Bauteils", t => t.Bauteil_BauteilID)
                .ForeignKey("dbo.Fertigungslinies", t => t.Fertigungslinie_FertigungslinieID)
                .Index(t => t.Bauteil_BauteilID)
                .Index(t => t.Fertigungslinie_FertigungslinieID);
            
            CreateTable(
                "dbo.Produktionsprogramms",
                c => new
                    {
                        ProduktionsprogrammID = c.Int(nullable: false, identity: true),
                        Sollstueckzahl = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        Bauteil_BauteilID = c.Int(),
                        Fertigungslinie_FertigungslinieID = c.Int(),
                    })
                .PrimaryKey(t => t.ProduktionsprogrammID)
                .ForeignKey("dbo.Bauteils", t => t.Bauteil_BauteilID)
                .ForeignKey("dbo.Fertigungslinies", t => t.Fertigungslinie_FertigungslinieID)
                .Index(t => t.Bauteil_BauteilID)
                .Index(t => t.Fertigungslinie_FertigungslinieID);
            
            CreateTable(
                "dbo.Reparaturs",
                c => new
                    {
                        ReparaturID = c.Int(nullable: false, identity: true),
                        Fachgebiet = c.Int(nullable: false),
                        Bereich = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        Auftragstext = c.String(),
                        Bearbeitungstext = c.String(),
                        BeginnTermin = c.DateTime(),
                        EndTermin = c.DateTime(),
                        Fertigungslinie_FertigungslinieID = c.Int(),
                    })
                .PrimaryKey(t => t.ReparaturID)
                .ForeignKey("dbo.Fertigungslinies", t => t.Fertigungslinie_FertigungslinieID)
                .Index(t => t.Fertigungslinie_FertigungslinieID);
            
            CreateTable(
                "dbo.Mitarbeiters",
                c => new
                    {
                        MitarbeiterID = c.Int(nullable: false, identity: true),
                        Active = c.Boolean(nullable: false),
                        Namenszusatz = c.Int(nullable: false),
                        Vorname = c.String(),
                        Nachname = c.String(),
                        Festnetz = c.String(),
                        Mobil = c.String(),
                        eMail = c.String(),
                        Bemerkung = c.String(),
                        Login_LoginID = c.Int(),
                        Passbild_EFImageID = c.Int(),
                        Reparatur_ReparaturID = c.Int(),
                        Audit_AuditID = c.Int(),
                        Wartung_WartungID = c.Int(),
                    })
                .PrimaryKey(t => t.MitarbeiterID)
                .ForeignKey("dbo.Logins", t => t.Login_LoginID)
                .ForeignKey("dbo.EFImages", t => t.Passbild_EFImageID)
                .ForeignKey("dbo.Reparaturs", t => t.Reparatur_ReparaturID)
                .ForeignKey("dbo.Audits", t => t.Audit_AuditID)
                .ForeignKey("dbo.Wartungs", t => t.Wartung_WartungID)
                .Index(t => t.Login_LoginID)
                .Index(t => t.Passbild_EFImageID)
                .Index(t => t.Reparatur_ReparaturID)
                .Index(t => t.Audit_AuditID)
                .Index(t => t.Wartung_WartungID);
            
            CreateTable(
                "dbo.Logins",
                c => new
                    {
                        LoginID = c.Int(nullable: false, identity: true),
                        LastLogin = c.DateTime(),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.LoginID);
            
            CreateTable(
                "dbo.Sonderaufgabes",
                c => new
                    {
                        SonderaufgabeID = c.Int(nullable: false, identity: true),
                        Fertigungslinie_FertigungslinieID = c.Int(),
                    })
                .PrimaryKey(t => t.SonderaufgabeID)
                .ForeignKey("dbo.Fertigungslinies", t => t.Fertigungslinie_FertigungslinieID)
                .Index(t => t.Fertigungslinie_FertigungslinieID);
            
            CreateTable(
                "dbo.Audits",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        Beginntermin = c.DateTime(),
                        Endtermin = c.DateTime(),
                        Aufgabe = c.String(),
                        Abschlussnote = c.Int(nullable: false),
                        Bereich = c.String(),
                        Sonderaufgabe_SonderaufgabeID = c.Int(),
                    })
                .PrimaryKey(t => t.AuditID)
                .ForeignKey("dbo.Sonderaufgabes", t => t.Sonderaufgabe_SonderaufgabeID)
                .Index(t => t.Sonderaufgabe_SonderaufgabeID);
            
            CreateTable(
                "dbo.Wartungs",
                c => new
                    {
                        WartungID = c.Int(nullable: false, identity: true),
                        Beginntermin = c.DateTime(),
                        Endtermin = c.DateTime(),
                        Nachfolgetermin = c.DateTime(),
                        Aufgabe = c.String(),
                        Bereich = c.String(),
                        Maschine_MaschineID = c.Int(),
                        Sonderaufgabe_SonderaufgabeID = c.Int(),
                    })
                .PrimaryKey(t => t.WartungID)
                .ForeignKey("dbo.Maschines", t => t.Maschine_MaschineID)
                .ForeignKey("dbo.Sonderaufgabes", t => t.Sonderaufgabe_SonderaufgabeID)
                .Index(t => t.Maschine_MaschineID)
                .Index(t => t.Sonderaufgabe_SonderaufgabeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Fertigungslinies", "Fertigung_FertigungID", "dbo.Fertigungs");
            DropForeignKey("dbo.Sonderaufgabes", "Fertigungslinie_FertigungslinieID", "dbo.Fertigungslinies");
            DropForeignKey("dbo.Wartungs", "Sonderaufgabe_SonderaufgabeID", "dbo.Sonderaufgabes");
            DropForeignKey("dbo.Mitarbeiters", "Wartung_WartungID", "dbo.Wartungs");
            DropForeignKey("dbo.Wartungs", "Maschine_MaschineID", "dbo.Maschines");
            DropForeignKey("dbo.Audits", "Sonderaufgabe_SonderaufgabeID", "dbo.Sonderaufgabes");
            DropForeignKey("dbo.Mitarbeiters", "Audit_AuditID", "dbo.Audits");
            DropForeignKey("dbo.Reparaturs", "Fertigungslinie_FertigungslinieID", "dbo.Fertigungslinies");
            DropForeignKey("dbo.Maschines", "Reparatur_ReparaturID", "dbo.Reparaturs");
            DropForeignKey("dbo.Mitarbeiters", "Reparatur_ReparaturID", "dbo.Reparaturs");
            DropForeignKey("dbo.Mitarbeiters", "Passbild_EFImageID", "dbo.EFImages");
            DropForeignKey("dbo.Mitarbeiters", "Login_LoginID", "dbo.Logins");
            DropForeignKey("dbo.Produktionsprogramms", "Fertigungslinie_FertigungslinieID", "dbo.Fertigungslinies");
            DropForeignKey("dbo.Produktionsprogramms", "Bauteil_BauteilID", "dbo.Bauteils");
            DropForeignKey("dbo.Supermarkts", "Fertigungslinie_FertigungslinieID", "dbo.Fertigungslinies");
            DropForeignKey("dbo.Supermarkts", "Bauteil_BauteilID", "dbo.Bauteils");
            DropForeignKey("dbo.Arbeitsplatzs", "Fertigungslinie_FertigungslinieID", "dbo.Fertigungslinies");
            DropForeignKey("dbo.Arbeitsfolges", "Fertigungslinie_FertigungslinieID", "dbo.Fertigungslinies");
            DropForeignKey("dbo.Maschines", "Arbeitsfolge_ArbeitsfolgeID", "dbo.Arbeitsfolges");
            DropForeignKey("dbo.Maschines", "Bild_EFImageID", "dbo.EFImages");
            DropForeignKey("dbo.Bauteils", "Arbeitsfolge_ArbeitsfolgeID", "dbo.Arbeitsfolges");
            DropForeignKey("dbo.Bauteils", "Bauteil_BauteilID", "dbo.Bauteils");
            DropForeignKey("dbo.Fertigungs", "Abteilung_AbteilungID", "dbo.Abteilungs");
            DropIndex("dbo.Wartungs", new[] { "Sonderaufgabe_SonderaufgabeID" });
            DropIndex("dbo.Wartungs", new[] { "Maschine_MaschineID" });
            DropIndex("dbo.Audits", new[] { "Sonderaufgabe_SonderaufgabeID" });
            DropIndex("dbo.Sonderaufgabes", new[] { "Fertigungslinie_FertigungslinieID" });
            DropIndex("dbo.Mitarbeiters", new[] { "Wartung_WartungID" });
            DropIndex("dbo.Mitarbeiters", new[] { "Audit_AuditID" });
            DropIndex("dbo.Mitarbeiters", new[] { "Reparatur_ReparaturID" });
            DropIndex("dbo.Mitarbeiters", new[] { "Passbild_EFImageID" });
            DropIndex("dbo.Mitarbeiters", new[] { "Login_LoginID" });
            DropIndex("dbo.Reparaturs", new[] { "Fertigungslinie_FertigungslinieID" });
            DropIndex("dbo.Produktionsprogramms", new[] { "Fertigungslinie_FertigungslinieID" });
            DropIndex("dbo.Produktionsprogramms", new[] { "Bauteil_BauteilID" });
            DropIndex("dbo.Supermarkts", new[] { "Fertigungslinie_FertigungslinieID" });
            DropIndex("dbo.Supermarkts", new[] { "Bauteil_BauteilID" });
            DropIndex("dbo.Arbeitsplatzs", new[] { "Fertigungslinie_FertigungslinieID" });
            DropIndex("dbo.Maschines", new[] { "Reparatur_ReparaturID" });
            DropIndex("dbo.Maschines", new[] { "Arbeitsfolge_ArbeitsfolgeID" });
            DropIndex("dbo.Maschines", new[] { "Bild_EFImageID" });
            DropIndex("dbo.Bauteils", new[] { "Arbeitsfolge_ArbeitsfolgeID" });
            DropIndex("dbo.Bauteils", new[] { "Bauteil_BauteilID" });
            DropIndex("dbo.Arbeitsfolges", new[] { "Fertigungslinie_FertigungslinieID" });
            DropIndex("dbo.Fertigungslinies", new[] { "Fertigung_FertigungID" });
            DropIndex("dbo.Fertigungs", new[] { "Abteilung_AbteilungID" });
            DropTable("dbo.Wartungs");
            DropTable("dbo.Audits");
            DropTable("dbo.Sonderaufgabes");
            DropTable("dbo.Logins");
            DropTable("dbo.Mitarbeiters");
            DropTable("dbo.Reparaturs");
            DropTable("dbo.Produktionsprogramms");
            DropTable("dbo.Supermarkts");
            DropTable("dbo.Arbeitsplatzs");
            DropTable("dbo.EFImages");
            DropTable("dbo.Maschines");
            DropTable("dbo.Bauteils");
            DropTable("dbo.Arbeitsfolges");
            DropTable("dbo.Fertigungslinies");
            DropTable("dbo.Fertigungs");
            DropTable("dbo.Abteilungs");
        }
    }
}
