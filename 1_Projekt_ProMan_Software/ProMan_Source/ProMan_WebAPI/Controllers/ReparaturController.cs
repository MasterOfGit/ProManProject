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
    [RoutePrefix("reparatur")]
    public class ReparaturController : BaseApiController
    {
        // GET: api/<controller>
        public IHttpActionResult Get()
        {
            return Ok(JToken.FromObject(dataprovider.GetListDataProvider.GetReparaturDto()));
        }

        // GET: api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            return Ok(JToken.FromObject(dataprovider.GetSingleProvider.GetReparaturDto(id)));
        }

        [Route("create")]
        [HttpPost]
        public IHttpActionResult Create(string value)
        {
            ReparaturDto result = Newtonsoft.Json.JsonConvert.DeserializeObject<ReparaturDto>(value);
            dataprovider.CreateDataProvider.SetReparaturDto(result);
            return Ok();
        }

        [Route("update")]
        [HttpPost]
        public IHttpActionResult Update(int id, string value)
        {
            ReparaturDto result = Newtonsoft.Json.JsonConvert.DeserializeObject<ReparaturDto>(value);
            dataprovider.UpdateDataProvider.UpdateReparaturDto(result, id);
            return Ok();
        }

        [Route("remove")]
        [HttpPost]
        public IHttpActionResult Remove(int id)
        {
            dataprovider.DeleteDataProvider.DeleteReparaturDto(id);
            return Ok();
        }
    }
}
