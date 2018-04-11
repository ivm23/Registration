using System;
using System.Collections.Generic;
using Registration.Model;

namespace Registration.ClientInterface
{
    public interface IClientRequests
    {
        string SelectedDatabase { set; get; }
        bool WorkerIsExist(string workerLogin);
        Guid AcceptAuthorisation(string workerLogin, string workerPassword);
        Guid CreateWorker(string workerName, string workerLogin, string workerPassword);
        IEnumerable<LetterView> GetLetterView(Guid id);
        bool LetterIsRead(Guid letterId, Guid workerId);
        IEnumerable<string> GetAllWorkers();
        void CreateLetter(string letterName, Guid senderId, IEnumerable<string> workerNameAndLogin, string letterText);
        void DeleteLetter(LetterView letter, Guid idWorker);
        IEnumerable<string> GetConnectionStrings();
        string GetWorkerName(Guid workerId);

        IEnumerable<Folder> GetAllWorkerFolders(Guid workerId);
        IEnumerable<LetterView> GetWorkerLettersInFolder(Guid workerId, Guid folderId);
        Folder GetFolder(Guid folderId);
        Folder CreateFolder(Guid parentId, string name, Guid creatorId, int type, string data );
        Folder UpdateFolder(Guid folderId, string newName);

        int GetCountLetterInFolder(Guid folderId);
        void DeleteFolder(Guid folderId);

        IEnumerable<FolderType> GetAllFolderTypes();

        FolderType GetFolderType(int folderTypeId);
        IDictionary<string, string> GetDatabaseNamesAndConnectionStrings();
    }
}
