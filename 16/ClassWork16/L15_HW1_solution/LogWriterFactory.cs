using System;
using System.Collections.Generic;
using L15_HW1_solution.LogWriter;

namespace L15_HW1_solution
{
	public class LogWriterFactory
	{
		public ILogWriter GetLogWriter<T>(object parameters) where T : ILogWriter
		{
			if (typeof(T) == typeof(ConsoleLogWriter))
			{
				return new ConsoleLogWriter();
			}
			else if (typeof(T) == typeof(FileLogWriter))
			{
				if(!(parameters is string))
				{
					throw new ArgumentException(
						nameof(parameters),
						"It is assumed to have a string type for this parameter" +
							" with the file name.");
				}

				return new FileLogWriter((string)parameters);
			}
			else if (typeof(T) == typeof(MultipleLogWriter))
			{
				if (!(parameters is ILogWriter[]))
				{
					throw new ArgumentException(
						nameof(parameters),
						"It is assumed to have a IEnumerable<ILogWriter> type" +
							" for this parameter with the list of loggers to use.");
				}

				return new MultipleLogWriter(parameters as ILogWriter[]);
			}

			return null;
		}

	}
}
