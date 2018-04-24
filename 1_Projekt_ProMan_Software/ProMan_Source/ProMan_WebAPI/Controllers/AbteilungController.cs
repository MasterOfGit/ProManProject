///////////////////////////////
//Autor Sebastian Molkenthin
//Martikelnummer : 396734
//Team: ProMan
///////////////////////////////
using Newtonsoft.Json.Linq;
using ProMan_BusinessLayer.Models;
using ProMan_WebAPI.Base;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ProMan_WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("abteilung")]
    public class AbteilungController : BaseApiController
    {
        // GET: api/<controller>
        public IEnumerable<AbteilungDto> Get()
        {
            return dataprovider.GetListDataProvider.GetAbteilungDto();
        }

        // GET: api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            return Ok(JToken.FromObject(dataprovider.GetSingleProvider.GetAbteilungDto(id)));
        }

        [Route("create")]
        [HttpPost]
        public IHttpActionResult Create(string value)
        {
            AbteilungDto result = Newtonsoft.Json.JsonConvert.DeserializeObject<AbteilungDto>(value);
            dataprovider.CreateDataProvider.SetAbteilungDto(result);
            return Ok();
        }

        [Route("update")]
        [HttpPost]
        public IHttpActionResult Update(int id, string value)
        {
            AbteilungDto result = Newtonsoft.Json.JsonConvert.DeserializeObject<AbteilungDto>(value);
            dataprovider.UpdateDataProvider.UpdateAbteilungDto(result, id);
            return Ok();
        }

        [Route("remove")]
        [HttpPost]
        public IHttpActionResult Remove(int id)
        {
            dataprovider.DeleteDataProvider.DeleteAbteilungDto(id);
            return Ok();
        }
    }
}
