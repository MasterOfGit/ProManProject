using System.Collections.Generic;


namespace ProMan_Database.Model
{
    public class Abteilung
    {
        public int AbteilungID { get; set; }
        public Werk Werk { get; set; }
        public string Fachbereich { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Fertigung> Fertigungen { get; set; }
        public virtual ICollection<User> Users { get; set; }

    }
}
