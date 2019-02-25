using System;

namespace ClassWorkapps
{
	class Program
	{
		static void Main(string[] args)
		{
			
			Console.WriteLine("Введите радиус: ");
			float r = float.Parse(Console.ReadLine());
			float result = (float)Math.PI * r * r;
			Console.WriteLine("площадь круга равна: {0}", result);


		}
	}
}
