using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_BusinessLayer.Models.Maschinenfuehrer
{
    public class MFLinieDto
    {
        //general
        public string Name { get; set; }

        public string Werk { get; set; }
        public string Halle { get; set; }
        public string Ort { get; set; }
        public string Schicht { get; set; }

        public UserDto Verantwortlicher { get; set; }

        //Produktionsdaten
        public string Aktuelle_Teilenummer { get; set; }
        public int Aktuelle_Stueckzahl_Soll { get; set; }
        public int Aktuelle_Stueckzahl_Ist { get; set; }
        public string Naechste_Teilnummer{get;set;}
        public int Naechste_Stueckzahl_Soll { get; set; }
   
        //Maschinendaten

        public List<MaschineDto> Maschinen { get; set; }

        //aufgaben
        public int Reparaturen_Count { get; set; }
        public int Wartung_Count { get; set; }

        //Informationen

        public int Reparaturen_Done_Count { get; set; }
        public int Reparaturen_Done_Open { get; set; }
        public int Reparaturen_Done_History { get; set; }

        public int Wartung_Done_Count { get; set; }
        public int Wartung_Done_Open { get; set; }
        public int Wartung_Done_History { get; set; }

        public int Audits_Done_Count { get; set; }
        public int Audits_Done_Open { get; set; }

        public int Optimierungen_Done_Count { get; set; }
        public int Optimierungen_Done_Open { get; set; }


    }
}
