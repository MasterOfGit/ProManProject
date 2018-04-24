///////////////////////////////
//Autor Sebastian Molkenthin
//Martikelnummer : 396734
//Team: ProMan
///////////////////////////////
using Newtonsoft.Json.Linq;
using ProMan_BusinessLayer.Models;
using ProMan_WebAPI.Base;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ProMan_WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("arbeitsfolge")]
    public class ArbeitsfolgeController : BaseApiController
    {
        // GET: api/<controller>
        public IHttpActionResult Get()
        {
            return Ok(JToken.FromObject(dataprovider.GetListDataProvider.GetArbeitsfolgeDto()));
        }

        // GET: api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            return Ok(JToken.FromObject(dataprovider.GetSingleProvider.GetArbeitsfolgeDto(id)));
        }

        [Route("create")]
        [HttpPost]
        public IHttpActionResult Create(string value)
        {
            ArbeitsfolgeDto result = Newtonsoft.Json.JsonConvert.DeserializeObject<ArbeitsfolgeDto>(value);
            dataprovider.CreateDataProvider.SetArbeitsfolgeDto(result);
            return Ok();
        }

        [Route("update")]
        [HttpPost]
        public IHttpActionResult Update(int id, string value)
        {
            ArbeitsfolgeDto result = Newtonsoft.Json.JsonConvert.DeserializeObject<ArbeitsfolgeDto>(value);
            dataprovider.UpdateDataProvider.UpdateArbeitsfolgeDto(result, id);
            return Ok();
        }

        [Route("remove")]
        [HttpPost]
        public IHttpActionResult Remove(int id)
        {
            dataprovider.DeleteDataProvider.DeleteArbeitsfolgeDto(id);
            return Ok();
        }
    }
}
