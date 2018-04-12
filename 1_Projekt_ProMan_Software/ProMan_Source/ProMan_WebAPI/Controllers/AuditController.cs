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
        // GET: api/Audit
        public IEnumerable<AuditDto> Get()
        {
            return dataprovider.GetListDataProvider.GetAuditDto();
        }

        // GET: api/Audit/5
        public IHttpActionResult Get(int id)
        {
            return Ok(JToken.FromObject(dataprovider.GetSingleProvider.GetAuditDto(id)));
        }

        // POST: api/Audit
        public void Post([FromBody]AuditDto value)
        {
            dataprovider.CreateDataProvider.SetAuditDto(value);
        }

        // PUT: api/Audit/5
        public void Put(int id, [FromBody]AuditDto value)
        {
            dataprovider.UpdateDataProvider.UpdateAuditDto(value, id);
        }

        // PUT: api/Audit/5
        public void Put(int id, [FromBody]List<AuditDto> value)
        {
            foreach(var item in value)
            {
                Put(id, value);
            }

            
        }

        // DELETE: api/Audit/5
        public void Delete(int id)
        {
            dataprovider.DeleteDataProvider.DeleteAuditDto(id);
        }
    }
}
