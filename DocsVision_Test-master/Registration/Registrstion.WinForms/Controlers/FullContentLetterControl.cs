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
    internal partial class FullContentLetterControl : UserControl
    {
        public FullContentLetterControl()
        {
            InitializeComponent();
        }
        public string NameLetter
        {
            set
            {
                nameLetterTB.Text = value;
            }
            get
            {
                return nameLetterTB.Text;
            }
        }
        public string NameSender
        {
            set
            {
                nameSenderTB.Text = value;
            }
            get
            {
                return nameSenderTB.Text;
            }
        }
        public string TextLetter
        {
            set
            {
                textLetterTB.Text = value;
            }
            get
            {
                return textLetterTB.Text;
            }
        }
        public string NameReceiver
        {
            get
            {
                return (nameReceiversCB.SelectedItem != null ? nameReceiversCB.SelectedItem.ToString() : string.Empty);
            }
        }

        public LetterView FullContent
        {
            set
            {
                nameLetterTB.Text = value.Name;
                nameSenderTB.Text = value.SenderName;
                StringBuilder names = new StringBuilder();
                foreach (string name in value.ReceiversName)
                {
                    names.Append(name);
                    names.Append("; ");
                }
                if (nameReceiversTB.Visible) nameReceiversTB.Text = names.ToString();
                if (nameReceiversCB.Visible) nameReceiversCB.Text = names.ToString();

                textLetterTB.Text = value.Text;
                dateLetterTB.Text = Convert.ToString(value.Date);
                Refresh();
            }
            get
            {
                LetterView letterView = new LetterView()
                {
                    Name = nameLetterTB.Text,
                    SenderName = nameSenderTB.Text,
                    Text = textLetterTB.Text,
                    Date = Convert.ToDateTime(dateLetterTB.Text)
                };
                if (nameReceiversCB.Visible)
                {
                    foreach (string nameAndLogin in nameReceiversCB.Items)
                        letterView.ReceiversName.Add(nameAndLogin);
                }
                else
                {
                    letterView.ReceiversName.AddRange(nameReceiversTB.Text.Split(';'));
                }

                return letterView;
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
                nameReceiversTB.Visible = value;
                nameReceiversCB.DropDownStyle = (value ? ComboBoxStyle.DropDownList : ComboBoxStyle.DropDown);
            }
        }

        public IEnumerable<string> AllWorkers
        {
            set
            {
                foreach (string nameAmdLogin in value)
                {
                    nameReceiversCB.Items.Add(nameAmdLogin);
                }

                var values = new AutoCompleteStringCollection();
                values.AddRange(value.ToArray<string>());
                nameReceiversCB.AutoCompleteCustomSource = values;
                nameReceiversCB.AutoCompleteMode = AutoCompleteMode.None;
                nameReceiversCB.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            get
            {
                List<string> allWorkersNameAndLogin = new List<string>();
                foreach (string nameAndLogin in nameReceiversCB.Items)
                {
                    allWorkersNameAndLogin.Add(nameAndLogin);
                }
                return allWorkersNameAndLogin;
            }
        }

    }
}
