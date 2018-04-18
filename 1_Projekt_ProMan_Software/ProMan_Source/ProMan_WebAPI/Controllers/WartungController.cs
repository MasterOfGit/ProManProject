using ProMan_BusinessLayer.DataProvider;
using ProMan_BusinessLayer.Models;
using System.Collections.Generic;
using System.Web.Http;
using Newtonsoft.Json.Linq;
using System.Web.Http.Cors;
using ProMan_WebAPI.Base;

namespace ProMan_WebAPI.Controllers
{
    [RoutePrefix("wartung")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class WartungController : BaseApiController
    {

        // GET api/<controller>
        public IEnumerable<WartungDto> Get()
        {
            return dataprovider.GetListDataProvider.GetWartungDto();
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {

            return Ok(JToken.FromObject(dataprovider.GetSingleProvider.GetWartungDto(id)));
        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody]WartungDto value)
        {
            dataprovider.CreateDataProvider.SetWartungDto(value);
            return Ok();
        }

        // PUT api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody]WartungDto value)
        {
            dataprovider.UpdateDataProvider.UpdateWartungDto(value,id);
            return Ok();
        }

        // DELETE api/<controller>/5
        public IHttpActionResult Delete(int id)
        {
            dataprovider.DeleteDataProvider.DeleteWartungDto(id);
            return Ok();
        }
    }
}