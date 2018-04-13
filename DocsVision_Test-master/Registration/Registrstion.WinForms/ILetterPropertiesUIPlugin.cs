using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registration.Model;

namespace Registrstion.WinForms
{
    public interface ILetterPropertiesUIPlugin
    {
        void OnLoad();
        LetterProperties Properties { set; get; }

        event EventHandler AddReceiver;

        bool ReadOnly { set; }

    }
}
