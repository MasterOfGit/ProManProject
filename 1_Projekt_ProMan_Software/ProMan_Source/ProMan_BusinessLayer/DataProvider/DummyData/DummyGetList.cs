using System;
using System.Collections.Generic;
using ProMan_BusinessLayer.DataProvider.Interfaces;
using ProMan_BusinessLayer.Models;
using ProMan_BusinessLayer.Models.Maschinenfuehrer;

namespace ProMan_BusinessLayer.DataProvider.DummyData
{
    public class DummyGetList : IGetListDataProvider
    {
        public List<AbteilungDto> GetAbteilungDto()
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

        public List<LoginDto> GetLoginDto()
        {
            throw new NotImplementedException();
        }

        public List<MaschineDto> GetMaschineDto()
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

        public List<ReparaturDto> GetReparaturDto()
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
    }
}
