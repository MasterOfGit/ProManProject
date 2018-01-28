using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_Database.Model
{
    // Verschiedene Schritte der Fertigung
    public class Fertigung
    {
        public int FertigungID { get; set; }

        public string Name { get; set; }

        public virtual Abteilung Abteilung { get; set; }
        public DateTime? TaktzeitSoll { get; set; }
        public DateTime? TaktzeitIst { get; set; }
        public int MengeSoll { get; set; }
        public int MengeIst { get; set; }

        public virtual ICollection <Fertigungslinie> Fertigungslinien { get; set; }
    }
}
