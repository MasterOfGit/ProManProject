using ProMan_BusinessLayer.Models;

namespace ProMan_BusinessLayer.DataProvider.Interfaces
{
    /// <summary>
    /// Interface to update a single object in the datastructure
    /// </summary>
    public interface IUpdateDataProvider
    {
        bool UpdateFertigungsDto(FertigungDto data, int id);
        bool UpdateFertigungslinieDto(FertigungslinieDto data, int id);
        bool UpdateBauteilDto(BauteilDto data, int id);
        bool UpdateMaschineDto(MaschineDto data, int id);
        bool UpdateReparaturDto(ReparaturDto data, int id);
        bool UpdateUserDto(UserDto data, int id);
        bool UpdateWartungDto(WartungDto data, int id);
        bool UpdateAbteilungDto(AbteilungDto data, int id);
        bool UpdateNachrichtDto(NachrichtDto data, int id);
        bool UpdateLoginDto(LoginDto data, int id);

        bool UpdateAuditDto(AuditDto data, int id);
        bool UpdateBauteilVerwendungDto(BauteilVerwendungDto data, int id);
        bool UpdateInstandhaltungsAuftragDto(InstandhaltungsAuftragDto data, int id);
        bool UpdateLagerBestandDto(LagerBestandDto data, int id);
        bool UpdateMaschineVerwendungDto(MaschineVerwendungDto data, int id);
        bool UpdateProduktionsplanDto(ProduktionsplanDto data, int id);
        bool UpdateUserAnfrageDto(UserAnfrageDto data, int id);
    }
}
