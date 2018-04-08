using ProMan_BusinessLayer.DataProvider.Interfaces;
using ProMan_Database;

namespace ProMan_BusinessLayer.DataProvider.DBData
{
    public class DatabaseDelete : IDeleteDataProvider
    {
        ProManContext dbcontext = new ProManContext();
    }
}
