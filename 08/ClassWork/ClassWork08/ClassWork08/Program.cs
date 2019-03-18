using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassWork08
{
	class Program
	{
		static void Main(string[] args)
		{
			//List<int> intList = new List<int>();
			//intList.Add(10);
			//intList.Add(20);
			//intList.Add(30);
			//intList.Add(40);

			//List<int> intList2 = new List<int> { 10, 20,30,40};

			//Console.WriteLine(string.Join(", ", intList2));
			//intList2.AddRange(new[] { 50, 60, 70, 80 });
			//intList2.RemoveRange(4, intList.Count -4 );
			//Console.WriteLine(string.Join(", ", intList2));




			//var countries = new Dictionary<string, string>();
			//countries.Add("Moscow", "Russia");
			//countries.Add("Madrid", "Spain");
			//countries.Add("Paris", "France");

			//int i = (new Random()).Next(2);
			//KeyValuePair<string, string> variant = countries.ElementAtOrDefault(i);
			//string capital = variant.Key;
			//string country = variant.Value;

			//Console.WriteLine("Назовите столицу {0}:", variant.Value);
			//string capitalUser = Console.ReadLine();


			//if (capitalUser == variant.Key)
			//{
			//	Console.WriteLine("Верно Столица {0} - {1}:", variant.Value, variant.Key);
			//}
			//else
			//{
			//	Console.WriteLine("Не верно столица {0} - {1}", variant.Value, variant.Key);
			//}

			//Queue<int> numbers = new Queue<int> ();

			//Console.WriteLine("Введите целые числа: ");

			//string run = "run";
			//string stop = "stop";

			//while (true)
			//{
			//	string result = Console.ReadLine();

			//	if (stop==result)
			//	{


			//	}

			//	else if(run== result)
			//	{
			//		foreach (float number in numbers)
			//		{
			//			var sqNumber = (float)Math.Sqrt(number);
			//			Console.WriteLine($"Квадратные корень {number} : {sqNumber}");
			//		}

			//	}

			//	else
			//	{
			//		numbers.Enqueue(int.Parse(Console.ReadLine()));
			//	}

			Stack<int> zadacha = new Stack<int>();
			Console.WriteLine("Введите wash, dry, exit");
			while (true)
			{
				string result = Console.ReadLine();

				switch(result)
				{
					case "wash":

						zadacha.Push(1);
						break;
					case "dry":

						break;
					case "exit":

						break;

					default:
						continue;

				}

			}




		}


		}
	}
}
