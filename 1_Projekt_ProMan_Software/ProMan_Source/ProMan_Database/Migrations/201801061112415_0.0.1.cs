namespace ProMan_Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _001 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abteilungs",
                c => new
                    {
                        AbteilungID = c.Int(nullable: false, identity: true),
                        Fachbereich = c.String(),
                        Werk_WerkID = c.Int(),
                    })
                .PrimaryKey(t => t.AbteilungID)
                .ForeignKey("dbo.Werks", t => t.Werk_WerkID)
                .Index(t => t.Werk_WerkID);
            
            CreateTable(
                "dbo.Werks",
                c => new
                    {
                        WerkID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.WerkID);
            
            CreateTable(
                "dbo.Bauteils",
                c => new
                    {
                        BauteilID = c.Int(nullable: false, identity: true),
                        Zeichnungsnummer = c.Int(nullable: false),
                        Version = c.String(),
                        ProduktionsBeginn = c.DateTime(),
                        MontageProgramm_MontageProgrammID = c.Int(),
                    })
                .PrimaryKey(t => t.BauteilID)
                .ForeignKey("dbo.MontageProgramms", t => t.MontageProgramm_MontageProgrammID)
                .Index(t => t.MontageProgramm_MontageProgrammID);
            
            CreateTable(
                "dbo.Fertigungs",
                c => new
                    {
                        FertigungID = c.Int(nullable: false, identity: true),
                        InventarID = c.Int(nullable: false),
                        TaktzeitSoll = c.DateTime(),
                        TaktzeitIst = c.DateTime(),
                        MengeSoll = c.Int(nullable: false),
                        MengeIst = c.Int(nullable: false),
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
                        Fertigung_FertigungID = c.Int(),
                    })
                .PrimaryKey(t => t.FertigungslinieID)
                .ForeignKey("dbo.Fertigungs", t => t.Fertigung_FertigungID)
                .Index(t => t.Fertigung_FertigungID);
            
            CreateTable(
                "dbo.Maschines",
                c => new
                    {
                        MaschineID = c.Int(nullable: false, identity: true),
                        InventarNummer = c.Int(nullable: false),
                        Zeichnungsnummer = c.String(),
                        Baujahr = c.DateTime(),
                        Garantie = c.DateTime(),
                        MaschinenStatus = c.Int(nullable: false),
                        Hersteller_MaschineHerstellerID = c.Int(),
                        Ruesten_RuestenID = c.Int(),
                        Type_MaschineTypeID = c.Int(),
                        Wartung_WartungID = c.Int(),
                        Fertigungslinie_FertigungslinieID = c.Int(),
                    })
                .PrimaryKey(t => t.MaschineID)
                .ForeignKey("dbo.MaschineHerstellers", t => t.Hersteller_MaschineHerstellerID)
                .ForeignKey("dbo.Ruestens", t => t.Ruesten_RuestenID)
                .ForeignKey("dbo.MaschineTypes", t => t.Type_MaschineTypeID)
                .ForeignKey("dbo.Wartungs", t => t.Wartung_WartungID)
                .ForeignKey("dbo.Fertigungslinies", t => t.Fertigungslinie_FertigungslinieID)
                .Index(t => t.Hersteller_MaschineHerstellerID)
                .Index(t => t.Ruesten_RuestenID)
                .Index(t => t.Type_MaschineTypeID)
                .Index(t => t.Wartung_WartungID)
                .Index(t => t.Fertigungslinie_FertigungslinieID);
            
            CreateTable(
                "dbo.MaschineHerstellers",
                c => new
                    {
                        MaschineHerstellerID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Adresse = c.String(),
                    })
                .PrimaryKey(t => t.MaschineHerstellerID);
            
            CreateTable(
                "dbo.Reparaturs",
                c => new
                    {
                        ReparaturID = c.Int(nullable: false, identity: true),
                        Start = c.DateTime(),
                        Dauer = c.DateTime(),
                        Status = c.String(),
                        Maschine_MaschineID = c.Int(),
                        User_UserID = c.Int(),
                    })
                .PrimaryKey(t => t.ReparaturID)
                .ForeignKey("dbo.Maschines", t => t.Maschine_MaschineID)
                .ForeignKey("dbo.Users", t => t.User_UserID)
                .Index(t => t.Maschine_MaschineID)
                .Index(t => t.User_UserID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        FirstName = c.String(),
                        FamilyName = c.String(),
                        Password = c.String(),
                        Status = c.String(),
                        Country = c.String(),
                        eMail = c.String(),
                        Phone = c.String(),
                        Mobile = c.String(),
                        Kuerzel = c.String(),
                        Abteilung_AbteilungID = c.Int(),
                    })
                .PrimaryKey(t => t.UserID)
                .ForeignKey("dbo.Abteilungs", t => t.Abteilung_AbteilungID)
                .Index(t => t.Abteilung_AbteilungID);
            
            CreateTable(
                "dbo.Ruestens",
                c => new
                    {
                        RuestenID = c.Int(nullable: false, identity: true),
                        Standzeit = c.DateTime(),
                        MaschineID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RuestenID);
            
            CreateTable(
                "dbo.Hilfsmittels",
                c => new
                    {
                        HilfsmittelID = c.Int(nullable: false, identity: true),
                        Art = c.String(),
                        Beschreibung = c.String(),
                        Gefahrgut = c.Boolean(nullable: false),
                        Ruesten_RuestenID = c.Int(),
                    })
                .PrimaryKey(t => t.HilfsmittelID)
                .ForeignKey("dbo.Ruestens", t => t.Ruesten_RuestenID)
                .Index(t => t.Ruesten_RuestenID);
            
            CreateTable(
                "dbo.Werkzeugs",
                c => new
                    {
                        WerkzeugID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Beschreibung = c.String(),
                        Technologie = c.String(),
                        Ruesten_RuestenID = c.Int(),
                    })
                .PrimaryKey(t => t.WerkzeugID)
                .ForeignKey("dbo.Ruestens", t => t.Ruesten_RuestenID)
                .Index(t => t.Ruesten_RuestenID);
            
            CreateTable(
                "dbo.MaschineTypes",
                c => new
                    {
                        MaschineTypeID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.MaschineTypeID);
            
            CreateTable(
                "dbo.Wartungs",
                c => new
                    {
                        WartungID = c.Int(nullable: false, identity: true),
                        WartungsInterval = c.DateTime(),
                        Status = c.String(),
                        Beschreibung = c.String(),
                        MaschineID = c.Int(nullable: false),
                        User_UserID = c.Int(),
                    })
                .PrimaryKey(t => t.WartungID)
                .ForeignKey("dbo.Users", t => t.User_UserID)
                .Index(t => t.User_UserID);
            
            CreateTable(
                "dbo.Werkstuecktraegers",
                c => new
                    {
                        WerkstuecktraegerID = c.Int(nullable: false, identity: true),
                        BauteilStatus = c.Int(nullable: false),
                        CurBauteil_BauteilID = c.Int(),
                        Fertigungslinie_FertigungslinieID = c.Int(),
                    })
                .PrimaryKey(t => t.WerkstuecktraegerID)
                .ForeignKey("dbo.Bauteils", t => t.CurBauteil_BauteilID)
                .ForeignKey("dbo.Fertigungslinies", t => t.Fertigungslinie_FertigungslinieID)
                .Index(t => t.CurBauteil_BauteilID)
                .Index(t => t.Fertigungslinie_FertigungslinieID);
            
            CreateTable(
                "dbo.Logins",
                c => new
                    {
                        LoginID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.LoginID);
            
            CreateTable(
                "dbo.MontageProgramms",
                c => new
                    {
                        MontageProgrammID = c.Int(nullable: false, identity: true),
                        MengeSoll = c.Int(nullable: false),
                        MengeIst = c.Int(nullable: false),
                        VerantwortlicherAbteilung_AbteilungID = c.Int(),
                    })
                .PrimaryKey(t => t.MontageProgrammID)
                .ForeignKey("dbo.Abteilungs", t => t.VerantwortlicherAbteilung_AbteilungID)
                .Index(t => t.VerantwortlicherAbteilung_AbteilungID);
            
            CreateTable(
                "dbo.QualiMatrices",
                c => new
                    {
                        QualiMatrixID = c.Int(nullable: false, identity: true),
                        Wissenstand = c.Int(nullable: false),
                        Maschine_MaschineID = c.Int(),
                        User_UserID = c.Int(),
                    })
                .PrimaryKey(t => t.QualiMatrixID)
                .ForeignKey("dbo.Maschines", t => t.Maschine_MaschineID)
                .ForeignKey("dbo.Users", t => t.User_UserID)
                .Index(t => t.Maschine_MaschineID)
                .Index(t => t.User_UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.QualiMatrices", "User_UserID", "dbo.Users");
            DropForeignKey("dbo.QualiMatrices", "Maschine_MaschineID", "dbo.Maschines");
            DropForeignKey("dbo.MontageProgramms", "VerantwortlicherAbteilung_AbteilungID", "dbo.Abteilungs");
            DropForeignKey("dbo.Bauteils", "MontageProgramm_MontageProgrammID", "dbo.MontageProgramms");
            DropForeignKey("dbo.Werkstuecktraegers", "Fertigungslinie_FertigungslinieID", "dbo.Fertigungslinies");
            DropForeignKey("dbo.Werkstuecktraegers", "CurBauteil_BauteilID", "dbo.Bauteils");
            DropForeignKey("dbo.Maschines", "Fertigungslinie_FertigungslinieID", "dbo.Fertigungslinies");
            DropForeignKey("dbo.Maschines", "Wartung_WartungID", "dbo.Wartungs");
            DropForeignKey("dbo.Wartungs", "User_UserID", "dbo.Users");
            DropForeignKey("dbo.Maschines", "Type_MaschineTypeID", "dbo.MaschineTypes");
            DropForeignKey("dbo.Maschines", "Ruesten_RuestenID", "dbo.Ruestens");
            DropForeignKey("dbo.Werkzeugs", "Ruesten_RuestenID", "dbo.Ruestens");
            DropForeignKey("dbo.Hilfsmittels", "Ruesten_RuestenID", "dbo.Ruestens");
            DropForeignKey("dbo.Reparaturs", "User_UserID", "dbo.Users");
            DropForeignKey("dbo.Users", "Abteilung_AbteilungID", "dbo.Abteilungs");
            DropForeignKey("dbo.Reparaturs", "Maschine_MaschineID", "dbo.Maschines");
            DropForeignKey("dbo.Maschines", "Hersteller_MaschineHerstellerID", "dbo.MaschineHerstellers");
            DropForeignKey("dbo.Fertigungslinies", "Fertigung_FertigungID", "dbo.Fertigungs");
            DropForeignKey("dbo.Fertigungs", "Abteilung_AbteilungID", "dbo.Abteilungs");
            DropForeignKey("dbo.Abteilungs", "Werk_WerkID", "dbo.Werks");
            DropIndex("dbo.QualiMatrices", new[] { "User_UserID" });
            DropIndex("dbo.QualiMatrices", new[] { "Maschine_MaschineID" });
            DropIndex("dbo.MontageProgramms", new[] { "VerantwortlicherAbteilung_AbteilungID" });
            DropIndex("dbo.Werkstuecktraegers", new[] { "Fertigungslinie_FertigungslinieID" });
            DropIndex("dbo.Werkstuecktraegers", new[] { "CurBauteil_BauteilID" });
            DropIndex("dbo.Wartungs", new[] { "User_UserID" });
            DropIndex("dbo.Werkzeugs", new[] { "Ruesten_RuestenID" });
            DropIndex("dbo.Hilfsmittels", new[] { "Ruesten_RuestenID" });
            DropIndex("dbo.Users", new[] { "Abteilung_AbteilungID" });
            DropIndex("dbo.Reparaturs", new[] { "User_UserID" });
            DropIndex("dbo.Reparaturs", new[] { "Maschine_MaschineID" });
            DropIndex("dbo.Maschines", new[] { "Fertigungslinie_FertigungslinieID" });
            DropIndex("dbo.Maschines", new[] { "Wartung_WartungID" });
            DropIndex("dbo.Maschines", new[] { "Type_MaschineTypeID" });
            DropIndex("dbo.Maschines", new[] { "Ruesten_RuestenID" });
            DropIndex("dbo.Maschines", new[] { "Hersteller_MaschineHerstellerID" });
            DropIndex("dbo.Fertigungslinies", new[] { "Fertigung_FertigungID" });
            DropIndex("dbo.Fertigungs", new[] { "Abteilung_AbteilungID" });
            DropIndex("dbo.Bauteils", new[] { "MontageProgramm_MontageProgrammID" });
            DropIndex("dbo.Abteilungs", new[] { "Werk_WerkID" });
            DropTable("dbo.QualiMatrices");
            DropTable("dbo.MontageProgramms");
            DropTable("dbo.Logins");
            DropTable("dbo.Werkstuecktraegers");
            DropTable("dbo.Wartungs");
            DropTable("dbo.MaschineTypes");
            DropTable("dbo.Werkzeugs");
            DropTable("dbo.Hilfsmittels");
            DropTable("dbo.Ruestens");
            DropTable("dbo.Users");
            DropTable("dbo.Reparaturs");
            DropTable("dbo.MaschineHerstellers");
            DropTable("dbo.Maschines");
            DropTable("dbo.Fertigungslinies");
            DropTable("dbo.Fertigungs");
            DropTable("dbo.Bauteils");
            DropTable("dbo.Werks");
            DropTable("dbo.Abteilungs");
        }
    }
}
