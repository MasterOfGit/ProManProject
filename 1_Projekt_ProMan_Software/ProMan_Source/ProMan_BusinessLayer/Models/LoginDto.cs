using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_BusinessLayer.Models
{
    public class LoginDto
    {
        public string AnzeigeName { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public string LoginType { get; set; }
    }
}
