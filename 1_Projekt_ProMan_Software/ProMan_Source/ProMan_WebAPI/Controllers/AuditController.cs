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
    public class AuditController : BaseApiController
    {
        // GET: api/<controller>
        public IEnumerable<AuditDto> Get()
        {
            return dataprovider.GetListDataProvider.GetAuditDto();
        }

        // GET: api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            return Ok(JToken.FromObject(dataprovider.GetSingleProvider.GetAuditDto(id)));
        }

        // POST: api/<controller>
        public IHttpActionResult Post([FromBody]AuditDto value)
        {
            dataprovider.CreateDataProvider.SetAuditDto(value);
            return Ok();
        }

        // PUT: api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody]AuditDto value)
        {
            dataprovider.UpdateDataProvider.UpdateAuditDto(value, id);
            return Ok();
        }

        // PUT: api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody]List<AuditDto> value)
        {
            foreach(var item in value)
            {
                Put(id, value);
            }
            return Ok();

        }

        // DELETE: api/<controller>/5
        public IHttpActionResult Delete(int id)
        {
            dataprovider.DeleteDataProvider.DeleteAuditDto(id);
            return Ok();
        }
    }
}
