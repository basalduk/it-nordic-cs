using System;
using System.Collections.Generic;

namespace L13_C07_interface_IDisposable_using_SW
{
	public class ErrorList: IDisposable
	{
		private readonly string _category;

		public string Category
		{
			get { return _category; }
		}

		public List<string> Errors { get; set; }

		public ErrorList(string category)
		{
			Errors = new List<string>();
			_category = category;
		}

		public void Dispose()
		{
			if (Errors != null)
			{
				Errors.Clear();
				Errors = null;
			}
		}
	}
}
