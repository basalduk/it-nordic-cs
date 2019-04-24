using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reminder.Domain;
using Reminder.Storage.InMemory;
using System;
using System.Threading;

namespace Remainder.Domain.Test
{
	[TestClass]
	public class ReminderDomainTest
	{
		[TestMethod]

		public void Check_That_Reminder_Calls_Internal_Delegate()
		{
			var reminderStorage = new ReminderStorage();
			var remainderDomain = new ReminderDomain(reminderStorage);

			bool delegateWasCalled = false;

			remainderDomain.SendReminder += (reminder) =>
			{
				delegateWasCalled = true;

			};
			remainderDomain.Add(new AddReminderModel
			{
				Date = DateTimeOffset.Now
			});

			remainderDomain.Run();

			Thread.Sleep(2000);

			Assert.IsTrue(delegateWasCalled);
		}
		[TestMethod]

		public void Check_That_Reminder_Can_Thrown_Exeption()
		{
			var reminderStorage = new ReminderStorage();
			var remainderDomain = new ReminderDomain(reminderStorage);



			remainderDomain.SendReminder += (reminder) =>
			{
				throw new Exception();

			};
			remainderDomain.Add(new AddReminderModel
			{
				Date = DateTimeOffset.Now
			});

			remainderDomain.Run();

			Thread.Sleep(2000);

		}
	}

}
