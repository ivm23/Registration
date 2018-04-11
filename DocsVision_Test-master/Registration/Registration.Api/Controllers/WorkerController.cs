using System;
using System.Collections.Generic;
using System.Web.Http;
using Registration.DataInterface;
using Registration.DataInterface.Sql;
using Registration.Model;
using Registration.DatabaseFactory;
using System.ComponentModel.Design;
using System.Web;


namespace Reistration.Api.Controllers
{
    public class WorkerController : ApiController
    {
        private static ServiceContainer _serviceFolderContainer = (ServiceContainer)HttpContext.Current.Application["serviceContainer"];

        private IDictionary<string, IWorkerService> _existWorkerService = new Dictionary<string, IWorkerService>();

        private IWorkerService getWorkerService(string connectionString)
        {
            IWorkerService workerService;
            if (!_existWorkerService.ContainsKey(connectionString))
            {
                DatabaseService _databaseService = ((IDictionary<string, DatabaseService>)_serviceFolderContainer.GetService(typeof(IDictionary<string, DatabaseService>)))[connectionString];
                workerService = new WorkerService(_databaseService);
                _existWorkerService.Add(connectionString, workerService);
            }
            else
            {
                workerService = _existWorkerService[connectionString];
            }
            return workerService;
        }


        [HttpGet]
        [Route("api/{connectionString}/worker/{login}/{password}")]
        public Worker AuthorizationWorker(string login, string password, string connectionString)
        {
            return getWorkerService(connectionString).AuthorizationWorker(login, password);
        }

        [HttpPost]
        [Route("api/{connectionString}/worker")]
        public Worker Create([FromBody] Worker worker, string connectionString)
        {
            return getWorkerService(connectionString).Create(worker);
        }

        [HttpGet]
        [Route("api/{connectionString}/worker/{login}")]
        public Worker Get(string login, string connectionString)
        {
            return getWorkerService(connectionString).Get(login);
        }

        [HttpGet]
        [Route("api/{connectionString}/workers")]
        public IEnumerable<Worker> GetAllWorkers(string connectionString)
        {
            return getWorkerService(connectionString).GetAllWorkers();
        }

        [HttpGet]
        [Route("api/{connectionString}/worker/{workerId}/name")]
        public string GetWorkerName(Guid workerId, string connectionString)
        {
            return getWorkerService(connectionString).GetWorkerName(workerId);
        }

    }
}
