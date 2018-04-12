using System.Collections.Generic;
using System.Linq;

namespace ProMan_BusinessLayer.Models.AdminPages
{
    public class AdminPageAbteilungDto
    {
        public List<ExtendedAdminAbteilungenDto> Abteilungen { get; set; }

        public List<string> Abteilungsnamen
        {
            get
            {
                return Abteilungen.Select(x => x.abteilungsname).Distinct().ToList();
            }
            set
            {
            }
        }


    }

    public class ExtendedAdminAbteilungenDto : AbteilungDto
    {
        public List<string> Fertigungsnamen 
        {
            get
            {
                return Fertigungen.Select(x => x.fertigungsname).Distinct().ToList();
            }
            set
            {
            }
        }
    }

}
