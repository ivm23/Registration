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
    public partial class WorkersEditorControl : UserControl
    {
        public WorkersEditorControl()
        {
            InitializeComponent();
        }

        public IEnumerable<string> GetWorkers()
        {
            IEnumerable<string> workers = new List<string>();
            workers = txtWorkers.Text.Split(';');
            return workers;
        }

        public void SetWorkers(IEnumerable<string> workers)
        {
            StringBuilder workersString = new StringBuilder();
            foreach (string worker in workers)
            {
                workersString.Append(worker).Append("; ");
            }

            txtWorkers.Text = workersString.ToString();
        }
    }
}
