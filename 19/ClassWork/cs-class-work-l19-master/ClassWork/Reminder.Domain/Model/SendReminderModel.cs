using System;

namespace Reminder.Domain.Model
{
	/// <summary>
	/// The single reminder item.
	/// </summary>
	public class SendReminderModel
	{
		/// <summary>
		/// Gets the identifier.
		/// </summary>
		public Guid Id { get; set; } = Guid.NewGuid();


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

