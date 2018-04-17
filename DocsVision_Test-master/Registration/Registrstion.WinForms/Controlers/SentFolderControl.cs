using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registration.SerializationService;

namespace Registration.WinForms.Controlers
{
    public partial class SentFolderControl : UserControl, IFolderPropertiesUIPlugin
    {
        public SentFolderControl()
        {
            InitializeComponent();
        }

        FolderProperties info;
        public FolderProperties Info
        {
            set
            {
                info = value;
            }
            get
            {
                if (null == info)
                {
                    info = new global::Registration.SerializationService.FolderProperties();
                }
                return info;
            }
        }

        public void OnLoad() {}
    }
}
