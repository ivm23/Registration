using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Registration.Api
{
    public abstract class ConfigurationService
    {
        public abstract IList<string> GetConnectionStringKeys();
        public abstract string GetConnectionString(string connectionStringKey);
    }
}