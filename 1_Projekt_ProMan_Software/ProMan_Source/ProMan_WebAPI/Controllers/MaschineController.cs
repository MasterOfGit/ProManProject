using System.Collections.Generic;
using System.Web.Http;
using Newtonsoft.Json.Linq;
using System.Web.Http.Cors;
using ProMan_BusinessLayer.DataProvider;
using ProMan_BusinessLayer.Models;
using ProMan_WebAPI.Base;
using System.IO;

namespace ProMan_WebAPI.Controllers
{
    [RoutePrefix("maschine")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class MaschineController : BaseApiController
    {

        // GET api/<controller>
        public IEnumerable<MaschineDto> Get()
        {
            return dataprovider.GetListDataProvider.GetMaschineDto();
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            return Ok(JToken.FromObject(dataprovider.GetSingleProvider.GetMaschineDto(id)));
        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody]MaschineDto value)
        {
            dataprovider.CreateDataProvider.SetMaschineDto(value);
            return Ok();
        }

        // PUT api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody]MaschineDto value)
        {
            dataprovider.UpdateDataProvider.UpdateMaschineDto(value, id);
            return Ok();
        }

        // DELETE api/<controller>/5
        public IHttpActionResult Delete(int id)
        {
            dataprovider.DeleteDataProvider.DeleteMaschineDto(id);
            return Ok();
        }
    }
}