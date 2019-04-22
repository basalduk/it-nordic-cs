using System;

namespace Reminder.Storage.Core
{

	public enum ReminderItemStatus
	{
		Awaiting,
		ReadyToSend,
		SuccessfillySent,
		Failed
	}
}