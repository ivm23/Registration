﻿using System;
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
        public string Properties { get; set; }

        public override string ToString()
        {
            return Properties.ToString();
        }
    }
}
