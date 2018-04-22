using System;
using ProMan_BusinessLayer.DataProvider.Interfaces;

namespace ProMan_BusinessLayer.DataProvider.DummyData
{
    public class DummyDelete : IDeleteDataProvider
    {
        public bool DeleteAbteilungDto(int id)
        {
            return false;
        }

        public bool DeleteArbeitsfolgeDto(int id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteAuditDto(int id)
        {
            return false;
        }

        public bool DeleteBauteilDto(int id)
        {
            return false;
        }

        public bool DeleteBauteilVerwendungDto(int id)
        {
            return false;
        }

        public bool DeleteFertigungsDto(int id)
        {
            return false;
        }

        public bool DeleteFertigungslinieDto(int id)
        {
            return false;
        }

        public bool DeleteInstandhaltungsAuftragDto(int id)
        {
            return false;
        }

        public bool DeleteLagerBestandDto(int id)
        {
            return false;
        }

        public bool DeleteLoginDto(int id)
        {
            return false;
        }

        public bool DeleteMaschineDto(int id)
        {
            return false;
        }

        public bool DeleteMaschineVerwendungDto(int id)
        {
            return false;
        }

        public bool DeleteNachrichtDto(int id)
        {
            return false;
        }

        public bool DeleteProduktionsplanDto(int id)
        {
            return false;
        }

        public bool DeleteReparaturDto(int id)
        {
            return false;
        }

        public bool DeleteUserAnfrageDto(int id)
        {
            return false;
        }

        public bool DeleteUserDto(int id)
        {
            return false;
        }

        public bool DeleteWartungDto(int id)
        {
            return false;
        }

        public void RemoteObject(string type, int parent, int id)
        {
            throw new NotImplementedException();
        }
    }
}
