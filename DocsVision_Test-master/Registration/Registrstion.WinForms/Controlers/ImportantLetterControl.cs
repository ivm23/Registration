﻿using System;
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
    public partial class ImportantLetterControl : UserControl//, ILetterPropertiesUIPlugin
    {
        public event EventHandler AddReceiver;
        public ImportantLetterControl()
        {
            InitializeComponent();

        }

        LetterProperties _info;

        public void OnLoad()
        {

        }

        public LetterProperties Properties {
            set
            {
                _info = value;
            }
            get
            {
                if (null == _info)
                {
                    _info = new LetterProperties();
                }

            /*    XmlElement elem = _info.Properties.CreateElement(comboImportanceDegree.Name);
                elem.InnerText = comboImportanceDegree.Text;
                _info.Properties.AppendChild(elem);
                */
                return _info;
            }
        }

        private void sendLetterB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("fdsd");

            AddReceiver(sender, e);
        }
    }
}
