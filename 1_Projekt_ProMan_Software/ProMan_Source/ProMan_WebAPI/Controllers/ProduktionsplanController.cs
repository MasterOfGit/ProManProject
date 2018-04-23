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
    public class ProduktionsplanController : BaseApiController
    {
        // GET: api/<controller>
        public IEnumerable<ProduktionsplanDto> Get()
        {
            return dataprovider.GetListDataProvider.GetProduktionsplanDto();
        }

        // GET: api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            return Ok(JToken.FromObject(dataprovider.GetSingleProvider.GetProduktionsplanDto(id)));
        }

        // POST: api/<controller>
        public IHttpActionResult Post([FromBody]ProduktionsplanDto value)
        {
            dataprovider.CreateDataProvider.SetProduktionsplanDto(value);
            return Ok();
        }

        // PUT: api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody]ProduktionsplanDto value)
        {
            dataprovider.UpdateDataProvider.UpdateProduktionsplanDto(value, id);
            return Ok();
        }

        // PUT: api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody]List<ProduktionsplanDto> value)
        {
            foreach (var item in value)
            {
                Put(id, value);
            }

            return Ok();
        }

        // DELETE: api/Audit/5
        public IHttpActionResult Delete(int id)
        {
            dataprovider.DeleteDataProvider.DeleteProduktionsplanDto(id);
            return Ok();
        }
    }

}
