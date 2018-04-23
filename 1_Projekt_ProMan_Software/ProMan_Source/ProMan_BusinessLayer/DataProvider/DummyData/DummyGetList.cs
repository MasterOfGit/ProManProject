///////////////////////////////
//Autor Sebastian Molkenthin
//Martikelnummer : 396734
//Team: ProMan
///////////////////////////////
using System;
using System.Collections.Generic;
using ProMan_BusinessLayer.DataProvider.Interfaces;
using ProMan_BusinessLayer.Models;
using ProMan_BusinessLayer.Models.Maschinenfuehrer;

namespace ProMan_BusinessLayer.DataProvider.DummyData
{
    public class DummyGetList : IGetListDataProvider
    {
        public List<BauteilDto> GetBauteilDto()
        {
            throw new NotImplementedException();
        }

        public List<AbteilungDto> GetAbteilungDto()
        {
            throw new NotImplementedException();
        }

        public List<AuditDto> GetAuditDto()
        {
            throw new NotImplementedException();
        }

        public List<BauteilVerwendungDto> GetBauteilVerwendungDto()
        {
            throw new NotImplementedException();
        }

        public List<FertigungDto> GetFertigungsDto()
        {
            throw new NotImplementedException();
        }

        public List<FertigungslinieDto> GetFertigungslinieDto()
        {
            throw new NotImplementedException();
        }

        public List<InstandhaltungsAuftragDto> GetInstandhaltungsAuftragDto()
        {
            throw new NotImplementedException();
        }

        public List<LagerBestandDto> GetLagerBestandDto()
        {
            throw new NotImplementedException();
        }

        public List<LoginDto> GetLoginDto()
        {
            throw new NotImplementedException();
        }

        public List<MaschineDto> GetMaschineDto()
        {
            throw new NotImplementedException();
        }

        public List<MaschineVerwendungDto> GetMaschineVerwendungDto()
        {
            throw new NotImplementedException();
        }

        public List<MFFertigungDto> GetMFFertigungDto()
        {
            throw new NotImplementedException();
        }

        public List<NachrichtDto> GetNarichtenFromUser()
        {
            throw new NotImplementedException();
        }

        public List<NachrichtDto> GetNarichtenFromUser(int UserID, DateTime fromDate)
        {
            throw new NotImplementedException();
        }

        public List<ProduktionsplanDto> GetProduktionsplanDto()
        {
            throw new NotImplementedException();
        }

        public List<ReparaturDto> GetReparaturDto()
        {
            throw new NotImplementedException();
        }

        public List<UserAnfrageDto> GetUserAnfrageDto()
        {
            throw new NotImplementedException();
        }

        public List<UserDto> GetUserDto()
        {
            throw new NotImplementedException();
        }

        public List<WartungDto> GetWartungDto()
        {
            throw new NotImplementedException();
        }

        public List<KeyValueHelper> GetTypeObjects(string type)
        {
            throw new NotImplementedException();
        }

        public List<UserDto> GetUserDto(bool needlogin)
        {
            throw new NotImplementedException();
        }

        public List<ArbeitsfolgeDto> GetArbeitsfolgeDto()
        {
            throw new NotImplementedException();
        }
    }
}
