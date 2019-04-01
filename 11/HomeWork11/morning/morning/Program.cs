using System;

namespace morning
{
    class Program
    {
        static void Main(string[] args)
        {
            ReminderItem reminderItem1 = new ReminderItem
            {
                AlarmDate = DateTimeOffset.Parse("01/04/2019 08:00:00"),
                AlarmMessage = "morning"
            };
            ReminderItem reminderItem2 = new ReminderItem
            {
                AlarmDate = DateTimeOffset.Parse("01/04/2019 20:00:00"),
                AlarmMessage = "dinner"
            };
			reminderItem1.WriteProperties();
			reminderItem2.WriteProperties();

			Console.ReadKey();
        }


    }


}
