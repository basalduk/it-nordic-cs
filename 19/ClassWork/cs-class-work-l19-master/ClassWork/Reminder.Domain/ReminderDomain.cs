using System;
using Reminder.Storage.Core;
using System.Threading;
using System.Linq;
using Reminder.Domain.Model;
using Reminder.Domain.EventArgs;

namespace Reminder.Domain
{
	public class ReminderDomain
	{
		const int _deltaToCheckAwaitingReminders=1000;
		const int _deltaToSendReadyReminders = 1000;

		private readonly IReminderStorage _storage;

		public Action<SendReminderModel> SendReminder { get; set; }

		public event EventHandler<SendingSuccededEventArgs> SendingSucceded;
		public event EventHandler<SendingFaildEventArgs> SendingFaild;

		public ReminderDomain(IReminderStorage storage)
		{
			_storage = storage;

		}

		public void Run()
		{
			var awaitingRemindersCheckTimer = new Timer(
				CheckAwaitingReminders,
				null,
				TimeSpan.Zero,
				TimeSpan.FromMilliseconds(_deltaToCheckAwaitingReminders));

			var areadyReminderSendTimer = new Timer(
				SendReadyReminding,
				null,
				TimeSpan.Zero,
				TimeSpan.FromMilliseconds(_deltaToSendReadyReminders));

		}

		public void Add(AddReminderModel addreminderModel)

		{
			_storage.Add(new ReminderItem
			{
				Date = addreminderModel.Date,
				ContactId = addreminderModel.ContactId,
				Message = addreminderModel.Message,
				Status = ReminderItemStatus.Awaiting
			}
				);
		}
			public void CheckAwaitingReminders(object dummy)
			{
			var ids = _storage
				.Get(ReminderItemStatus.Awaiting)
				.Where(r => r.IsTimeToSend)
				.Select(r => r.Id)
				.ToList();

			_storage.UpdateStatus(ids, ReminderItemStatus.Ready);
			}
			public void SendReadyReminding(object dummy)
			{

			var sendReminderModels = _storage
				.Get(ReminderItemStatus.Ready)
				.Where(r => r.IsTimeToSend)
				.Select(r => new SendReminderModel
				{

					Id = r.Id,
					Message = r.Message,
					ContactId = r.ContactId
				})
				.ToList();

			foreach (SendReminderModel sendReminder in sendReminderModels)
			{
				try
				{
					SendReminder?.Invoke(sendReminder);

					_storage.UpdateStatus(
						sendReminder.Id,
						ReminderItemStatus.Sent);

					SendingSucceded?.Invoke(
						this,
						new SendingSuccededEventArgs(sendReminder));
				}
				catch (Exception exeption)
				{
					_storage.UpdateStatus(
						sendReminder.Id,
					ReminderItemStatus.Failed);

				}
			}
		}
	}
}
