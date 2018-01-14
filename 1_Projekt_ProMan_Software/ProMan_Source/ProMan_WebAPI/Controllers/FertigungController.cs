using ProMan_Database;
using ProMan_WebAPI.DataProvider;
using ProMan_WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProMan_WebAPI.Controllers
{
    public class FertigungController : ApiController
    {
        IDataProvider dataprovider = new DataProviderFactory().data;

        // GET: api/Fertigung
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Fertigung/5
        public IHttpActionResult Get(int id)
        {
            return Ok(dataprovider.GetFertigungsDto(id));
        }

        // POST: api/Fertigung
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Fertigung/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Fertigung/5
        public void Delete(int id)
        {
        }
    }
}
