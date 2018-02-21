using ProMan_Database.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_Database.Model
{
    public class Reparatur
    {
        public int ReparaturID { get; set; }
        public Fachtype Fachgebiet { get; set; }
        public Bereichtyp Bereich { get; set; }
        public ReparaturStatus Status { get; set; }
        public ICollection<Mitarbeiter> Bearbeiter { get; set; }
        public ICollection<Maschine> Maschinen { get; set; }
        public string Auftragstext { get; set; }
        public string Bearbeitungstext { get; set; }
        public DateTime? BeginnTermin { get; set; }
        public DateTime? EndTermin { get; set; }
    }
}
