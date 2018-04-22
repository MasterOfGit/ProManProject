namespace ProMan_BusinessLayer.DataProvider.Interfaces
{
    /// <summary>
    /// Interface to delete objects on the datastructure
    /// </summary>
    public interface IDeleteDataProvider
    {
        /// <summary>
        /// Deletes a object of type 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteBauteilDto(int id);
        /// <summary>
        /// Deletes a object of type 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteFertigungsDto(int id);
        /// <summary>
        /// Deletes a object of type 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteFertigungslinieDto(int id);
        /// <summary>
        /// Deletes a object of type 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteMaschineDto(int id);
        /// <summary>
        /// Deletes a object of type 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteReparaturDto(int id);
        /// <summary>
        /// Deletes a object of type 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteUserDto(int id);
        /// <summary>
        /// Deletes a object of type 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteWartungDto(int id);
        /// <summary>
        /// Deletes a object of type 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteAbteilungDto(int id);
        /// <summary>
        /// Deletes a object of type 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteNachrichtDto(int id);
        /// <summary>
        /// Deletes a object of type 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteLoginDto(int id);
        /// <summary>
        /// Deletes a object of type 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteAuditDto(int id);
        /// <summary>
        /// Deletes a object of type 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteBauteilVerwendungDto(int id);
        /// <summary>
        /// Deletes a object of type 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteInstandhaltungsAuftragDto(int id);
        /// <summary>
        /// Deletes a object of type 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteLagerBestandDto(int id);
        /// <summary>
        /// Deletes a object of type 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteMaschineVerwendungDto(int id);
        /// <summary>
        /// Deletes a object of type 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteProduktionsplanDto(int id);
        /// <summary>
        /// Deletes a object of type 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteUserAnfrageDto(int id);

        void RemoteObject(string type, int parent, int id);
    }
}
