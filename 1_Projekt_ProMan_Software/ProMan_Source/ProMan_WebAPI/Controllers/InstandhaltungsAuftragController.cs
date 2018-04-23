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
        public IHttpActionResult Post([FromBody]InstandhaltungsAuftragDto value)
        {
            dataprovider.CreateDataProvider.SetInstandhaltungsAuftragDto(value);
            return Ok();
        }

        // PUT: api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody]InstandhaltungsAuftragDto value)
        {
            dataprovider.UpdateDataProvider.UpdateInstandhaltungsAuftragDto(value, id);
            return Ok();
        }

        // PUT: api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody]List<InstandhaltungsAuftragDto> value)
        {
            foreach (var item in value)
            {
                Put(id, value);
            }
            return Ok();

        }

        // DELETE: api/<controller>/5
        public IHttpActionResult Delete(int id)
        {
            dataprovider.DeleteDataProvider.DeleteInstandhaltungsAuftragDto(id);
            return Ok();
        }
    }

}
