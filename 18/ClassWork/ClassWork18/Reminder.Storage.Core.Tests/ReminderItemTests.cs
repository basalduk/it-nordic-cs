using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Reminder.Storage.Core.Tests
{
	[TestClass]
	public class ReminderItemTests
	{
		[TestMethod]
		public void Constructor_Validly_Sets_Id_Property()
		{
			// Подготовка 
			Guid expected = new Guid("63886D2C-8D1C-428C-9AC0-45DDD58F982B");

			// Running
			var reminderItem = new ReminderItem(
				new Guid("63886D2C-8D1C-428C-9AC0-45DDD58F982B"),
				DateTimeOffset.MinValue,
				null,
				null);

			// Checking
			Assert.AreEqual(expected, reminderItem.Id);
		}
		[TestMethod]
		public void Constructor_Validly_Sets_Date_Property()
		{
			// Подготовка 
			var expected = DateTimeOffset.Now;

			// Running
			var reminderItem = new ReminderItem(
				Guid.Empty,
				expected,
				null,
				null);

			// Checking
			Assert.AreEqual(expected, reminderItem.Date);
		}

		[TestMethod]
		public void Constructor_Validly_Sets_TimeToSpane_Property()
		{

			// Подготовка 
			var reminderItem = new ReminderItem(
		Guid.Empty,
		DateTimeOffset.UtcNow + TimeSpan.FromMilliseconds(500),
		null,
		null);
			var actual = reminderItem.TimeToSend;


			Assert.IsTrue(
				actual< TimeSpan.FromMilliseconds(500)&& 
				actual>TimeSpan.Zero);
		}
		[TestMethod]
		public void TimeToSpane_Is_Less_Than_Zero_For_past_Time_Date()
		{

			// Подготовка 
			var reminderItem = new ReminderItem(
		Guid.Empty,
		DateTimeOffset.UtcNow - TimeSpan.FromDays(1),
		null,
		null);
			var actual = reminderItem.TimeToSend;


			Assert.IsTrue(actual < TimeSpan.Zero);
		}
	}
}
