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



        #endregion

        #region Generate Data

        private WartungDto GenerateWartung(int id)
        {
            return new WartungDto()
            {
            };
        }

        private UserDto GenerateUser(int id)
        {
            return new UserDto()
            {
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
            };
        }














        

        #endregion


    }
}