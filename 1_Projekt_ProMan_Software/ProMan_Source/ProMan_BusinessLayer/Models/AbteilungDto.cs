﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_BusinessLayer.Models
{
    public class AbteilungDto
    {
        public int abteilungsID { get; set; }
        public string abteilungsname { get; set; }
        public string Fachbereich { get; set; }
        public List<FertigungDto> Fertigungen { get; set; }
        public List<UserDto> User { get; set; }
        public string WerkName { get; set; }
        public int FertigungsCount
        {
            get
            {
                return Fertigungen.Count;
            }
            set { }

        }


        //addional data
        public int FertigungslinieCount
        {
            get
            {
                int count = 0;
                foreach(var item in Fertigungen)
                {
                    count += item.FertigungslinienAnzahl;
                }

                return count;
            }
            set { }
        }
        public int Maschinencount
        { get; set; }

    }
}
