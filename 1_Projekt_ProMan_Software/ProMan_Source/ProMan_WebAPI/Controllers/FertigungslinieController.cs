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


            return Ok(dataprovider.GetFertigungslinieDto(id));
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}