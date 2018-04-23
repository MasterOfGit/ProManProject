///////////////////////////////
//Autor Sebastian Molkenthin
//Martikelnummer : 396734
//Team: ProMan
///////////////////////////////
using ProMan_Database.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProMan_Database.Model
{
    public class Fertigung
    {
        public int FertigungID { get; set; }
        [StringLength(100)]
        public string Bezeichnung { get; set; }
        [StringLength(100)]
        public string Ort { get; set; }
        public ICollection<Fertigungslinie> Fertigungslinien { get; set; }
        public virtual Abteilung Abteilung { get; set; }
    }
}
