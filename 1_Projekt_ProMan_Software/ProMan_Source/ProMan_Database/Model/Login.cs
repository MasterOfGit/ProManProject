using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_Database.Model
{
    public class Login
    {
        public int LoginID { get; set; }
        public DateTime? LastLogin { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
