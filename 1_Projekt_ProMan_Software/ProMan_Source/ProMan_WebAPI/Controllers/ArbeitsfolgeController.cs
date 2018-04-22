using Newtonsoft.Json.Linq;
using ProMan_BusinessLayer.Models;
using ProMan_WebAPI.Base;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ProMan_WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ArbeitsfolgeController : BaseApiController
    {
        // GET: api/<controller>
        public IEnumerable<ArbeitsfolgeDto> Get()
        {
            return dataprovider.GetListDataProvider.GetArbeitsfolgeDto();
        }

        // GET: api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            return Ok(JToken.FromObject(dataprovider.GetSingleProvider.GetArbeitsfolgeDto(id)));
        }

        // POST: api/<controller>
        public IHttpActionResult Post([FromBody]ArbeitsfolgeDto value)
        {
            dataprovider.CreateDataProvider.SetArbeitsfolgeDto(value);
            return Ok();
        }

        // PUT: api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody]ArbeitsfolgeDto value)
        {
            dataprovider.UpdateDataProvider.UpdateArbeitsfolgeDto(value,id);
            return Ok();
        }

        // DELETE: api/<controller>/5
        public IHttpActionResult Delete(int id)
        {
            dataprovider.DeleteDataProvider.DeleteArbeitsfolgeDto(id);
            return Ok();
        }
    }
}
