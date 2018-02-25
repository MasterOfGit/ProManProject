using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_BusinessLayer.Models.AdminPages
{
    public class AdminPageMaschineDto
    {
        public List<MaschineDto> Maschinen { get; set; }
        public List<ProMan_Database.Enums.Technologie> Technologien
        {
            get
            {
                return new List<ProMan_Database.Enums.Technologie>()
                {
                    ProMan_Database.Enums.Technologie.drehen,
                    ProMan_Database.Enums.Technologie.fraesen,
                    ProMan_Database.Enums.Technologie.messen,
                    ProMan_Database.Enums.Technologie.schleifen,
                    ProMan_Database.Enums.Technologie.waschen,
                };
            }
            set
            {

            }
        }

    }
}
