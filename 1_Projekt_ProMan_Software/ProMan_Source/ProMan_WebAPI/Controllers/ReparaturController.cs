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
        public void Post([FromBody]ReparaturDto value)
        {
            dataprovider.CreateDataProvider.SetReparaturDto(value);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]ReparaturDto value)
        {
            dataprovider.UpdateDataProvider.UpdateReparaturDto(value, id);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            dataprovider.DeleteDataProvider.DeleteReparaturDto(id);
        }
    }
}