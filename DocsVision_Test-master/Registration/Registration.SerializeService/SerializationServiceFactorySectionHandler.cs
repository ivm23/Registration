﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Registration.SerializationService
{
    public class SerializationServiceFactorySectionHandler : ConfigurationSection
    {
        [ConfigurationProperty("Name")]
        public string Name
        {
            get { return (string)base["Name"]; }
        }
    }
}
