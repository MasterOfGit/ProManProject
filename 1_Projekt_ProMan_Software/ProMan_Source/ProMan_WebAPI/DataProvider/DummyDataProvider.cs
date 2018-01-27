using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProMan_WebAPI.Models;

namespace ProMan_WebAPI.DataProvider
{
    public class DummyDataProvider : IDataProvider
    {
        public FertigungDto GetFertigungsDto(int id)
        {
            List<FertigungslinieDto> tmp = new List<FertigungslinieDto>();
            for (int i = 0; i < id; i++)
            {
                tmp.Add(GetFertigungslinieDto(i));
            }

            FertigungDto item = new FertigungDto()
            {
                ID = id,
                Fertigungslinien = tmp
            };
            return item;
        }

        public FertigungslinieDto GetFertigungslinieDto(int id)
        {
            List<MaschineDto> tmp = new List<MaschineDto>();
            for (int i = 0; i < id; i++)
            {
                tmp.Add(GenerateMaschine(id));
            }

            FertigungslinieDto item = new FertigungslinieDto()
            {
                Maschinen = tmp
            };

            return item;

        }

        public MaschineDto GetMaschineDto(int id)
        {
            return GenerateMaschine(id);
        }

        public ReparaturDto GetReparaturDto(int id)
        {
            return GenerateReparatur(id);
        }

        public UserDto GetUserDto(int id)
        {
            return GenerateUser(id);
        }

        public WartungDto GetWartungDto(int id)
        {
            return GenerateWartung(id);
        }
        #region set

        public bool SetFertigungsDto(FertigungDto data)
        {
            return true;
        }

        public bool SetFertigungslinieDto(FertigungslinieDto data)
        {
            return true;
        }

        public bool SetMaschineDto(MaschineDto data)
        {
            return true;
        }

        public bool SetReparaturDto(ReparaturDto data)
        {
            return true;
        }

        public bool SetUserDto(UserDto data)
        {
            return true;
        }

        public bool SetWartungDto(WartungDto data)
        {
            return true;
        }
        #endregion

        #region Update

        public bool UpdateFertigungsDto(FertigungDto data, int id)
        {
            return true;
        }

        public bool UpdateFertigungslinieDto(FertigungslinieDto data, int id)
        {
            return true;
        }

        public bool UpdateMaschineDto(MaschineDto data, int id)
        {
            return true;
        }

        public bool UpdateReparaturDto(ReparaturDto data, int id)
        {
            return true;
        }

        public bool UpdateUserDto(UserDto data, int id)
        {
            return true;
        }

        public bool UpdateWartungDto(WartungDto data, int id)
        {
            return true;
        }
        #endregion

        #region Generate Data

        private WartungDto GenerateWartung(int id)
        {
            return new WartungDto()
            {
                Beschreibung = "Dies ist eine Wartung",
                InventarNummer = 5,
                Status = "OnGoing",
                User = GetUserDto(0),
                WartungsInterval = DateTime.Now,
                Zeichnungsnummer = "123",
            };
        }

        private UserDto GenerateUser(int id)
        {
            return new UserDto()
            {
                FirstName = $"Hans_NR{id}",
                FamilyName = "Peter",
                Abteilung = "Schrauber",
                Werk = "Kassel",
                eMail = "123@xyz.de",
                Phone = "0123/4567",
                Mobile = "0456/1234567"
            };
        }

        private ReparaturDto GenerateReparatur(int id)
        {
            return new ReparaturDto()
            {
                Status = "Finish",
                Dauer = new DateTime().AddHours(id),
                InventarNummer = 1,
                Start = DateTime.Now.AddHours(-id),
                User = GetUserDto(0),
                Zeichnungsnummer = $"Reparatur_{id}"
            };
        }

        private MaschineDto GenerateMaschine(int id)
        {
            return new MaschineDto()
            {
                InventarNummer = id,
                Zeichnungsnummer = $"Maschine_{id}",
                Baujahr = DateTime.Now.AddYears(-id),
                Garantie = DateTime.Now.AddYears(id),
                Hersteller = $"Herrsteller_{id}",
                Type = $"Type_{id}",
                MaschinenStatus = GetMaschinenStatus(id),
            };
        }

        private ProMan_Database.Enums.MaschinenStatus GetMaschinenStatus(int id)
        {
            Random rnd = new Random(id);
            ProMan_Database.Enums.MaschinenStatus result;

            switch (rnd.Next(0, 4))
            {
                case 0:
                    result = ProMan_Database.Enums.MaschinenStatus.Defekt;
                    break;
                case 1:
                    result = ProMan_Database.Enums.MaschinenStatus.Fehler;
                    break;
                case 2:
                    result = ProMan_Database.Enums.MaschinenStatus.Okay;
                    break;
                case 3:
                    result = ProMan_Database.Enums.MaschinenStatus.Warnung;
                    break;
                case 4:
                    result = ProMan_Database.Enums.MaschinenStatus.Wartung;
                    break;
                default:
                    result = result = ProMan_Database.Enums.MaschinenStatus.Okay;
                    break;
            }
            return result;
        }

        #endregion


    }
}