using ProMan_Database.Enums;
using System.Collections.Generic;


namespace ProMan_Database.Model
{
    public class Fertigung
    {
        public int FertigungID { get; set; }
        public string Bezeichnung { get; set; }
        public string Ort { get; set; }
        public Fertigungstype Fertigungstype { get;set;}
        public ICollection<Fertigungslinie> Fertigungslinien { get; set; }
        public virtual Abteilung Abteilung { get; set; }
    }
}
