///////////////////////////////
//Autor Sebastian Molkenthin
//Martikelnummer : 396734
//Team: ProMan
///////////////////////////////
using ProMan_Database.Enums;
using System;


namespace ProMan_BusinessLayer.Models
{
    public class NachrichtDto
    {
        public int ID { get; set; }

        public UserDto From { get; set; }

        public UserDto To { get; set; }

        public DateTime? SendDate { get; set; }

        public NachrichtDto Antwort { get; set; }

        public string NachrichtenStatus { get; set; }

        public string Betreff { get; set; }

        public string Text { get; set; }

        public NachrichtenTyp Type { get; set; }
    }
}
