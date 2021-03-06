﻿///////////////////////////////
//Autor Sebastian Molkenthin
//Martikelnummer : 396734
//Team: ProMan
///////////////////////////////


namespace ProMan_BusinessLayer.Models
{
    public class UserDto
    {
        public int userID { get; set; }
        public bool userActive { get; set; }
        public string userAnrede { get; set; }
        public string userVorname { get; set; }
        public string userNachname { get; set; }
        public string userFestnetzNr { get; set; }
        public string userMobilNr { get; set; }
        public string userEmail { get; set; }
        public string userBemerkung { get; set; }

        public string userBild { get; set; }
        public string userAbteilung { get; set; }
        public string userWerk { get; set; }
        public string userLand { get; set; }

        public int LoginId { get; set; }
    }
}