using ProMan_BusinessLayer.Models;
using ProMan_BusinessLayer.Models.AdminPages;
using ProMan_BusinessLayer.Models.Maschinenfuehrer;

namespace ProMan_BusinessLayer.DataProvider.Interfaces
{
    public interface IGetSingleProvider
    {
        FertigungDto GetFertigungsDto(int id);
        FertigungslinieDto GetFertigungslinieDto(int id);
        MaschineDto GetMaschineDto(int id);
        ReparaturDto GetReparaturDto(int id);
        UserDto GetUserDto(int id);
        WartungDto GetWartungDto(int id);
        AbteilungDto GetAbteilungDto(int id);
        NachrichtDto GetNachrichtDto(int id);
        LoginDto GetLoginDto(int id);
        LoginDto GetLoginDto(string username, string password);

        AdminPageUserDto GetAdminPageUserDto();
        AdminPageAbteilungDto GetAdminPageAbteilungDto();
        AdminPageBauteilDto GetAdminPageBauteilDto();
        AdminPageFertigungDto GetAdminPageFertigungDto();
        AdminPageFertigungslinieDto GetAdminPageFertigungslinieDto();
        AdminPageMaschineDto GetAdminPageMaschineDto();

        MFInstandhaltung GetMFInstandhaltung();
        MFAbteilungOverviewDto GetMFAbteilungOverviewDto(int id);
        MFLinieDto GetMFLinieDto(int id);
    }
}
