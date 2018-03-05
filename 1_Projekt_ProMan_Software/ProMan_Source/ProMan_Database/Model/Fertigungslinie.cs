using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_Database.Model
{
    public class Fertigungslinie
    {
        public int FertigungslinieID { get; set; }
        [StringLength(100)]
        public string Bezeichnung { get; set; }
        public ICollection<Arbeitsfolge> Arbeitsfolgen { get; set; }
        public ICollection<Reparatur> Reparaturen { get; set; }
        public ICollection<Sonderaufgabe> Sonderaufgaben { get; set; }
        public ICollection<Arbeitsplatz> Arbeitsplaetze { get; set; }
        public ICollection<Produktionsprogramm> Produktion { get; set; }
        public ICollection<Supermarkt> Lager { get; set; }

        public virtual Fertigung Fertigung { get; set; }
    }
}
