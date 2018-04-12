using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Registration.DatabaseFactory;

namespace Registration.Api
{
    public class DatabasesService : IDatabasesService
    {
        IDictionary<string, DatabaseService> _databaseServices = new Dictionary<string, DatabaseService>();

        const string ConnectionStringKey = "connectionString";

        private string GetConnectionString(string databaseName) => $"Data Source = 109PC0047; Initial Catalog = {databaseName}; Integrated Security = True";

        public IDictionary<string, DatabaseService> GetDatabasesService()
        {
            ConfigurationService configurationService = ConfigurationServiceFactory.InitializeConfigurationService();

            IList<string> connectionStringKeys = configurationService.GetConnectionStringKeys();
            
            foreach (string connectionStringKey in connectionStringKeys)
            {
                if (connectionStringKey.Contains(ConnectionStringKey))
                {
                    string connectionString = configurationService.GetConnectionString(connectionStringKey);

                    _databaseServices.Add(connectionString, DatabaseFactory.DatabaseFactory.InitializeDatabase(GetConnectionString(connectionString)));
                }
            }
            return _databaseServices;
        }
    }

}