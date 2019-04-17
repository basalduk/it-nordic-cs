using System;

namespace L15_HW1_solution.LogWriter
{
	public class ConsoleLogWriter : AbstractLogWriter, ILogWriter
	{
		protected override void LogRecord(string message, LogRecordType logRecordType)
		{
			Console.WriteLine(base.GetLogRecord(message, logRecordType));
		}
	}
}
