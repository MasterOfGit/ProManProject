using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_Database.Model
{
    public class MontageProgramm
    {
        public int MontageProgrammID { get; set; }
        
        public int MengeSoll { get; set; }
        public int MengeIst { get; set; }

        public virtual Abteilung VerantwortlicherAbteilung { get; set; }
        public virtual ICollection<Bauteil> Bauteile { get; set; }
    }
}
