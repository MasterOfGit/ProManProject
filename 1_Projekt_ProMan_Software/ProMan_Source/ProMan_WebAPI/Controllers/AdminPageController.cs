﻿///////////////////////////////
//Autor Sebastian Molkenthin
//Martikelnummer : 396734
//Team: ProMan
///////////////////////////////
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
        // GET: api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/<controller>/?identifier=
        public IHttpActionResult Get(string identifier)
        {
            JToken returnvalue = null;
            switch (identifier)
            {
                case "AdminPageAbteilung":
                    returnvalue = JToken.FromObject(dataprovider.GetSingleProvider.GetAdminPageAbteilungDto());
                    break;
                case "AdminPageBauteil":
                    returnvalue = JToken.FromObject(dataprovider.GetSingleProvider.GetAdminPageBauteilDto());
                    break;
                case "AdminPageFertigung":
                    returnvalue = JToken.FromObject(dataprovider.GetSingleProvider.GetAdminPageFertigungDto());
                    break;
                case "AdminPageFertigungslinie":
                    returnvalue = JToken.FromObject(dataprovider.GetSingleProvider.GetAdminPageFertigungslinieDto());
                    break;
                case "AdminPageMaschine":
                    returnvalue = JToken.FromObject(dataprovider.GetSingleProvider.GetAdminPageMaschineDto());
                    break;
                case "AdminPageUser":
                    returnvalue = JToken.FromObject(dataprovider.GetSingleProvider.GetAdminPageUserDto());
                    break;
                default:
                    break;

            }

            return Ok(returnvalue);

        }

        // POST: api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}
