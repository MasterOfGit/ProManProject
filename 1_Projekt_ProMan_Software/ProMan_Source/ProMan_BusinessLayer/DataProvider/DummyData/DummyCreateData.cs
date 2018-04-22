using System;
using ProMan_BusinessLayer.DataProvider.Interfaces;
using ProMan_BusinessLayer.Models;

namespace ProMan_BusinessLayer.DataProvider.DummyData
{
    public class DummyCreateData : ICreateDataProvider
    {
        #region set

        public int SetFertigungsDto(FertigungDto data)
        {
            return 0;
        }

        public int SetFertigungslinieDto(FertigungslinieDto data)
        {
            return 0;
        }

        public int SetMaschineDto(MaschineDto data)
        {
            return 0;
        }

        public int SetReparaturDto(ReparaturDto data)
        {
            return 0;
        }

        public int SetUserDto(UserDto data)
        {
            return 0;
        }

        public int SetWartungDto(WartungDto data)
        {
            return 0;
        }

        public int SetAbteilungDto(AbteilungDto data)
        {
            return 0;
        }

        public int SetNachrichtDto(NachrichtDto data)
        {
            return 0;
        }

        public int SetLoginDto(LoginDto data)
        {
            return 0;
        }

        public int SetAuditDto(AuditDto data)
        {
            return 0;
        }

        public int SetBauteilVerwendungDto(BauteilVerwendungDto data)
        {
            return 0;
        }

        public int SetInstandhaltungsAuftragDto(InstandhaltungsAuftragDto data)
        {
            return 0;
        }

        public int SetLagerBestandDto(LagerBestandDto data)
        {
            return 0;
        }

        public int SetMaschineVerwendungDto(MaschineVerwendungDto data)
        {
            return 0;
        }

        public int SetProduktionsplanDto(ProduktionsplanDto data)
        {
            return 0;
        }

        public int SetUserAnfrageDto(UserAnfrageDto data)
        {
            return 0;
        }

        public int SetBauteilDto(BauteilDto data)
        {
            return 0;
        }

        public void AddObject(string type, int parent, int id)
        {
            throw new NotImplementedException();
        }

        public int SetArbeitsfolgeDto(ArbeitsfolgeDto data)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
