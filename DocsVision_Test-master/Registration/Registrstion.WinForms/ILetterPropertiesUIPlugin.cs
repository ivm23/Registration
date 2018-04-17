using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registration.SerializationService;

namespace Registration.WinForms
{
    public interface ILetterPropertiesUIPlugin
    {
        void OnLoad();

        LetterProperties GetLetterProperties();

        void SetLetterProperties(LetterProperties letterProperties);

        event EventHandler AddReceiver;

        bool ReadOnly { set; get; }

        LetterView LetterView { get; set; }

    }
}
