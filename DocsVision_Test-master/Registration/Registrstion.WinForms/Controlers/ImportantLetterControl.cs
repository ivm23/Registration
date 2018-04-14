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
    public partial class ImportantLetterControl : UserControl, ILetterPropertiesUIPlugin
    {
        enum ImportanceDegree { Low = 1, Normal = 2, High = 3 };

        public event EventHandler AddReceiver;


        public ImportantLetterControl()
        {
            InitializeComponent();
        }

        public void OnLoad()
        {
            var importanceDEgree = new Dictionary<int, string>();

            foreach (int value in Enum.GetValues(typeof(ImportanceDegree)))
            {
                importanceDEgree.Add(value, (string)Registrstion.WinForms.Resources.ResourceManager.GetObject(value.ToString()));
            }

            importanceDegreeEditorControl1.SetImportanceDegree(importanceDEgree);
        }

        public LetterProperties GetLetterProperties()
        {
            var letterProperties = new LetterProperties();

            var xmlSerializer = new XmlSerializer(typeof(ImportantLetterData));

            var importantLetterData = new ImportantLetterData();

            using (var stringWriter = new StringWriter())
            {
                using (var writer = XmlWriter.Create(stringWriter))
                {
                    xmlSerializer.Serialize(writer, importantLetterData);
                    letterProperties.Properties = stringWriter.ToString();
                    return letterProperties;
                }
            }
        }

        public void SetLetterProperties(LetterProperties letterProperties)
        {
            var importantLetterData = new ImportantLetterData();

            var xmlSerializer = new XmlSerializer(typeof(ImportantLetterData));

            using (var stringReader = new StringReader(letterProperties.Properties))
            {
                using (var reader = XmlReader.Create(stringReader))
                {
                    importantLetterData = (ImportantLetterData)xmlSerializer.Deserialize(reader);
                }
            }

            importanceDegreeEditorControl1.SetSelectedImportanceDegree(importantLetterData.DegreeImportance);
        }


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
                importanceDegreeEditorControl1.Visible = value;
                nameReceiversCB.DropDownStyle = (value ? ComboBoxStyle.DropDownList : ComboBoxStyle.DropDown);
            }
        }

        private void addReceiversB_Click(object sender, EventArgs e)
        {

        }
    }
}
