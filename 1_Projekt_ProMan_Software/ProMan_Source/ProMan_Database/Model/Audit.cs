﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_Database.Model
{
    public class Audit
    {
        public int AuditID { get; set; }
        public DateTime? Beginntermin { get; set; }
        public DateTime? Endtermin { get; set; }
        public string Aufgabe { get; set; }
        public int Abschlussnote { get; set; }
        public string Bereich { get; set; }
        public ICollection<Mitarbeiter> Zuständigkeit { get; set; }
    }
}