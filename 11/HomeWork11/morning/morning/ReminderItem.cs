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
                TimeSpan timeToAlarm = AlarmDate - DateTimeOffset.UtcNow;
                return timeToAlarm;
            }
        }

        public bool IsOutdated
        {
            get
            {
                int isOutdated = Convert.ToInt32( Math.Floor(TimeToAlarm.TotalSeconds));
                if (isOutdated >= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

        }
		public void WriteProperties()
		{
            Console.WriteLine($"AlarmDate: {AlarmDate}\n AlarmMessage: {AlarmMessage}\n TimeToAlarm: {TimeToAlarm}\n IsOutdated: {IsOutdated}");
        }

    }

}
