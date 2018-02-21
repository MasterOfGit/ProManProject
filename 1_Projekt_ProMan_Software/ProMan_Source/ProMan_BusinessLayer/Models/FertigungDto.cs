using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProMan_BusinessLayer.Models
{
    public class FertigungDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string AbteilungName { get; set; }
        public List<FertigungslinieDto> Fertigungslinien;
        public int FertigungslinienAnzahl
        {
            get
            {
                return Fertigungslinien.Count;
            }
            set { }

        }
    }
}