using Newtonsoft.Json.Linq;
using ProMan_WebAPI.Base;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ProMan_WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class AdminPageController : BaseApiController
    {
        // GET: api/AdminPage
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/AdminPage/?identifier=
        public IHttpActionResult Get(string identifier)
        {
            JToken returnvalue = null;
            switch (identifier)
            {
                case "AdminPageAbteilung":
                    returnvalue = JToken.FromObject(dataprovider.GetAdminPageAbteilungDto());
                    break;
                case "AdminPageBauteil":
                    returnvalue = JToken.FromObject(dataprovider.GetAdminPageBauteilDto());
                    break;
                case "AdminPageFertigung":
                    returnvalue = JToken.FromObject(dataprovider.GetAdminPageFertigungDto());
                    break;
                case "AdminPageFertigungslinie":
                    returnvalue = JToken.FromObject(dataprovider.GetAdminPageFertigungslinieDto());
                    break;
                case "AdminPageMaschine":
                    returnvalue = JToken.FromObject(dataprovider.GetAdminPageMaschineDto());
                    break;
                case "AdminPageUser":
                    returnvalue = JToken.FromObject(dataprovider.GetAdminPageUserDto());
                    break;
                default:
                    break;

            }

            return Ok(returnvalue);

        }

        // POST: api/AdminPage
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/AdminPage/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/AdminPage/5
        public void Delete(int id)
        {
        }
    }
}
