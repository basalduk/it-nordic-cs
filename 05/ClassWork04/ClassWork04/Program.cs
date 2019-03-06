using System;

namespace ClassWork04
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Console.WriteLine("Введите число");
				int i = Int32.Parse(Console.ReadLine());

				Console.WriteLine($"Число {i} " +
					(i >= 0
					? "положительное"
					: "отрицательное"));

			}
			catch (Exception e)
			{

				Console.WriteLine($"{e.GetType()}, {e.Message}");
				throw;
			}
			finally
			{
				Console.WriteLine("Введены неверные данные");
			}
		}
	}
}
