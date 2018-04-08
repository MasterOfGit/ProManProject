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
        // GET: api/Fertigung
        public IEnumerable<FertigungDto> Get()
        {
            return dataprovider.GetListDataProvider.GetFertigungsDto();
        }

        // GET: api/Fertigung/5
        public IHttpActionResult Get(int id)
        {
            return Ok(JToken.FromObject(dataprovider.GetSingleProvider.GetFertigungsDto(id)));
        }

        // POST api/<controller>
        public void Post([FromBody]FertigungDto value)
        {
            dataprovider.CreateDataProvider.SetFertigungsDto(value);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]FertigungDto value)
        {
            dataprovider.UpdateDataProvider.UpdateFertigungsDto(value, id);
        }

        // DELETE: api/Fertigung/5
        public void Delete(int id)
        {
        }
    }
}
