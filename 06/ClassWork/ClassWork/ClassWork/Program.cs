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
            var marks = new[]
            {
				new[] { 2, 3, 3, 2, 3 },
				new[] { 2, 4, 5, 3 },
				null,
				new[] { 5, 5, 5, 5, 5 },
				new[] { 4, },
			};
            int totalSum = 0;

            int numberOfMarks = 0;

            for (int dayIndex = 0; dayIndex < marks.Length; dayIndex++)
            {
                if (marks[dayIndex] == null)
                {
                    Console.WriteLine($"The average mark for day {dayIndex+1} is N/A");
                    continue;
                }
                int dailySum = 0;
                for (int markIndex = 0; markIndex < marks[dayIndex].Length; markIndex++)
                {
                    dailySum += marks[dayIndex][markIndex];
                }

                Console.WriteLine($"The average mark for day {dayIndex+1} is {(float)dailySum / marks[dayIndex].Length}");


                totalSum += dailySum;
                numberOfMarks += marks[dayIndex].Length;
            }

            Console.WriteLine($"The average mark for all the week is {(float)totalSum / numberOfMarks}");
                

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
	}
}
