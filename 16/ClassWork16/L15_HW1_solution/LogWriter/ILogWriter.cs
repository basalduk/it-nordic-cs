namespace L15_HW1_solution.LogWriter
{
	public interface ILogWriter
	{
		void LogInfo(string message);

		void LogWarning(string message);

		void LogError(string message);
	}
}
