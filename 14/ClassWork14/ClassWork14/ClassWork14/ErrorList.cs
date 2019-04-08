using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ClassWork14
{
	class ErrorList : IDisposable, IEnumerable<string>
	{

		public static string OutputPrefixFormat()
		{
			return "mmmm dd, yyyy (hh:mm tt)";
		}
		public void WriteToConsole()
		{

			DateTimeOffset data = DateTimeOffset.Now.ToString(OutputPrefixFormat);
		}



		public string Category { get; private set; }
		private List<string> _errors;


		public ErrorList(string category)
		{
			_errors = new List<string>();
			Category = category;
		}

		public void Dispose()
		{
			if (_errors != null)
				_errors.Clear();
				_errors = null;
		}

		public void Add(string errorMesege)
		{
			_errors.Add(errorMesege);
		}

		public IEnumerator<string> GetEnumerator()
		{
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}
}
