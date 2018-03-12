using ProMan_Database.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace ProMan_Database.Model
{
    public class Nachricht
    {
        public int NachrichtID { get; set; }

        public Mitarbeiter From { get; set; }

        public Mitarbeiter To { get; set; }

        public DateTime? SendDate { get; set; }

        public Nachricht Antwort { get; set; }

        public bool Gelesen { get; set; }

        [StringLength(255)]
        public string Betreff { get; set; }

        [StringLength(450)]
        public string Text { get; set; }

        public NachrichtenTyp Type { get; set; }

    }
}
