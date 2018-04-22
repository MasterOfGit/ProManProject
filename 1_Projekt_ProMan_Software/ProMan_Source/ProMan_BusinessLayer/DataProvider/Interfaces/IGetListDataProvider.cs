using ProMan_BusinessLayer.Models;
using ProMan_BusinessLayer.Models.Maschinenfuehrer;
using System;
using System.Collections.Generic;

namespace ProMan_BusinessLayer.DataProvider.Interfaces
{
    /// <summary>
    /// Interface to get a list of multiple objects from the datastructure
    /// </summary>
    public interface IGetListDataProvider
    {
        /// <summary>
        /// Returns a list of all Fertigungsobjects
        /// </summary>
        /// <returns></returns>
        List<BauteilDto> GetBauteilDto();
        /// <summary>
        /// Returns a list of all Fertigungsobjects
        /// </summary>
        /// <returns></returns>
        List<FertigungDto> GetFertigungsDto();
        /// <summary>
        /// Returns a list of allFertigungslinieobjects
        /// </summary>
        List<FertigungslinieDto> GetFertigungslinieDto();
        /// <summary>
        /// Returns a list of all Maschineobjects
        /// </summary>
        List<MaschineDto> GetMaschineDto();
        /// <summary>
        /// Returns a list of all Reparaturobjects
        /// </summary>
        List<ReparaturDto> GetReparaturDto();
        /// <summary>
        /// Returns a list of all Userobjects
        /// </summary>
        List<UserDto> GetUserDto();
        /// <summary>
        /// Returns a list of all Userobjects
        /// </summary>
        List<UserDto> GetUserDto(bool needlogin);
        /// <summary>
        /// Returns a list of all Wartungsobjects
        /// </summary>
        List<WartungDto> GetWartungDto();
        /// <summary>
        /// Returns a list of all Abteilungobjects
        /// </summary>
        List<AbteilungDto> GetAbteilungDto();
        /// <summary>
        /// Returns a list of all Loginobjects
        /// </summary>
        List<LoginDto> GetLoginDto();

        /// <summary>
        /// Returns a list of all Loginobjects
        /// </summary>
        List<ArbeitsfolgeDto> GetArbeitsfolgeDto();
        /// <summary>
        /// Returns a list of all Nachrichtenobjects
        /// </summary>
        List<NachrichtDto> GetNarichtenFromUser();
        /// <summary>
        /// Returns a list of all Nachrichten objects from a specific user
        /// </summary>
        List<NachrichtDto> GetNarichtenFromUser(int UserID, DateTime fromDate);

        List<AuditDto> GetAuditDto();

        List<BauteilVerwendungDto> GetBauteilVerwendungDto();

        List<InstandhaltungsAuftragDto> GetInstandhaltungsAuftragDto();

        List<LagerBestandDto> GetLagerBestandDto();

        List<MaschineVerwendungDto> GetMaschineVerwendungDto();

        List<ProduktionsplanDto> GetProduktionsplanDto();

        List<UserAnfrageDto> GetUserAnfrageDto();

        List<KeyValueHelper> GetTypeObjects(string type);
        

    }
}
