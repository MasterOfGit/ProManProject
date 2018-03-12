using ProMan_Database.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_Database.Model
{
    public class Arbeitsfolge
    {
        public int ArbeitsfolgeID { get; set; }
        [Index(IsUnique = true)]
        public string ArbeitsfolgeName { get; set; }
        public ICollection<Maschine> Maschinen { get; set; }
        public ICollection<Bauteil> Bauteile { get; set; }
        public string Arbeitsplaene { get; set; }
        public StatusArt Status { get; set; }

        public virtual Fertigungslinie Fertigungslinie { get; set; }

    }
}
