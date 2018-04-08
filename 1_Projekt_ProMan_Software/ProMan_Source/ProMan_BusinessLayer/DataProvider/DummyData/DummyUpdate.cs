using System;
using ProMan_BusinessLayer.DataProvider.Interfaces;
using ProMan_BusinessLayer.Models;

namespace ProMan_BusinessLayer.DataProvider.DummyData
{
    public class DummyUpdate : IUpdateDataProvider
    
    {
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

        public bool UpdateNachrichtDto(NachrichtDto data, int id)
        {
            return true;
        }

        public bool UpdateLoginDto(LoginDto data, int id)
        {
            return true;
        }



        #endregion
    }
}
