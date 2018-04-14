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
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace Registrstion.WinForms.Controlers
{
    internal partial class FullContentLetterControl : UserControl, ILetterPropertiesUIPlugin
    {
        public event EventHandler AddReceiver;

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

        public LetterView GetStandartLetter()
        {
            var letterView = new LetterView
            {
                Name = nameLetterTB.Text,
                SenderName = nameSenderTB.Text,
                Text = textLetterTB.Text,
                Date = Convert.ToDateTime(dateLetterTB.Text)
            };
            letterView.ReceiversName.AddRange(workersEditorControl1.GetWorkers());
            return letterView;
        }

        public void SetStandartLetter(LetterView letterView)
        {
            nameLetterTB.Text = letterView.Name;
            nameSenderTB.Text = letterView.SenderName;
            dateLetterTB.Text = letterView.Date.ToString();
            workersEditorControl1.SetWorkers(letterView.ReceiversName);
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
        }

        private void addReceiversB_Click(object sender, EventArgs e)
        {

        }
    }
}

