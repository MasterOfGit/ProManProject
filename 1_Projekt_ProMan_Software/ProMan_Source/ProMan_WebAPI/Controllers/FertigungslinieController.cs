using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProMan_WebAPI.Models;
using ProMan_Database;
using ProMan_WebAPI.DataProvider;
using Newtonsoft.Json.Linq;

namespace ProMan_WebAPI.Controllers
{
    [RoutePrefix("fertigungslinie")]
    public class FertigungslinieController : ApiController
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


            return Ok(JToken.FromObject(dataprovider.GetFertigungslinieDto(id)));
        }

        // POST api/<controller>
        public void Post([FromBody]FertigungslinieDto value)
        {
            dataprovider.SetFertigungslinieDto(value);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]FertigungslinieDto value)
        {
            dataprovider.UpdateFertigungslinieDto(value, id);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}