using ProMan_Database.Model;
using System.Data.Entity;


namespace ProMan_Database
{
    public class ProManContext : DbContext
    {
        public ProManContext()
    : base("ProManDB")
        {
            
        }
        public DbSet<Abteilung> Abteilungen { get; set; }
        public DbSet<Arbeitsfolge> Arbeitsfolgen { get; set; }
        public DbSet<Arbeitsplatz > Arbeitsplaetze { get; set; }
        public DbSet<Audit> Audits { get; set; }
        public DbSet<Bauteil> Bauteile { get; set; }
        public DbSet<EFImage> EFImages { get; set; }
        public DbSet<Fertigung> Fertigungen { get; set; }
        public DbSet<Fertigungslinie> Fertigungslinien { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Maschine> Maschinen { get; set; }
        public DbSet<Mitarbeiter> Mitarbeiter { get; set; }
        public DbSet<Nachricht> Nachrichten { get; set; }
        public DbSet<Produktionsprogramm> Produktionsprogramme { get; set; }
        public DbSet<Reparatur> Reparaturen { get; set; }
        public DbSet<Sonderaufgabe> Sonderaufgaben { get; set; }
        public DbSet<Supermarkt> Supermaerkte { get; set; }
        public DbSet<Wartung> Wartungen { get; set; }

    }
}
