using L15_HW1_solution.LogWriter;

namespace L15_HW1_solution
{
	class Program
	{
		static void Main(string[] args)
		{
			LogWriterFactory factory = new LogWriterFactory();

			var consoleLogger = factory.GetLogWriter<ConsoleLogWriter>(null);
			var fileLogger = factory.GetLogWriter<FileLogWriter>("log.txt");

			using (var logger = (MultipleLogWriter)factory.GetLogWriter<MultipleLogWriter>(
				new[] { consoleLogger, fileLogger }))
			{
				logger.LogInfo("Test information message");
				logger.LogWarning("Test warning message");
				logger.LogError("Test error message");
			}
		}
	}
}
