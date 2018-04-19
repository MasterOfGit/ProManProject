using System.Collections.Generic;
using System.Linq;

namespace ProMan_BusinessLayer.Models.AdminPages
{
    public class AdminPageFertigungDto
    {
        public List<ExtendedAdminFertigungDto> Fertigungen { get; set; }

        public List<string> FertigungsBezeichnungen
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

    public class ExtendedAdminFertigungDto : FertigungDto
    {
        public List<string> Fertigungslinienbezeichnung
        {
            get
            {
                return fertigungslinien.Select(x => x.fertigungslinienname).Distinct().ToList();
            }
            set
            {
            }
        }
    }

}
