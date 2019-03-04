using System;

namespace ClassWork
{
	class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("Введите число 32");
			//int a = Int32.Parse(Console.ReadLine());
			//Console.WriteLine("Введите число 12");
			//int b = Int32.Parse(Console.ReadLine());
			//Console.WriteLine($" {a > b} : 32 >12 : true");
			//Console.WriteLine($" {a >= b} : 32>=12 : true");
			//Console.WriteLine($" {a < b} : 32<12 : false");
			//Console.WriteLine($" {a <= b} : 32<=12 : false");
			//Console.WriteLine($" {a == b} : 32==12 : false");

			//Console.WriteLine("Введите число Long");
			//long a = long.Parse(Console.ReadLine());
			//int b;
			//if (int.MinValue<=a&&a<= int.MaxValue) Console.WriteLine(b = (int)a);
			//else Console.WriteLine("Ошибка");

			Console.WriteLine("Введите число a");
			float a = float.Parse(Console.ReadLine());
			Console.WriteLine("Введите число h");
			float h = float.Parse(Console.ReadLine());
			Console.WriteLine("Результаты: ");

			float S = 3 * a * h;
			float Sp = 3f / 2f * a * (a * MathF.Sqrt(3) + 2f * h);
			float H = MathF.Sqrt(h * h / 2);
			float V = a * a / 2f*H* MathF.Sqrt(3);
			Console.WriteLine($"S= {S}");
			Console.WriteLine($"Sp= {Sp}");
			Console.WriteLine($"V= {V}");
			Console.ReadKey();

			//var result =new float[3];

			//for (int i = 0; i < result.Length; i++)
			//{
			//	Console.WriteLine(result);
			//}
		}
	}
}
