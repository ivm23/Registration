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
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Registration.WinForms.Controlers
{
    public partial class LetterWithResponseTimeControl : UserControl, ILetterPropertiesUIPlugin
    {
        public event EventHandler AddReceiver;
        private LetterView _letterView = new LetterView();

        public LetterWithResponseTimeControl()
        {
            InitializeComponent();
        }

        public void OnLoad()
        {
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
        }

        public LetterView LetterView
        {
            set
            {
                StandartLetter = value;
                LetterProperties = value;
            }
            get
            {
                _letterView = StandartLetter;
                _letterView.ExtendedData = LetterProperties.Property;                
                return _letterView;
            }
        }

        public LetterView StandartLetter
        {
            set
            {
                fullContentLetterControl1.StandartLetter = value;
            }
            get
            {
                return fullContentLetterControl1.StandartLetter;
            }
        }


        public bool ReadOnly
        {
            set
            {
                fullContentLetterControl1.ReadOnly = value;
                dateTimePickerResponseRequired.Visible = !value;
            }
            get
            {
                return fullContentLetterControl1.ReadOnly;
            }
        }

        private void addReceiversB_Click(object sender, EventArgs e)
        {

        }
    }
}
