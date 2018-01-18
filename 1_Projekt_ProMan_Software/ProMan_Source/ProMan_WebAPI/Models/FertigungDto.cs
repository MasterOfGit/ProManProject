using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProMan_WebAPI.Models
{
    public class FertigungDto
    {
        public int ID;
        public List<FertigungslinieDto> Fertigungslinien;
    }
}