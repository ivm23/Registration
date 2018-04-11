using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registration.Model;

namespace Registrstion.WinForms
{
    interface IPluginService
    {
        IFolderPropertiesUIPlugin GetFolderPropetiesPlugin(FolderType selectedFolderType);
    }
}
