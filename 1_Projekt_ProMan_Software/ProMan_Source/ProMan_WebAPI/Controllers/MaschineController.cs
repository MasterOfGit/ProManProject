using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProMan_WebAPI.Models;
using ProMan_Database;
using ProMan_WebAPI.DataProvider;

namespace ProMan_WebAPI.Controllers
{
    [RoutePrefix("maschine")]
    public class MaschineController : ApiController
    {
        IDataProvider dataprovider = new DataProviderFactory().data;

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {


            return Ok(dataprovider.GetMaschineDto(id));
        }

        // POST api/<controller>
        public void Post([FromBody]MaschineDto value)
        {
            dataprovider.SetMaschineDto(value);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]MaschineDto value)
        {
            dataprovider.UpdateMaschineDto(value, id);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}