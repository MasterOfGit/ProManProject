using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_Database.Model
{
    public class Fertigungslinie
    {
        public int FertigungslinieID { get; set; }

        public virtual Fertigung Fertigung { get; set; }
        public virtual ICollection<Werkstuecktraeger> Werkstuecktraeger { get; set; }
        public virtual ICollection<Maschine> Maschinen { get; set; }
    }
}
