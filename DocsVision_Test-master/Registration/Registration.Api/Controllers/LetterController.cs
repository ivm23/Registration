using Registration.DataInterface;
using Registration.DatabaseFactory;
using Registration.DataInterface.Sql;
using Registration.Model;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Configuration;
using System.ComponentModel.Design;
using System.Web;


namespace Reistration.Api.Controllers
{
    public class LetterController : ApiController
    {
        private static ServiceContainer _serviceFolderContainer = (ServiceContainer)HttpContext.Current.Application["serviceContainer"];

        private IDictionary<string, ILetterService> _existLetterService = new Dictionary<string, ILetterService>();

        private ILetterService getLetterService(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentNullException(nameof(connectionString));
            }

            ILetterService letterService;
            if (!_existLetterService.TryGetValue(connectionString, out letterService))
            {
                DatabaseService _databaseService = ((IDictionary<string, DatabaseService>)_serviceFolderContainer.GetService(typeof(IDictionary<string, DatabaseService>)))[connectionString];
                letterService = new LetterService(_databaseService);
                _existLetterService.Add(connectionString, letterService);
            }
       
            return letterService;
        }

        [HttpPost]
        [Route("api/{connectionString}/letter")]
        public Letter Create([FromBody] LetterView letter, string connectionString)
        {
            return getLetterService(connectionString).Create(letter); 
        }

        [HttpGet]
        [Route("api/{connectionString}/letter/{folderId}/{workerId}")]
        public LetterView Get(Guid folderId, Guid workerId, string connectionString)
        {
            return getLetterService(connectionString).Get(folderId, workerId);
        }

        [HttpDelete]
        [Route("api/{connectionString}/letter/{idLetter}/worker/{idWorker}/folder/{idFolder}")]
        public void Delete(Guid idLetter, Guid idWorker, Guid idFolder, string connectionString)
        {
            getLetterService(connectionString).Delete(idLetter, idWorker, idFolder);
        }

        [HttpPut]
        [Route("api/{connectionString}/letter/{letterId}/{workerId}")]
        public bool LetterIsRead(Guid letterId, Guid workerId, [FromBody] int isRead, string connectionString)
        {
            getLetterService(connectionString).ChangeLetterIsRead(letterId, workerId);
            return true; 
        }
    }
}
