using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Reflection;

namespace Registration.Api
{
    public sealed class ConfigurationServiceFactory
    {

        public static ConfigurationServiceFactorySectionHandle sectionHandler = (ConfigurationServiceFactorySectionHandle)ConfigurationManager.GetSection("ConfigurationService");
        private ConfigurationServiceFactory() { }

        public static ConfigurationService InitializeConfigurationService()
        {
            if (sectionHandler.Name.Length == 0)
            {
                throw new Exception("Configuration name not defined in ConfigurationService section of web.config.");
            }
            try
            {
                Type configurationService = Type.GetType(sectionHandler.Name);
                ConstructorInfo constructor = configurationService.GetConstructor(new Type[] { });

                ConfigurationService createdObject = (ConfigurationService)constructor.Invoke(null);

                return createdObject;
            }
            catch (Exception excep)
            {
                throw new Exception("Error instantiating configurationService " + sectionHandler.Name + ". " + excep.Message);
            }

        }
    }
}