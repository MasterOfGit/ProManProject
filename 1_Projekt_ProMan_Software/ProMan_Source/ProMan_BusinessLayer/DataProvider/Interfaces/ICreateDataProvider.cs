using ProMan_BusinessLayer.Models;

namespace ProMan_BusinessLayer.DataProvider.Interfaces
{
    public interface ICreateDataProvider
    {
        bool SetFertigungsDto(FertigungDto data);
        bool SetFertigungslinieDto(FertigungslinieDto data);
        bool SetMaschineDto(MaschineDto data);
        bool SetReparaturDto(ReparaturDto data);
        bool SetUserDto(UserDto data);
        bool SetWartungDto(WartungDto data);
        bool SetAbteilungDto(AbteilungDto data);
        bool SetNachrichtDto(NachrichtDto data);
        int SetLoginDto(LoginDto data);
    }
}
