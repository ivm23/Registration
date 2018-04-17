using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.SerializationService
{
    public interface ISerializationService 
    {
        string Serialization();
        void Deserialization(string dataString);
    }
}
