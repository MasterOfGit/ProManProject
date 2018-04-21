using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProMan_BusinessLayer.Models
{
    public class WartungDto
    {
        public int wartungsID { get; set; }
        public int? abteilung { get; set; }
        public int? fertigung { get; set; }
        public int? fertigungslinie { get; set; }
        public int? maschine { get; set; }
        public string terminturnus { get; set; }
        public string status { get; set; }

        //public DateTime? Beginntermin { get; set; }
        //public DateTime? Endtermin { get; set; }
        //public DateTime? Nachfolgetermin { get; set; }
        //public string Aufgabe { get; set; }
        //public string Bereich { get; set; }
        //public List<UserDto> Zuständigkeit { get; set; }
        //public MaschineDto Maschine { get; set; }
    }
}