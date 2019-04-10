using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork15
{
	class Account<T>
	{
		public T TId { get; private set; }
		public string TName { get; private set; }

		public Account(T id, string name)
		{
			TId = id;
			TName = name;
		}
		public void  WiteProperty()
		{
			Console.WriteLine($"{TId} {TName}");
		}

	}
}
