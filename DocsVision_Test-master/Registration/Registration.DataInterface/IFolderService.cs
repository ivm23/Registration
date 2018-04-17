using System;
using Registration.SerializationService;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.DataInterface
{
    public interface IFolderService
    {
        int GetCountLettersInFolder(Guid folderId);
        IEnumerable<LetterView> GetLettersInFolder(Guid folderId);

    }
}
