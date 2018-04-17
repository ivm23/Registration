using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration.WinForms.Controlers
{
    public partial class ImportanceDegreeEditorControl : UserControl
    {
        private IDictionary<SerializationService.ImportanceDegree, string> _importanceDegree = new Dictionary<SerializationService.ImportanceDegree, string>();

        public ImportanceDegreeEditorControl()
        {
            InitializeComponent();
        }

        private void InitializeImportanceDegreeControl()
        {           
            foreach (int value in Enum.GetValues(typeof(SerializationService.ImportanceDegree)))
            {
                string importanceDegreeStringValue = (string)Resources.ResourceManager.GetObject(value.ToString());

                SerializationService.ImportanceDegree importanceDegreeEnumValue;
                Enum.TryParse(importanceDegreeStringValue, out importanceDegreeEnumValue);
                _importanceDegree.Add(importanceDegreeEnumValue, importanceDegreeStringValue);
            }

            comboImportanceDegree.DataSource = new BindingSource(_importanceDegree, null);
            comboImportanceDegree.DisplayMember = "Value";
            comboImportanceDegree.ValueMember = "Key";
        }

        public SerializationService.ImportanceDegree SelectedImportanceDegree
        {
            set
            {
                comboImportanceDegree.SelectedItem = value;
            }
            get
            {
                return (SerializationService.ImportanceDegree)comboImportanceDegree.SelectedItem;
            }
        }

        private void ImportanceDegreeEditorControl_Load(object sender, EventArgs e)
        {
            InitializeImportanceDegreeControl();
        }
    }
}
