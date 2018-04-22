using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_BusinessLayer.Models
{
    public class LoginDto
    {
        public int userID { get; set; }
        public DateTime userLastLogin { get; set; }
        public string userStatus { get; set;}
        public string userbereich { get; set; }
        public string userKennung { get; set; }
        public string userpasswort { get; set; }
       
    }
}
