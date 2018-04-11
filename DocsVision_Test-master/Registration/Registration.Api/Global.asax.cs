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
       
        const string ServiceContainerMark = "serviceContainer";

        static ServiceContainer _serviceContainer;

        private void InitializeApplication()
        {

            ServiceContainer = new ServiceContainer();
           
            ServiceContainer.AddService(typeof(Registration.Api.DatabasesService), new Registration.Api.DatabasesService);

            Application.Add(ServiceContainerMark, ServiceContainer);
        }

        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            InitializeApplication();
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
