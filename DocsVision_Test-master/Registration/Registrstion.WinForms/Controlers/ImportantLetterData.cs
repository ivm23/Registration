﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Registrstion.WinForms.Controlers
{
    [Serializable]
    public class ImportantLetterData
    {
        public KeyValuePair<int, string> DegreeImportance { get; set; }
    }
}
