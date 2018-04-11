using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using Registration.DatabaseFactory;
using System.ComponentModel.Design;
using System.Configuration;

namespace Reistration.Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        const string ConnectionStringKey = "connectionString";
        const string ServiceContainerMark = "serviceContainer";

        private IDictionary<string, DatabaseService> _databaseServices;
        static ServiceContainer _serviceContainer;

        private void InitializeApplication()
        {
            _databaseServices = new Dictionary<string, DatabaseService>();

            ServiceContainer = new ServiceContainer();

            IList<string> connectionStringKeys = ConfigurationManager.AppSettings.AllKeys;

            foreach (string connectionStringKey in connectionStringKeys)
            {
                if (connectionStringKey.Contains(ConnectionStringKey))
                { 
                    string connectionString = ConfigurationManager.AppSettings[connectionStringKey];
                    _databaseServices.Add(connectionString, DatabaseFactory.InitializeDatabase(connectionString));
                }
            }

            ServiceContainer.AddService(typeof(IDictionary<string, DatabaseService>), DatabaseServices);

            Application.Add(ServiceContainerMark, ServiceContainer);
        }

        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            InitializeApplication();
        }

        private IDictionary<string, DatabaseService> DatabaseServices
        {
            set
            {
                _databaseServices.Clear();
                foreach(KeyValuePair<string, DatabaseService> connectionStringAndDatabaseService in value)
                {
                    _databaseServices.Add(connectionStringAndDatabaseService);
                }
                //_databaseServices = value;
            }
            get
            {
                return _databaseServices;
            }
        }

        private ServiceContainer ServiceContainer
        {
            set
            {
                _serviceContainer = value;
            }
            get
            {
                return _serviceContainer;
            }
        }
    }
}
