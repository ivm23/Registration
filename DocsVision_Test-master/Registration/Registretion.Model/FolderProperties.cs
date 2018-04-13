using System;
using System.Collections.Generic;
using System.Xml;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Model
{
    public class FolderProperties
    {
        public IDictionary<string, string> Properties { get; } = new Dictionary<string, string>();
        public XmlDocument Info { get; set; } = new XmlDocument();

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            foreach (XmlElement el in Info)
            {
                str.Append(el.InnerText);
            }
            return str.ToString();
        }
    }
}
