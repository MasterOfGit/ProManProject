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
            Random rnd = new Random(id);
            List<FertigungslinieDto> tmp = new List<FertigungslinieDto>();
            for (int i = 0; i < id; i++)
            {
                tmp.Add(GetFertigungslinieDto((rnd.Next(1, 5))));
            }

            FertigungDto item = new FertigungDto()
            {
                ID = id,
                Fertigungslinien = tmp
            }
            ;
            return item;
        }

        public FertigungslinieDto GetFertigungslinieDto(int id)
        {
            Random rnd = new Random(id);

            List<MaschineDto> tmp = new List<MaschineDto>();
            for (int i = 0; i < id; i++)
            {
                tmp.Add(GetMaschineDto(rnd.Next(0, 99)));
            }

            FertigungslinieDto item = new FertigungslinieDto()
            {
                Maschinen = tmp
            };

            return item;

        }

        public MaschineDto GetMaschineDto(int id)
        {
            MaschineDto item = new MaschineDto()
            {
                InventarNummer = id,
                Zeichnungsnummer = $"Maschine_{id}",
                Baujahr = DateTime.Now.AddYears(-id),
                Garantie = DateTime.Now.AddYears(id),
                Hersteller = $"Herrsteller_{id}",
                Type = $"Type_{id}",
                MaschinenStatus = GetMaschinenStatus(id),
            };
            return item;
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


        public ReparaturDto GetReparaturDto(int id)
        {
            ReparaturDto item = new ReparaturDto()
            {
                Status = "Finish",
                Dauer = new DateTime().AddHours(id),
                InventarNummer = 1,
                Start = DateTime.Now.AddHours(-id),
                User = GetUserDto(0),
                Zeichnungsnummer = $"Reparatur_{id}"
            };
            return item;
        }

        public UserDto GetUserDto(int id)
        {
            UserDto item = new UserDto()
            {
                FirstName = "Hand",
                FamilyName = "Peter",
                Abteilung = "Schrauber",
                Werk = "Kassel",
                eMail = "123@xyz.de",
                Phone = "0123/4567",
                Mobile = "0456/1234567"
            };
            return item;
        }

        public WartungDto GetWartungDto(int id)
        {
            WartungDto item = new WartungDto()
            {
                Beschreibung = "Dies ist eine Wartung",
                InventarNummer = 5,
                Status = "OnGoing",
                User = GetUserDto(0),
                WartungsInterval = DateTime.Now,
                Zeichnungsnummer = "123",
            };

            return item;
        }

        public bool SetFertigungsDto(FertigungDto data)
        {
            throw new NotImplementedException();
        }

        public bool SetFertigungslinieDto(FertigungslinieDto data)
        {
            throw new NotImplementedException();
        }

        public bool SetMaschineDto(MaschineDto data)
        {
            throw new NotImplementedException();
        }

        public bool SetReparaturDto(ReparaturDto data)
        {
            throw new NotImplementedException();
        }

        public bool SetUserDto(UserDto data)
        {
            throw new NotImplementedException();
        }

        public bool SetWartungDto(WartungDto data)
        {
            throw new NotImplementedException();
        }

        public bool UpdateFertigungsDto(FertigungDto data, int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateFertigungslinieDto(FertigungslinieDto data, int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateMaschineDto(MaschineDto data, int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateReparaturDto(ReparaturDto data, int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUserDto(UserDto data, int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateWartungDto(WartungDto data, int id)
        {
            throw new NotImplementedException();
        }
    }
}