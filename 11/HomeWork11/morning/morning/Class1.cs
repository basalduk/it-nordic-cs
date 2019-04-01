using System;
using System.Collections.Generic;
using System.Text;

namespace morning
{
    public class ReminderItem
    {
        public DateTimeOffset AlarmDate;
        public string AlarmMessage;
        public TimeSpan TimeToAlarm
        {
            get
            {
                TimeSpan timeToAlarm = DateTimeOffset.UtcNow.Subtract(AlarmDate);
                return timeToAlarm;
            }
        }

        public bool IsOutdated ()
        {
            return true;
        }
        public string WriteProperties
        {
            get
            {
                return $"AlarmDate: {AlarmDate}\n AlarmMessage: {AlarmMessage}\n TimeToAlarm: {TimeToAlarm}\n IsOutdated: {IsOutdated}";
            }
        }

    }
}
