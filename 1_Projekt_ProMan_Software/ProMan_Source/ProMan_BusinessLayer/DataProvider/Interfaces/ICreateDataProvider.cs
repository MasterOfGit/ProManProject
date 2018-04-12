using ProMan_BusinessLayer.Models;

namespace ProMan_BusinessLayer.DataProvider.Interfaces
{
    /// <summary>
    /// Interface to create object in the datastructure
    /// </summary>
    public interface ICreateDataProvider
    {
        /// <summary>
        /// Creates a new Fertigungs object in the datastructure
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        int SetFertigungsDto(FertigungDto data);
        /// <summary>
        /// Creates a new Fertigungs object in the datastructure
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        int SetFertigungslinieDto(FertigungslinieDto data);
        /// <summary>
        /// Creates a new Maschine object in the datastructure
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        int SetMaschineDto(MaschineDto data);
        /// <summary>
        /// Creates a new Reparatur object in the datastructure
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        int SetReparaturDto(ReparaturDto data);
        /// <summary>
        /// Creates a new User object in the datastructure
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        int SetUserDto(UserDto data);
        /// <summary>
        /// Creates a new Wartung object in the datastructure
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        int SetWartungDto(WartungDto data);
        /// <summary>
        /// Creates a new Abteilung object in the datastructure
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        int SetAbteilungDto(AbteilungDto data);
        /// <summary>
        /// Creates a new Nachricht object in the datastructure
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        int SetNachrichtDto(NachrichtDto data);
        /// <summary>
        /// Creates a new Login object in the datastructure
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        int SetLoginDto(LoginDto data);

        int SetAuditDto(AuditDto data);
        int SetBauteilVerwendungDto(BauteilVerwendungDto data);
        int SetInstandhaltungsAuftragDto(InstandhaltungsAuftragDto data);
        int SetLagerBestandDto(LagerBestandDto data);
        int SetMaschineVerwendungDto(MaschineVerwendungDto data);
        int SetProduktionsplanDto(ProduktionsplanDto data);
        int SetUserAnfrageDto(UserAnfrageDto data);
    }
}
