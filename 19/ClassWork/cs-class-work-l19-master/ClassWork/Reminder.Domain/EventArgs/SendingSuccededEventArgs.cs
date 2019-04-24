using Reminder.Domain.EventArgs;
using Reminder.Domain.Model;

namespace Reminder.Domain.EventArgs
{
	public class SendingSuccededEventArgs: System.EventArgs
	{
		private SendReminderModel sendReminder;

		public SendRemiderModel Reminder { get; set; }

		public SendingSuccededEventArgs(SendRemiderModel reminder)
		{
			Reminder = reminder;
		}

		public SendingSuccededEventArgs(SendReminderModel sendReminder)
		{
			this.sendReminder = sendReminder;// Проверить!!!!
		}
	}
}
