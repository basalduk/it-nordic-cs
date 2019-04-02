using System;

namespace morning
{
    class Program
    {
        static void Main(string[] args)
        {
            var reminderItem1 = new ReminderItem
            {
                AlarmDate = DateTimeOffset.Parse("02/04/2019 06:00:00"),
                AlarmMessage = "morning"
            };
            var reminderItem2 = new ReminderItem
            {
                AlarmDate = DateTimeOffset.Parse("02/04/2019 22:00:00"),
                AlarmMessage = "supper"
            };
			reminderItem1.WriteProperties();
			reminderItem2.WriteProperties();

			Console.ReadKey();
        }
    }
}
