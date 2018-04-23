///////////////////////////////
//Autor Sebastian Molkenthin
//Martikelnummer : 396734
//Team: ProMan
///////////////////////////////
using ProMan_BusinessLayer.DataProvider;
using System.Configuration;
using System.Web.Http;

namespace ProMan_WebAPI.Base
{
    public abstract class BaseApiController : ApiController
    {
        protected IDataProvider dataprovider = new DataProviderFactory(ConfigurationManager.AppSettings["DataProvider"]).data;
    }
}