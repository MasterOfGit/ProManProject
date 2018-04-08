using ProMan_BusinessLayer.DataProvider.Interfaces;

namespace ProMan_BusinessLayer.DataProvider
{
    /// <summary>
    /// Interface to be implement to provide data
    /// </summary>
    public interface IDataProvider
    {
        ICreateDataProvider CreateDataProvider { get; }
        IGetSingleProvider GetSingleProvider { get; }
        IGetListDataProvider GetListDataProvider { get; }
        IDeleteDataProvider DeleteDataProvider { get; }
        IUpdateDataProvider UpdateDataProvider { get; }

    }
}
