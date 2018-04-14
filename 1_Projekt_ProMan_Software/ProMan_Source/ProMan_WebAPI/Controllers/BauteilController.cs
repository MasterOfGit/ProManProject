using Newtonsoft.Json.Linq;
using ProMan_BusinessLayer.Models;
using ProMan_WebAPI.Base;
using System.Collections.Generic;
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
        public void Post([FromBody]BauteilDto value)
        {
            dataprovider.CreateDataProvider.SetBauteilDto(value);
        }

        // PUT: api/<controller>/5
        public void Put(int id, [FromBody]BauteilDto value)
        {
            dataprovider.UpdateDataProvider.UpdateBauteilDto(value, id);
        }

        // DELETE: api/<controller>/5
        public void Delete(int id)
        {
            dataprovider.DeleteDataProvider.DeleteBauteilDto(id);
        }
    }
}
