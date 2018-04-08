using ProMan_BusinessLayer.Models;
using ProMan_BusinessLayer.Models.Maschinenfuehrer;
using System;
using System.Collections.Generic;

namespace ProMan_BusinessLayer.DataProvider.Interfaces
{
    public interface IGetListDataProvider
    {
        List<FertigungDto> GetFertigungsDto();
        List<FertigungslinieDto> GetFertigungslinieDto();
        List<MaschineDto> GetMaschineDto();
        List<ReparaturDto> GetReparaturDto();
        List<UserDto> GetUserDto();
        List<WartungDto> GetWartungDto();
        List<AbteilungDto> GetAbteilungDto();
        List<LoginDto> GetLoginDto();
        List<NachrichtDto> GetNarichtenFromUser();

        List<NachrichtDto> GetNarichtenFromUser(int UserID, DateTime fromDate);
        List<MFFertigungDto> GetMFFertigungDto();
    }
}
