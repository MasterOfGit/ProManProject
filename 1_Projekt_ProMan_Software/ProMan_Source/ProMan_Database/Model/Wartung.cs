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
    public class Wartung
    {
        public int WartungID { get; set; }
        public DateTime? Beginntermin { get; set; }
        public DateTime? Endtermin { get; set; }
        public DateTime? Nachfolgetermin { get; set; }
        [StringLength(100)]
        public string Aufgabe { get; set; }
        [StringLength(100)]
        public string Bereich { get; set; }
        public ICollection<Mitarbeiter> Zuständigkeit { get; set; }
        public Maschine Maschine { get; set; }
        public StatusArt Status { get; set; }
        public Turnus Turnus { get; set; }

    }
}
