using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
    
using System.Threading.Tasks;

namespace Registration.SerializationService
{
    public class LetterProperties
    {
        public string Properties { get; set; }

        public override string ToString()
        {
            return Properties.ToString();
        }
    }
}
