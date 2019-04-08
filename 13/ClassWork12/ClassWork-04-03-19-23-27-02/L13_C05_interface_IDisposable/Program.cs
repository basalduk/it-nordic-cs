using System;
using System.IO;

namespace L13_C05_interface_IDisposable
{
	public static class Program
	{
		public static void Main()
		{
			var logger = new LogFileWriter();

			logger.WriteToLog("Program has stated.");
			logger.WriteToLog("Somewhere in the middle.");
			logger.WriteToLog("Finish");

			//throw new Exception();

			logger.Dispose();
		}
	}
}
