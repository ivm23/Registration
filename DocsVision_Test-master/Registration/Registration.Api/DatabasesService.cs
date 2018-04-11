using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Registration.DatabaseFactory;
using System.Configuration;

namespace Registration.Api
{
    public class DatabasesService
    {
        IDictionary<string, DatabaseService> _databaseServices;
        const string ConnectionStringKey = "connectionString";

        public IDictionary<string, DatabaseService> GetDatabasesService()
        {
            IList<string> connectionStringKeys = ConfigurationManager.AppSettings.AllKeys;

            foreach (string connectionStringKey in connectionStringKeys)
            {
                if (connectionStringKey.Contains(ConnectionStringKey))
                {
                    string connectionString = ConfigurationManager.AppSettings[connectionStringKey];
                    _databaseServices.Add(connectionString, DatabaseFactory.DatabaseFactory.InitializeDatabase(connectionString));
                }
            }
            return _databaseServices;
        }
    }

}