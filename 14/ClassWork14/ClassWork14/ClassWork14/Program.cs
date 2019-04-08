using System;

namespace ClassWork14
{
	class Program
	{
		static void Main(string[] args)
		{
			using(var errorList= new ErrorList("categoryes"))
			{
				errorList.Add("IO error");
				errorList.Add("Some unknown error");
				errorList.Add("dasfsa");

				foreach (string error in errorList)
				{
					Console.WriteLine("{0} {1}",errorList.WriteToConsole, errorList.Category);
				}
			}
		}
	}
}
