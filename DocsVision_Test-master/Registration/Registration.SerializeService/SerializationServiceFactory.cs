using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Registration.SerializationService
{
    
    public sealed class SerializationServiceFactory
    {
       
        private static SerializationServiceFactorySectionHandler sectionHandler = (SerializationServiceFactorySectionHandler)ConfigurationManager.GetSection("SerializeService");

        private SerializationServiceFactory() { }

        public static ISerializationService InitializeConfigurationService()
        {
                var a = ConfigurationManager.AppSettings;
            if (sectionHandler != null)

                if (String.IsNullOrEmpty(sectionHandler.Name))
                    throw new Exception("Configuration name not defined in SerializationService section of web.config.");

            try
            {
                return (ISerializationService)Activator.CreateInstance(Type.GetType(sectionHandler.Name));
            }
            catch (Exception excep)
            {
                throw new Exception("Error instantiating serializationService " + sectionHandler.Name + ". " + excep.Message);
            }

        }
    }
}
