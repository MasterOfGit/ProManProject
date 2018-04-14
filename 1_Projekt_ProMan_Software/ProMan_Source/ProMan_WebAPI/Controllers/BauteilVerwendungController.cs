using Newtonsoft.Json.Linq;
using ProMan_BusinessLayer.Models;
using ProMan_WebAPI.Base;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ProMan_WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class BauteilVerwendungController : BaseApiController
    {
        // GET: api/<controller>
        public IEnumerable<BauteilVerwendungDto> Get()
        {
            return dataprovider.GetListDataProvider.GetBauteilVerwendungDto();
        }

        // GET: api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            return Ok(JToken.FromObject(dataprovider.GetSingleProvider.GetBauteilVerwendungDto(id)));
        }

        // POST: api/<controller>
        public void Post([FromBody]BauteilVerwendungDto value)
        {
            dataprovider.CreateDataProvider.SetBauteilVerwendungDto(value);
        }

        // PUT: api/<controller>/5
        public void Put(int id, [FromBody]BauteilVerwendungDto value)
        {
            dataprovider.UpdateDataProvider.UpdateBauteilVerwendungDto(value, id);
        }

        // PUT: api/<controller>/5
        public void Put(int id, [FromBody]List<BauteilVerwendungDto> value)
        {
            foreach (var item in value)
            {
                Put(id, value);
            }


        }

        // DELETE: api/<controller>/5
        public void Delete(int id)
        {
            dataprovider.DeleteDataProvider.DeleteBauteilVerwendungDto(id);
        }
    }

}
