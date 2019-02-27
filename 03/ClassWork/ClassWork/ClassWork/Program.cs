using System;

namespace ClassWork
{
	class Program
	{
		static void Main(string[] args)
		{
			//dynamic obj;
			//dynamic obj2;
			//obj = 10;
			//obj2 = "5.12";

			//var a = 3.14f;
			//var b = 1.00;// 1D
			//var c = 49L;
			//var d = (byte)255;

			//Console.Write(a.GetType());
			//Console.Write(b.GetType());
			//Console.Write(c.GetType());
			//Console.Write(d.GetType());


			//Console.WriteLine(obj + double.Parse(obj2, System.Globalization.CultureInfo.InvariantCulture.NumberFormat));
			//Console.WriteLine($"{ default(String)}");
			var mass = new string[4];
			

			for (int i = 0; i < mass.Length; i++)
			{
				mass[i] = Console.ReadLine();
			}

			for (int i = 0; i < mass.Length; i++)
			{
				 Console.WriteLine(mass[i]);
			}

			Console.ReadKey();




		}
	}
}
