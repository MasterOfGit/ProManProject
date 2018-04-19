using Newtonsoft.Json.Linq;
using ProMan_BusinessLayer.Models;
using ProMan_WebAPI.Base;
using System.Collections.Generic;
using System.IO;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ProMan_WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class BauteilController : BaseApiController
    {
        // GET: api/<controller>
        public IEnumerable<BauteilDto> Get()
        {
            return dataprovider.GetListDataProvider.GetBauteilDto();
        }

        // GET: api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            return Ok(JToken.FromObject(dataprovider.GetSingleProvider.GetBauteilDto(id)));
        }

        // POST: api/<controller>
        public IHttpActionResult Post([FromBody]BauteilDto value)
        {
            dataprovider.CreateDataProvider.SetBauteilDto(value);
            return Ok();
        }

        // PUT: api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody]BauteilDto value)
        {
            dataprovider.UpdateDataProvider.UpdateBauteilDto(value, id);
            return Ok();
        }

        // DELETE: api/<controller>/5
        public IHttpActionResult Delete(int id)
        {
            dataprovider.DeleteDataProvider.DeleteBauteilDto(id);
            return Ok();
        }
    }
}
