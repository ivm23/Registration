﻿using System;
using System.Collections.Generic;
using System.Xml;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.SerializationService
{
    public class FolderProperties
    {
        public IDictionary<string, string> Properties { get; } = new Dictionary<string, string>();
     
    }
}
