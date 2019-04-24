using System;

namespace Reminder.Domain
{
	public class AddReminderModel
	{

		/// <summary>
		/// Gets or sets the date and time the reminder item scheduled for sending.
		/// </summary>
		public DateTimeOffset Date { get; set; }

		/// <summary>
		/// Gets or sets contact indentifier in the target.
		/// </summary>
		public string ContactId { get; set; }

		/// <summary>
		/// The message of the reminder item for sending to the recepient.
		/// </summary>
		public string Message { get; set; }


	}
}