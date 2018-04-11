using System;
using System.Collections.Generic;
using Registrstion.WinForms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registration.Model;
using System.Windows.Forms;

namespace Registrstion.WinForms
{

    public interface IFolderPropertiesUIPlugin
    {
        void OnLoad();
        FolderProperties Info { set; get; }
    }
}
