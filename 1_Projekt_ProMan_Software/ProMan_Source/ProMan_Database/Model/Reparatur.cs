///////////////////////////////
//Autor Sebastian Molkenthin
//Martikelnummer : 396734
//Team: ProMan
///////////////////////////////
using ProMan_Database.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [StringLength(450)]
        public string Auftragstext { get; set; }
        [StringLength(450)]
        public string Bearbeitungstext { get; set; }
        public DateTime? BeginnTermin { get; set; }
        public DateTime? EndTermin { get; set; }
    }
}
