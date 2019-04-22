using System;
using System.Collections.Generic;

namespace Reminder.Storage.Core
{
	public interface IReminderStorage
	{
		/// <summary>
		/// Adds new reminder item
		/// </summary>
		void Add(ReminderItem remiderItem);
		
		/// <summary>
		/// Updates existing reminder item
		/// </summary>
		void Update(ReminderItem remiderItem);



		ReminderItem Get(Guid Id);



		List<ReminderItem> GetList(
			IEnumerable< ReminderItemStatus> status,
			int count,
			int startPosition);


	}
}
