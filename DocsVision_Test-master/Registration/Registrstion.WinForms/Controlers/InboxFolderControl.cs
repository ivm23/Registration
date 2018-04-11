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

namespace Registrstion.WinForms.Controlers
{
    public partial class InboxFolderControl : UserControl, IFolderPropertiesUIPlugin
    {
        
        public InboxFolderControl()
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
                if (info == null)
                    info = new global::Registration.Model.FolderProperties();

                return info;
            }
        }

        public void OnLoad() {}
    }
}
