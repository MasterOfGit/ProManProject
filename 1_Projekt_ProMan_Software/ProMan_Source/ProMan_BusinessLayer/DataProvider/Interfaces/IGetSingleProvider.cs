using ProMan_BusinessLayer.Models;
using ProMan_BusinessLayer.Models.AdminPages;
using ProMan_BusinessLayer.Models.Maschinenfuehrer;

namespace ProMan_BusinessLayer.DataProvider.Interfaces
{
    /// <summary>
    /// Interface to get a single object(or containing multiple objects) from the datastructure
    /// </summary>
    public interface IGetSingleProvider
    {
        /// <summary>
        /// Returns a list of  single Fertigungsobject
        /// </summary>
        /// <returns></returns>
        BauteilDto GetBauteilDto(int id);

        /// <summary>
        /// Returns a list of  single Fertigungsobject
        /// </summary>
        /// <returns></returns>
        FertigungDto GetFertigungsDto(int id);
        /// <summary>
        /// Returns a list of  singleFertigungslinieobject
        /// </summary>
        /// <returns></returns>
        FertigungslinieDto GetFertigungslinieDto(int id);
        /// <summary>
        /// Returns a list of  single FMaschineobject
        /// </summary>
        /// <returns></returns>
        MaschineDto GetMaschineDto(int id);
        /// <summary>
        /// Returns a list of  single Reparaturobject
        /// </summary>
        /// <returns></returns>
        ReparaturDto GetReparaturDto(int id);
        /// <summary>
        /// Returns a list of  singleUsersobject
        /// </summary>
        /// <returns></returns>
        UserDto GetUserDto(int id);
        /// <summary>
        /// Returns a list of  single Wartungobject
        /// </summary>
        /// <returns></returns>
        WartungDto GetWartungDto(int id);
        /// <summary>
        /// Returns a list of  single tAbteilungobject
        /// </summary>
        /// <returns></returns>
        AbteilungDto GetAbteilungDto(int id);
        /// <summary>
        /// Returns a list of  single Nachrichtobject
        /// </summary>
        /// <returns></returns>
        NachrichtDto GetNachrichtDto(int id);
        /// <summary>
        /// Returns a list of  single tLoginobject
        /// </summary>
        /// <returns></returns>
        LoginDto GetLoginDto(int id);
        /// <summary>
        /// Returns a list of  single tLoginobject
        /// </summary>
        /// <returns></returns>
        LoginDto GetLoginDto(string username, string password);

        AuditDto GetAuditDto(int id);

        BauteilVerwendungDto GetBauteilVerwendungDto(int id);

        InstandhaltungsAuftragDto GetInstandhaltungsAuftragDto(int id);

        LagerBestandDto GetLagerBestandDto(int id);

        MaschineVerwendungDto GetMaschineVerwendungDto(int id);

        ProduktionsplanDto GetProduktionsplanDto(int id);

        UserAnfrageDto GetUserAnfrageDto(int id);


        /// <summary>
        /// Builds the complete object for the UserAdminPage
        /// </summary>
        /// <returns></returns>
        AdminPageUserDto GetAdminPageUserDto();
        /// <summary>
        /// Builds the complete object for the AbteilungAdminPage
        /// </summary>
        /// <returns></returns>
        AdminPageAbteilungDto GetAdminPageAbteilungDto();
        /// <summary>
        /// Builds the complete object for the BauteilAdminPage
        /// </summary>
        /// <returns></returns>
        AdminPageBauteilDto GetAdminPageBauteilDto();
        /// <summary>
        /// Builds the complete object for the FertigungAdminPage
        /// </summary>
        /// <returns></returns>
        AdminPageFertigungDto GetAdminPageFertigungDto();
        /// <summary>
        /// Builds the complete object for the FertigungslinieAdminPage
        /// </summary>
        /// <returns></returns>
        AdminPageFertigungslinieDto GetAdminPageFertigungslinieDto();
        /// <summary>
        /// Builds the complete object for the MaschineAdminPage
        /// </summary>
        /// <returns></returns>
        AdminPageMaschineDto GetAdminPageMaschineDto();

        /// <summary>
        /// Builds the complete object for the MFInstandhaltungPage
        /// </summary>
        /// <returns></returns>
        MFInstandhaltung GetMFInstandhaltung();
        /// <summary>
        /// Builds the complete object for the MFAbteilungOverview
        /// </summary>
        /// <returns></returns>
        MFAbteilungOverviewDto GetMFAbteilungOverviewDto(int id);
        /// <summary>
        /// Builds the complete object for the MFLinie
        /// </summary>
        /// <returns></returns>
        MFLinieDto GetMFLinieDto(int id);
    }
}
