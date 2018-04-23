///////////////////////////////
//Autor Sebastian Molkenthin
//Martikelnummer : 396734
//Team: ProMan
///////////////////////////////
using ProMan_Database.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_Database.Model
{
    public class Arbeitsplatz
    {
        public int ArbeitsplatzID { get; set; }
        public virtual int MitarbeiterID { get; set; }
        public ICollection<AufgabenGruppe> Aufgaben { get; set; }
    }
}
