using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registrstion.WinForms.Controlers
{
    public partial class ImportanceDegreeEditorControl : UserControl
    {
        private IDictionary<int, string> _importanceDegree;

        public ImportanceDegreeEditorControl()
        {
            InitializeComponent();
        }

        public void SetImportanceDegree(IDictionary<int, string> importanceDegrees)
        {
            _importanceDegree = importanceDegrees;
            comboImportanceDegree.DataSource = "Value" ;
            comboImportanceDegree.DisplayMember = "Key";
            /*comboImportanceDegree.Items.Clear();
            comboImportanceDegree.Items.AddRange(importanceDegrees.Values.ToArray());*/
        }

        public KeyValuePair<int, string> GetImportanceDegree()
        {
            return (KeyValuePair<int, string>)comboImportanceDegree.SelectedItem;
        }

        public void SetSelectedImportanceDegree(KeyValuePair<int, string> selectedImportanceDegree)
        {
            comboImportanceDegree.SelectedItem = selectedImportanceDegree;
        }
    }
}
