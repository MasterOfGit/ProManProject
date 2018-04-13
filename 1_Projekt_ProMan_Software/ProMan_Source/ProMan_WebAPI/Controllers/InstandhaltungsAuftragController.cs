using Newtonsoft.Json.Linq;
using ProMan_BusinessLayer.Models;
using ProMan_WebAPI.Base;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ProMan_WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class InstandhaltungsAuftragController : BaseApiController
    {
        // GET: api/<controller>
        public IEnumerable<InstandhaltungsAuftragDto> Get()
        {
            return dataprovider.GetListDataProvider.GetInstandhaltungsAuftragDto();
        }

        // GET: api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            return Ok(JToken.FromObject(dataprovider.GetSingleProvider.GetInstandhaltungsAuftragDto(id)));
        }

        // POST: api/<controller>
        public void Post([FromBody]InstandhaltungsAuftragDto value)
        {
            dataprovider.CreateDataProvider.SetInstandhaltungsAuftragDto(value);
        }

        // PUT: api/<controller>/5
        public void Put(int id, [FromBody]InstandhaltungsAuftragDto value)
        {
            dataprovider.UpdateDataProvider.UpdateInstandhaltungsAuftragDto(value, id);
        }

        // PUT: api/<controller>/5
        public void Put(int id, [FromBody]List<InstandhaltungsAuftragDto> value)
        {
            foreach (var item in value)
            {
                Put(id, value);
            }


        }

        // DELETE: api/<controller>/5
        public void Delete(int id)
        {
            dataprovider.DeleteDataProvider.DeleteInstandhaltungsAuftragDto(id);
        }
    }

}
