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
    public partial class StandartLetterControl : UserControl, ILetterPropertiesUIPlugin
    {
        public StandartLetterControl()
        {
            InitializeComponent();
        }
        FolderProperties _info;

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
                return _info;
            }
        }
    }
}
