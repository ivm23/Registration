using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace Registration.Api
{
    public class WebConfigurationService : ConfigurationService
    {
        override public IList<string> GetConnectionStringKeys()
        {
            return ConfigurationManager.AppSettings.AllKeys; 
        }
        override public string GetConnectionString(string connectionStringKey)
        {
            return ConfigurationManager.AppSettings[connectionStringKey];
        }
    }
}