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

        LetterProperties GetLetterProperties();

        void SetLetterProperties(LetterProperties letterProperties);

        LetterView GetStandartLetter();
        void SetStandartLetter(LetterView letterView);

        event EventHandler AddReceiver;

        bool ReadOnly { set; }

    }
}
