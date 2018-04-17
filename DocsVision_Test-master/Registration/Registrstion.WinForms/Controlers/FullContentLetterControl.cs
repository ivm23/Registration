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
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace Registration.WinForms.Controlers
{
    internal partial class FullContentLetterControl : UserControl, ILetterPropertiesUIPlugin
    {
        public event EventHandler AddReceiver;
        private LetterView _letterView = new LetterView();

        public FullContentLetterControl()
        {
            InitializeComponent();
        }

        public void OnLoad() { }

        public LetterProperties GetLetterProperties()
        {
            return new LetterProperties();
        }

        public void SetLetterProperties(LetterProperties letterProperties) { }

        public LetterView StandartLetter
        {
            set
            {
                nameLetterTB.Text = value.Name;
                nameSenderTB.Text = value.SenderName;
                dateLetterTB.Text = value.Date.ToString();
                workersEditorControl1.SetWorkers(value.ReceiversName);
            }
            get
            {
                _letterView.Name = nameLetterTB.Text;
                _letterView.SenderName = nameSenderTB.Text;
                _letterView.Text = textLetterTB.Text;
                _letterView.Date = Convert.ToDateTime(dateLetterTB.Text);
                _letterView.ReceiversName.AddRange(workersEditorControl1.GetWorkers());

                return _letterView;
            }
        }

        public LetterView LetterView
        {
            set
            {
                StandartLetter = value;
            }
            get
            {
                _letterView = StandartLetter;
                return _letterView;
            }
        }

        public bool ReadOnly
        {
            set
            {
                nameLetterTB.ReadOnly = value;
                textLetterTB.ReadOnly = value;
                dateLetterTB.Visible = value;
                labelDate.Visible = value;
                nameReceiversCB.Visible = !value;
                workersEditorControl1.Visible = value;
                nameReceiversCB.DropDownStyle = (value ? ComboBoxStyle.DropDownList : ComboBoxStyle.DropDown);
            }
            get
            {
                return textLetterTB.ReadOnly;
            }
        }

        private void addReceiversB_Click(object sender, EventArgs e)
        {

        }
    }
}

