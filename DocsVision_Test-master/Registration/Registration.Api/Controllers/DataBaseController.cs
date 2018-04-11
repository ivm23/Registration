using Registration.DataInterface;
using Registration.Model;
using System;
using System.Collections.Generic;
using System.Web.Http;
using Registration.Logger;
using System.Configuration;
using Registration.DatabaseFactory;



namespace Registration.Api.Controllers
{
    public class DataBaseController : ApiController
    {
        [HttpGet]
        [Route("api/database")]
        public IEnumerable<string> GetConnectionStrings()
        {
            List<string> allConnectionsStrings = new List<string>();
            foreach (string key in ConfigurationManager.AppSettings.AllKeys)
            {
                if (key.Contains("connectionString"))
                {
                    allConnectionsStrings.Add(ConfigurationManager.AppSettings[key]);
                }
            }
            return allConnectionsStrings;
        }
    }
}