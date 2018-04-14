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
    public partial class LetterWithResponseTimeControl : UserControl//, ILetterPropertiesUIPlugin
    {
        public event EventHandler AddReceiver;
        LetterProperties _info;
        private Message.MessageService _messageService = new Message.MessageService(); 
        public LetterWithResponseTimeControl()
        {
            InitializeComponent();
        }

        private Message.MessageService MessageService
        {
            get { return _messageService; }
        }

        public void OnLoad()
        {

        }

        public LetterProperties Properties
        {
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

                //  XmlElement elem = _info.Properties.CreateElement(dateTimePickerResponseRequired.Name);
                //      elem.InnerText = dateTimePickerResponseRequired.Text;
                //    _info.Properties.AppendChild(elem);
                //_info.Properties.InnerText = nameReceiversCB.Text;
                return _info;
            }
        }

    /*    public bool ReadOnly
        {
            set
            {
                dateTimePickerResponseRequired.Enabled = value;
            }
        }*/
        public bool ReadOnly
        {
            set
            {
                nameLetterTB.ReadOnly = value;
                textLetterTB.ReadOnly = value;
                dateLetterTB.Visible = value;
                labelDate.Visible = value;
                nameReceiversCB.Visible = !value;
                workersControl1.Visible = value;
                nameReceiversCB.DropDownStyle = (value ? ComboBoxStyle.DropDownList : ComboBoxStyle.DropDown);
            }
        }

        private void addReceiversB_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nameReceiversCB.Text))
            {
                AddReceiver(this, e);
            }
            else
            {
                MessageService.ErrorMessage(Message.MessageResource.EmptyListRecipient);
            }
        }
    }
}
