///////////////////////////////
//Autor Sebastian Molkenthin
//Martikelnummer : 396734
//Team: ProMan
///////////////////////////////
using System.Collections.Generic;
using System.Web.Http;
using Newtonsoft.Json.Linq;
using System.Web.Http.Cors;
using ProMan_BusinessLayer.Models;
using ProMan_WebAPI.Base;

namespace ProMan_WebAPI.Controllers
{
    [RoutePrefix("fertigungslinie")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class FertigungslinieController : BaseApiController
    {

        // GET api/<controller>
        public IEnumerable<FertigungslinieDto> Get()
        {
            return dataprovider.GetListDataProvider.GetFertigungslinieDto();
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {


            return Ok(JToken.FromObject(dataprovider.GetSingleProvider.GetFertigungslinieDto(id)));
        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody]FertigungslinieDto value)
        {
            dataprovider.CreateDataProvider.SetFertigungslinieDto(value);
            return Ok();
        }

        // PUT api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody]FertigungslinieDto value)
        {
            dataprovider.UpdateDataProvider.UpdateFertigungslinieDto(value, id);
            return Ok();
        }

        // DELETE api/<controller>/5
        public IHttpActionResult Delete(int id)
        {
            dataprovider.DeleteDataProvider.DeleteFertigungslinieDto(id);
            return Ok();
        }
    }
}