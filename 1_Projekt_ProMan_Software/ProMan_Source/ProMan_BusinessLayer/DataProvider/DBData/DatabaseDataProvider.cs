///////////////////////////////
//Autor Sebastian Molkenthin
//Martikelnummer : 396734
//Team: ProMan
///////////////////////////////
using ProMan_BusinessLayer.DataProvider.Interfaces;

namespace ProMan_BusinessLayer.DataProvider.DBData
{
    public class DatabaseDataProvider : IDataProvider
    {
        public ICreateDataProvider CreateDataProvider => new DatabaseCreateData();
        public IDeleteDataProvider DeleteDataProvider => new DatabaseDelete();
        public IGetListDataProvider GetListDataProvider => new DatabaseGetList();
        public IGetSingleProvider GetSingleProvider => new DatabaseGetSingle();
        public IUpdateDataProvider UpdateDataProvider => new DatabaseUpdate();
    }
}