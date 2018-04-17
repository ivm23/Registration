using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.SerializationService
{
    [Serializable]
    public class LetterWithReminderData
    {
        public DateTime ReminderData { get; set; }
    }
}
