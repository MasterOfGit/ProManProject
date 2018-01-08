using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_Database.Model
{
    public class User
    {
        public int UserID { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string FamilyName { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }
        public virtual Abteilung Abteilung { get; set; }
        public string Country { get; set; }
        public string eMail { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Kuerzel { get; set; }

    }
}
