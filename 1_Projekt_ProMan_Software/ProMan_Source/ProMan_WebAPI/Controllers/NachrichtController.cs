using Newtonsoft.Json.Linq;
using ProMan_BusinessLayer.Models;
using ProMan_WebAPI.Base;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ProMan_WebAPI.Controllers
{
    [RoutePrefix("nachricht")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class NachrichtController : BaseApiController
    {
        // GET: api/Nachricht
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Nachricht/5
        public IHttpActionResult Get(int id)
        {
            return Ok(JToken.FromObject(dataprovider.GetNachrichtDto(id)));
        }

        // POST: api/Nachricht
        public void Post([FromBody]NachrichtDto value)
        {
            dataprovider.SetNachrichtDto(value);
        }

        // PUT: api/Nachricht/5
        public void Put(int id, [FromBody]NachrichtDto value)
        {
            dataprovider.UpdateNachrichtDto(value,id);
        }

        // DELETE: api/Nachricht/5
        public void Delete(int id)
        {
        }
    }
}
