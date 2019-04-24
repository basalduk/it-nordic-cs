using Reminder.Domain.EventArgs;


namespace Reminder.Domain.EventArgs
{
	public class SendingFaildEventArgs: System.EventArgs
	{
		public SendRemiderModel Reminder { get; set; }

		public SendingFaildEventArgs(SendRemiderModel reminder)
		{
			Reminder = reminder;
		}
	}
}
