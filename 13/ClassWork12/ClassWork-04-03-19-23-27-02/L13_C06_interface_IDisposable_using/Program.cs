using System;
using System.IO;

namespace L13_C06_interface_IDisposable_using
{
	public static class Program
	{
		public static void Main()
		{
			using (var logger = new LogFileWriter())
			{
				logger.WriteToLog("Program has stated.");
				logger.WriteToLog("Somewhere in the middle.");
				logger.WriteToLog("Finish");

				//throw new Exception();	
			}
		}
	}
}
