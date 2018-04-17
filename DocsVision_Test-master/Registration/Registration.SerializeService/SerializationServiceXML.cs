using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Registration.SerializationService
{
     public class SerializationServiceXML : ISerializationService
    {
        public string Serialization()
        {
            /*var xmlSerializer = new XmlSerializer(typeof(T));

            using (var stringWriter = new StringWriter())
            {
                using (var writer = XmlWriter.Create(stringWriter))
                {
                    xmlSerializer.Serialize(writer, data);
                    return stringWriter.ToString();
                }
            }*/
            return null;
        }

        public void Deserialization(string dataString)
        {
            //var xmlSerializer = new XmlSerializer(typeof(T));

            using (var stringReader = new StringReader(dataString))
            {
                using (var reader = XmlReader.Create(stringReader))
                {
                    //return (T)xmlSerializer.Deserialize(reader);
                }
            }
            
        }

    }
}
