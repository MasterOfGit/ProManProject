﻿using ProMan_Database.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_Database.Model
{
    public class Arbeitsfolge
    {
        public int ArbeitsfolgeID { get; set; }
        public string ArbeitsfolgeName { get; set; }
        public ICollection<Maschine> Maschinen { get; set; }
        public ICollection<Bauteil> Bauteile { get; set; }
        public string Arbeitsplaene { get; set; }
        public StatusArt Status { get; set; }
    }
}