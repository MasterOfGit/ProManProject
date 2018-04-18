using Newtonsoft.Json.Linq;
using ProMan_BusinessLayer.Models;
using ProMan_WebAPI.Base;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ProMan_WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class FertigungController : BaseApiController
    {
        // GET: api/<controller>
        public IEnumerable<FertigungDto> Get()
        {
            return dataprovider.GetListDataProvider.GetFertigungsDto();
        }

        // GET: api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            return Ok(JToken.FromObject(dataprovider.GetSingleProvider.GetFertigungsDto(id)));
        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody]FertigungDto value)
        {
            dataprovider.CreateDataProvider.SetFertigungsDto(value);
            return Ok();
        }

        // PUT api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody]FertigungDto value)
        {
            dataprovider.UpdateDataProvider.UpdateFertigungsDto(value, id);
            return Ok();
        }

        // DELETE: api/<controller>/5
        public IHttpActionResult Delete(int id)
        {
            dataprovider.DeleteDataProvider.DeleteFertigungsDto(id);
            return Ok();
        }
    }
}
