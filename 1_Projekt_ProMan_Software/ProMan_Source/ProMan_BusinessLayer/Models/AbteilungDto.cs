using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_BusinessLayer.Models
{
    public class AbteilungDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Fachbereich { get; set; }
        public List<FertigungDto> Fertigungen { get; set; }
        public List<UserDto> User { get; set; }
        public string WerkName { get; set; }
    }
}
