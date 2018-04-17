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
    public partial class ImportantLetterControl : UserControl, ILetterPropertiesUIPlugin
    {
        
        public event EventHandler AddReceiver;
       private readonly ISerializationService serializer = SerializationServiceFactory.InitializeConfigurationService();
        //  private readonly SerializationServiceXML<ImportantLetterData> serializer = new SerializationServiceXML<ImportantLetterData>();
        private LetterView _letterView = new LetterView();

        public ImportantLetterControl()
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
            importantLetterData.DegreeImportance = importanceDegreeEditorControl1.SelectedImportanceDegree;

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

            importanceDegreeEditorControl1.SelectedImportanceDegree = importantLetterData.DegreeImportance;
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

        public bool ReadOnly
        {
            set
            {
                fullContentLetterControl1.ReadOnly = value;
                importanceDegreeEditorControl1.Visible = !value;
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
