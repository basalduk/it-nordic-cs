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
                return AlarmDate - DateTimeOffset.UtcNow;
            }
        }

        public bool IsOutdated
        {
            get
            {
                int isOutdated = Convert.ToInt32( Math.Floor(TimeToAlarm.TotalSeconds));
                return isOutdated >= 0;
            }
        }
		public void WriteProperties()
		{
            Console.WriteLine(
                $"AlarmDate: {AlarmDate}\n " +
                $"AlarmMessage: {AlarmMessage}\n " +
                $"TimeToAlarm: {TimeToAlarm}\n " +
                $"IsOutdated: {IsOutdated}");
        }

    }

}
