using ProMan_Database.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_Database
{
    public class ProManContext : DbContext
    {
        public ProManContext()
    : base("ProManDB")
        {
        }
        public DbSet<Abteilung> Abteilungen { get; set; }
        public DbSet<Bauteil> Bauteile { get; set; }
        public DbSet<Fertigung> Fertigungen { get; set; }
        public DbSet<Fertigungslinie> Fertigungslinien { get; set; }
        public DbSet<Hilfsmittel> Hilfsmittel { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Maschine> Maschinen { get; set; }
        public DbSet<MaschineHersteller> MaschineHersteller { get; set; }
        public DbSet<MaschineType> MaschineTypen { get; set; }
        public DbSet<MontageProgramm> MontageProgramme { get; set; }
        public DbSet<QualiMatrix> QualiMatrix { get; set; }
        public DbSet<Reparatur> Reparaturen { get; set; }
        public DbSet<Ruesten> Ruesten { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Wartung> Wartungen { get; set; }
        public DbSet<Werk> Werke { get; set; }
        public DbSet<Werkstuecktraeger> Werkstuecktraeger { get; set; }
        public DbSet<Werkzeug> Werkzeuge { get; set; }

    }
}
