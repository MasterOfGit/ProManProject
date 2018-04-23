///////////////////////////////
//Autor Sebastian Molkenthin
//Martikelnummer : 396734
//Team: ProMan
///////////////////////////////
using System.Collections.Generic;
using System.Web.Http;
using Newtonsoft.Json.Linq;
using System.Web.Http.Cors;
using ProMan_BusinessLayer.DataProvider;
using ProMan_BusinessLayer.Models;
using ProMan_WebAPI.Base;

namespace ProMan_WebAPI.Controllers
{
    [RoutePrefix("reparatur")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ReparaturController : BaseApiController
    {

        // GET api/<controller>
        public IEnumerable<ReparaturDto> Get()
        {
            return dataprovider.GetListDataProvider.GetReparaturDto(); ;
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            return Ok(JToken.FromObject(dataprovider.GetSingleProvider.GetReparaturDto(id)));
        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody]ReparaturDto value)
        {
            dataprovider.CreateDataProvider.SetReparaturDto(value);
            return Ok();
        }

        // PUT api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody]ReparaturDto value)
        {
            dataprovider.UpdateDataProvider.UpdateReparaturDto(value, id);
            return Ok();
        }

        // DELETE api/<controller>/5
        public IHttpActionResult Delete(int id)
        {
            dataprovider.DeleteDataProvider.DeleteReparaturDto(id);
            return Ok();
        }
    }
}