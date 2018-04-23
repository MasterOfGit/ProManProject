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
    [RoutePrefix("bauteilverwendung")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class BauteilVerwendungController : BaseApiController
    {
        // GET: api/<controller>
        public IEnumerable<BauteilVerwendungDto> Get()
        {
            return dataprovider.GetListDataProvider.GetBauteilVerwendungDto();
        }

        // GET: api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            return Ok(JToken.FromObject(dataprovider.GetSingleProvider.GetBauteilVerwendungDto(id)));
        }

        // POST: api/<controller>
        public IHttpActionResult Post([FromBody]BauteilVerwendungDto value)
        {
            dataprovider.CreateDataProvider.SetBauteilVerwendungDto(value);
            return Ok();
        }

        // PUT: api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody]BauteilVerwendungDto value)
        {
            dataprovider.UpdateDataProvider.UpdateBauteilVerwendungDto(value, id);
            return Ok();
        }

        // PUT: api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody]List<BauteilVerwendungDto> value)
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
            dataprovider.DeleteDataProvider.DeleteBauteilVerwendungDto(id);
            return Ok();
        }
    }

}
