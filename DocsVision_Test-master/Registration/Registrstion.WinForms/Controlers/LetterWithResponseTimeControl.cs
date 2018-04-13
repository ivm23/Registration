using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registration.Model;
using System.Xml;

namespace Registrstion.WinForms.Controlers
{
    public partial class LetterWithResponseTimeControl : UserControl, ILetterPropertiesUIPlugin
    {
        FolderProperties _info;
        public LetterWithResponseTimeControl()
        {
            InitializeComponent();
        }

        public void OnLoad()
        {

        }

        public FolderProperties Info
        {
            set
            {
                _info = value;
            }
            get
            {
                if (null == _info)
                {
                    _info = new FolderProperties();
                }

                XmlElement elem = _info.Info.CreateElement(dateTimePickerResponseRequired.Name);
                elem.InnerText = dateTimePickerResponseRequired.Text;

                return _info;
            }
        }
    }
}
