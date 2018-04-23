///////////////////////////////
//Autor Sebastian Molkenthin
//Martikelnummer : 396734
//Team: ProMan
///////////////////////////////
using ProMan_BusinessLayer.DataProvider.Interfaces;

namespace ProMan_BusinessLayer.DataProvider.DummyData
{
    /// <summary>
    /// Generates dummy data for the view. Does not support setting or updating data
    /// </summary>
    public class DummyDataProvider : IDataProvider
    {
        public ICreateDataProvider CreateDataProvider => new DummyCreateData();
        public IDeleteDataProvider DeleteDataProvider => new DummyDelete();
        public IGetListDataProvider GetListDataProvider => new DummyGetList();
        public IGetSingleProvider GetSingleProvider => new DummyGetSingle();
        public IUpdateDataProvider UpdateDataProvider => new DummyUpdate();

    }
}