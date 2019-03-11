using System;

namespace ClassWork
{
	class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("Введите строку");

			//do
			//{
			//	string a;
			//	a = Console.ReadLine();

			//	if (a == "exit")
			//	{
			//		break;
			//	};

			//	if (a.Length > 15)
			//	{
			//		Console.WriteLine("Символов больше 15");
			//		continue;
			//	}
			//	Console.WriteLine($"Количество символов {a.Length}");
			//}
			//while (true);

			//int[] mass = { 1, 2, 3, 3, 4};
			//int i=0;
			//int sum=0;
			//while (i<mass.Length)
			//{
			//	sum += mass[i];
			//	Console.WriteLine($"result {sum}");
			//	i++;
			int sum = 0
			var marks = new[]
			{
				new[] { 2, 3, 3, 2, 3 },
				new[] { 2, 3, 3, 2, 3 },
				null,
				new[] { 2, 3, 3, 2, 3 },
				new[] { 2, 3, 3, 2, 3 },
				new[] { 2, 3, 3, 2, 3 }
			};
			for (int i = 1; i < marks[i].Length; i++)
			{


				for (int x = 1; x < marks[i[x]].Length; i++)
				{
					sum += marks[i];
					Console.WriteLine($"result {sum}"
				}


			}



			}

		}
	}
}
