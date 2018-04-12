using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProMan_BusinessLayer.Models
{
    public class FertigungDto
    {
        public int fertigungsID { get; set; }
        public string fertigungsname { get; set; }
        public string abteilungName { get; set; }
        public List<FertigungslinieDto> fertigungslinien;
        public int FertigungslinienAnzahl
        {
            get
            {
                return fertigungslinien.Count;
            }
            set { }

        }
    }
}