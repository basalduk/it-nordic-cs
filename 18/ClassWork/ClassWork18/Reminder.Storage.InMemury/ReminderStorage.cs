using System;
using System.Collections.Generic;
using Reminder.Storage.Core;


namespace Reminder.Storage.InMemory
{
	public class ReminderStorage : IReminderStorage
	{
		private Dictionary<Guid, ReminderItem> _storage;

		public ReminderStorage()
		{
			_storage = new Dictionary<Guid, ReminderItem>();

		}

		public void Add(ReminderItem remiderItem)
		{
			/// TODO: add custom exeption throwing if already exists
			_storage.Add(remiderItem.Id, remiderItem);
		}

		public ReminderItem Get(Guid Id)
		{
			return _storage.ContainsKey(Id) 
				? _storage[Id] 
				: null;
		}



		public List<ReminderItem> GetList(IEnumerable< ReminderItemStatus> status, int count, int startPosition)
		{
			throw new NotImplementedException();
		}

		public void Update(ReminderItem remiderItem)
		{
			/// TODO: add custom exeption throwing if not found
			_storage[remiderItem.Id]=remiderItem;
		}
	}
}
