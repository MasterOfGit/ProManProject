﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_Database.Model
{
    public class Bauteil
    {
        public int BauteilID { get; set; }
        public string Teilart { get; set; }
        public string Version { get; set; }
        public string Verwendungsort { get; set; }
        public ICollection<Bauteil> Abhaengigkeiten { get; set; }
    }
}
