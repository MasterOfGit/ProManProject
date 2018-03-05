using ProMan_Database.Enums;
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

        public List<string> Technologien { get
            {
                return Enum.GetValues(typeof(Technologie))
                .Cast<Technologie>()
                .Select(v => v.ToString())
                .ToList();
            }
            set{     
            }
                
        }

        public List<string> Stati {
            get
            {
                return Enum.GetValues(typeof(StatusArt))
                .Cast<StatusArt>()
                .Select(v => v.ToString())
                .ToList();
            }
            set
            { }
        }





    }
}
