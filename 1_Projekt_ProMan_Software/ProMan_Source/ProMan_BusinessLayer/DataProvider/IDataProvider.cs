using ProMan_BusinessLayer.Models;
using ProMan_BusinessLayer.Models.AdminPages;
using ProMan_BusinessLayer.Models.Maschinenfuehrer;
using System.Collections.Generic;

namespace ProMan_BusinessLayer.DataProvider
{
    /// <summary>
    /// Interface to be implement to provide data
    /// </summary>
    public interface IDataProvider
    {
        FertigungDto GetFertigungsDto(int id);
        bool SetFertigungsDto(FertigungDto data);
        bool UpdateFertigungsDto(FertigungDto data, int id);

        FertigungslinieDto GetFertigungslinieDto(int id);
        bool SetFertigungslinieDto(FertigungslinieDto data);
        bool UpdateFertigungslinieDto(FertigungslinieDto data, int id);

        MaschineDto GetMaschineDto(int id);
        bool SetMaschineDto(MaschineDto data);
        bool UpdateMaschineDto(MaschineDto data, int id);

        ReparaturDto GetReparaturDto(int id);
        bool SetReparaturDto(ReparaturDto data);
        bool UpdateReparaturDto(ReparaturDto data, int id);

        UserDto GetUserDto(int id);
        bool SetUserDto(UserDto data);
        bool UpdateUserDto(UserDto data, int id);

        WartungDto GetWartungDto(int id);
        bool SetWartungDto(WartungDto data);
        bool UpdateWartungDto(WartungDto data, int id);

        AbteilungDto GetAbteilungDto(int id);
        bool SetAbteilungDto(AbteilungDto data);
        bool UpdateAbteilungDto(AbteilungDto data, int id);

        NachrichtDto GetNachrichtDto(int id);
        bool SetNachrichtDto(NachrichtDto data);
        bool UpdateNachrichtDto(NachrichtDto data, int id);

        LoginDto GetLoginDto(int id);
        LoginDto GetLoginDto(string username, string password);
        bool SetLoginDto(LoginDto data);
        bool UpdateLoginDto(LoginDto data, int id);

        AdminPageUserDto GetAdminPageUserDto();
        AdminPageAbteilungDto GetAdminPageAbteilungDto();
        AdminPageBauteilDto GetAdminPageBauteilDto();
        AdminPageFertigungDto GetAdminPageFertigungDto();
        AdminPageFertigungslinieDto GetAdminPageFertigungslinieDto();
        AdminPageMaschineDto GetAdminPageMaschineDto();

        List<MFFertigungDto> GetMFFertigungDto();
        MFInstandhaltung GetMFInstandhaltung();
        MFAbteilungOverviewDto GetMFAbteilungOverviewDto(int id);
        MFLinieDto GetMFLinieDto(int id);
    }
}
