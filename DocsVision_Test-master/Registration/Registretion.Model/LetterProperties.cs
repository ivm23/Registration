using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
    
using System.Threading.Tasks;

namespace Registration.Model
{
    public class LetterProperties
    {
        public XmlDocument Properties { get; set; } = new XmlDocument();

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            foreach (XmlElement el in Properties)
            {
                str.Append(el.InnerText);
            }
            return str.ToString();
        }
    }
}
