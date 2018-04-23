///////////////////////////////
//Autor Sebastian Molkenthin
//Martikelnummer : 396734
//Team: ProMan
///////////////////////////////
using ProMan_Database.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_Database.Model
{
    public class Arbeitsfolge
    {
        public int ArbeitsfolgeID { get; set; }

        [StringLength(450)]
        [Index(IsUnique = true)]
        public string ArbeitsfolgeName { get; set; }
        public ICollection<Maschine> Maschinen { get; set; }
        public ICollection<Bauteil> Bauteile { get; set; }
        public string Arbeitsplaene { get; set; }
        public StatusArt Status { get; set; }

        public int Order { get; set; }

        public virtual Fertigungslinie Fertigungslinie { get; set; }

    }
}
