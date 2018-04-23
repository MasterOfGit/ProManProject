///////////////////////////////
//Autor Sebastian Molkenthin
//Martikelnummer : 396734
//Team: ProMan
///////////////////////////////
using ProMan_BusinessLayer.DataProvider.DBData;
using ProMan_BusinessLayer.DataProvider.DummyData;

namespace ProMan_BusinessLayer.DataProvider
{
    /// <summary>
    /// Factory object to switch between dummy and db data
    /// </summary>
    public class DataProviderFactory
    {
        public IDataProvider data;

        public DataProviderFactory(string provider)
        {
            if (provider == "Dummy")
                data = new DummyDataProvider();
            else
                data = new DatabaseDataProvider();
        }
    }
}