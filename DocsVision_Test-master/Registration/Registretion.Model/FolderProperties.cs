using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Model
{
    public class FolderProperties
    {
        public IDictionary<string, string> Properties { get; } = new Dictionary<string, string>();
    }
}
