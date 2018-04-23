///////////////////////////////
//Autor Sebastian Molkenthin
//Martikelnummer : 396734
//Team: ProMan
///////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_Database.Model
{
    public class Bauteil
    {
        public int BauteilID { get; set; }
        [StringLength(100)]
        public string Teilart { get; set; }
        [StringLength(100)]
        public string Version { get; set; }
        [StringLength(100)]
        public string Verwendungsort { get; set; }

        public int NachfolderId { get; set; }
        public string Index { get; set;}

        public string Status { get; set; }
        public string Nummer { get; set; }


        public ICollection<Bauteil> Abhaengigkeiten { get; set; }
    }
}
