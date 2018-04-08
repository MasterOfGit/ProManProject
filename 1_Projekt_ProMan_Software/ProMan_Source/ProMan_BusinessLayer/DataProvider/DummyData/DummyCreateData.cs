using System;
using ProMan_BusinessLayer.DataProvider.Interfaces;
using ProMan_BusinessLayer.Models;

namespace ProMan_BusinessLayer.DataProvider.DummyData
{
    public class DummyCreateData : ICreateDataProvider
    {
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

        public bool SetNachrichtDto(NachrichtDto data)
        {
            return true;
        }

        public int SetLoginDto(LoginDto data)
        {
            return 1;
        }
        #endregion
    }
}
