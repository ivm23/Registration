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
            ConfigurationService configurationService = ConfigurationServiceFactory.InitializeConfigurationService();

            IList<string> connectionStringKeys = configurationService.GetConnectionStringKeys();

            var allConnectionsStrings = new List<string>();
            foreach (string key in connectionStringKeys)
            {
                if (key.Contains("connectionString"))
                {
                    allConnectionsStrings.Add(configurationService.GetConnectionString(key));
                }
            }
            return allConnectionsStrings;
        }
    }
}