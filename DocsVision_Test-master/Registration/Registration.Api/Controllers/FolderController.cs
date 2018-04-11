using Registration.DataInterface;
using Registration.Model;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.ComponentModel.Design;
using System.Web;
using Registration.DatabaseFactory;
using System.Data;
using System.Data.SqlClient;

using System.Text;
using System.Configuration;

namespace Registration.Api.Controllers
{
    public class FolderController : ApiController
    {
        private static ServiceContainer _serviceFolderContainer = (ServiceContainer)HttpContext.Current.Application["serviceContainer"];

        private IDictionary<string, IFolderTreeService> _existFolderTreeService = new Dictionary<string, IFolderTreeService>();
        private IFolderService _folderService;

        private IFolderTreeService getFolderTreeService(string connectionString)
        {
            IFolderTreeService folderTreeService;
            if (!_existFolderTreeService.ContainsKey(connectionString))
            {
                DatabaseService _databaseService = ((IDictionary<string, DatabaseService>)_serviceFolderContainer.GetService(typeof(IDictionary<string, DatabaseService>)))[connectionString];
                folderTreeService = new FolderTreeService(_databaseService);
                _existFolderTreeService.Add(connectionString, folderTreeService);
            }
            else
            {
                folderTreeService = _existFolderTreeService[connectionString];
            }
            return folderTreeService;
        }

        [HttpPost]
        [Route("api/{connectionString}/folder")]
        public Folder CreateFolder([FromBody] Folder folder, string connectionString)
        {           
            return getFolderTreeService(connectionString).Create(folder);
        }

        [HttpGet]
        [Route("api/{connectionString}/allFolders")]
        public string GetHierarchy(string connectionString)
        {
            return getFolderTreeService(connectionString).GetAllFolders();
        }

        [HttpGet]
        [Route("api/{connectionString}/letters/folder/{folderId}/{ownerId}")]
        public IEnumerable<LetterView> GetLettersInFolder(Guid folderId, Guid ownerId, string connectionString)
        {
            _folderService = getFolderTreeService(connectionString).GetFolderService(folderId);
            return _folderService.GetLettersInFolder(folderId);
        }

        [HttpGet]
        [Route("api/{connectionString}/count/letters/{folderId}")]
        public int GetCountLettersInFolder(Guid folderId, string connectionString)
        {
            _folderService = getFolderTreeService(connectionString).GetFolderService(folderId);
            return _folderService.GetCountLettersInFolder(folderId);
        }

        [HttpPut]
        [Route("api/{connectionString}/folder/update")]
        public Folder ChangeLetterText([FromBody] Folder folder, string connectionString)
        {
            return getFolderTreeService(connectionString).Update(folder);
        }


        [HttpDelete]
        [Route("api/{connectionString}/folder/{folderId}")]
        public void Delete(Guid folderId, string connectionString)
        {
            getFolderTreeService(connectionString).Delete(folderId);
        }

        [HttpGet]
        [Route("api/{connectionString}/folders/{workerId}")]
        public IEnumerable<Folder> GetHierarchy(Guid workerId, string connectionString)
        {
            return getFolderTreeService(connectionString).GetAllWorkerFolders(workerId);
        }

        [HttpGet]
        [Route("api/{connectionString}/folder/types")]
        public IEnumerable<FolderType> GetAllFolderTypes(string connectionString)
        {
            return getFolderTreeService(connectionString).GetAllFolderTypes();
        }

        [HttpGet]
        [Route("api/{connectionString}/folder/{folderTypeId}/type")]
        public FolderType GetFolderType(int folderTypeId, string connectionString)
        {
            return getFolderTreeService(connectionString).GetFolderType(folderTypeId);
        }
    }
}