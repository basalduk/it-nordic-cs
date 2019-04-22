using System;
using System.Collections.Generic;
using System.Text;

namespace ChatBot
{
    class ReminderItem
    {
        public Guid Id { get; }
        public DateTimeOffset AlarmDate { get; set; }
        public string Message { get; set; }
        public string ContactId { get; set; }
        public bool IsOutdated { get; }
        public string Property()
        {
            return " ";
        }
    }
}
