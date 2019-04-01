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
			//bool isOutdated;
			//AlarmDate < DateTimeOffset.Now
			//? isOutdated = true
			//: isOutdated = false;
			return true;
					
        }
		public void WriteProperties()
		{

			Console.WriteLine($"AlarmDate: {AlarmDate}\n AlarmMessage: {AlarmMessage}\n TimeToAlarm: {TimeToAlarm}\n ");

        }

    }
}
