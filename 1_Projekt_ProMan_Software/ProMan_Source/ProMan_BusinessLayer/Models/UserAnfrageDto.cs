using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_BusinessLayer.Models
{
    public class UserAnfrageDto
    {
        public int userId { get; set; }
        public string userGrund { get; set; }
        public string userNachricht { get; set; }
        public string userAnfrageStatus { get; set; }
    }
}
