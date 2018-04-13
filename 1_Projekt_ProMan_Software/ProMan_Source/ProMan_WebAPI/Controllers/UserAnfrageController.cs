using Newtonsoft.Json.Linq;
using ProMan_BusinessLayer.Models;
using ProMan_WebAPI.Base;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ProMan_WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UserAnfrageController : BaseApiController
    {
        // GET: api/<controller>
        public IEnumerable<UserAnfrageDto> Get()
        {
            return dataprovider.GetListDataProvider.GetUserAnfrageDto();
        }

        // GET: api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            return Ok(JToken.FromObject(dataprovider.GetSingleProvider.GetUserAnfrageDto(id)));
        }

        // POST: api/<controller>
        public void Post([FromBody]UserAnfrageDto value)
        {
            dataprovider.CreateDataProvider.SetUserAnfrageDto(value);
        }

        // PUT: api/<controller>/5
        public void Put(int id, [FromBody]UserAnfrageDto value)
        {
            dataprovider.UpdateDataProvider.UpdateUserAnfrageDto(value, id);
        }

        // PUT: api/<controller>/5
        public void Put(int id, [FromBody]List<UserAnfrageDto> value)
        {
            foreach (var item in value)
            {
                Put(id, value);
            }


        }

        // DELETE: api/<controller>/5
        public void Delete(int id)
        {
            dataprovider.DeleteDataProvider.DeleteUserAnfrageDto(id);
        }
    }

}