using System;
using System.Collections.Generic;
using ProMan_BusinessLayer.Models;

namespace ProMan_BusinessLayer.DataProvider
{
    /// <summary>
    /// Generates dummy data for the view. Does not support setting or updating data
    /// </summary>
    public class DummyDataProvider : IDataProvider
    {
        public AbteilungDto GetAbteilungDto(int id)
        {
            List<FertigungDto> ferttmp = new List<FertigungDto>();
            List<UserDto> usertmp = new List<UserDto>();

            for(int i = 1; i < id +1; i++)
            {
                ferttmp.Add(GetFertigungsDto(i));
                usertmp.Add(GenerateUser(i));
            }

            AbteilungDto item = new AbteilungDto()
            {
                ID = id,
                Name = $"Abteilung{id}",
                Fachbereich = $"Fachbereich{id}",
                WerkName = $"Werk{id}",
                Fertigungen = ferttmp,
                User = usertmp,
            };

            return item;
        }

        public WerkDto GetWerkDto(int id)
        {
            List<AbteilungDto> tmp = new List<AbteilungDto>();
            for (int i = 1; i < id + 2; i++)
            {
                tmp.Add(GetAbteilungDto(i));
            }
            WerkDto item = new WerkDto()
            {
                ID = id,
                Name = $"Werk_{id}",
                Ort = $"Ort_{id}",
                Abteilungen = tmp,

            };
            return item;
        }

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
                Name = $"Fertigung{id}",
                AbteilungName = $"Abteilung{id}",
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
                ID = id,
                Name = $"linie{id}",
                Maschinen = tmp,
                FertigungName = $"Fertigung{id}"
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

        public bool SetAbteilungDto(AbteilungDto data)
        {
            return true;
        }

        public bool SetWerkDto(WerkDto data)
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
        public bool UpdateAbteilungDto(AbteilungDto data, int id)
        {
            return true;
        }

        public bool UpdateWerkDto(WerkDto data, int id)
        {
            return true;
        }

        #endregion

        #region Generate Data

        private WartungDto GenerateWartung(int id)
        {
            return new WartungDto()
            {
                ID= id,
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
                ID = id,
                FirstName = $"Hans_NR{id}",
                FamilyName = "Peter",
                Abteilung = "Schrauber",
                Werk = "Kassel",
                eMail = "123@xyz.de",
                Phone = "0123/4567",
                Mobile = "0456/1234567",
                WerkName = $"Werk{id}",
                AbteilungName = $"Abteilung{id}",
            };
        }

        private ReparaturDto GenerateReparatur(int id)
        {
            return new ReparaturDto()
            {
                ID = id,
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
                ID = id,
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