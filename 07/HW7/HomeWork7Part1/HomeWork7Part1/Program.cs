using System;

namespace HomeWork7Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string:");

            string yourString;
            string[] summWord;
            int summA = 0;

            while (true)
            {
                yourString = Console.ReadLine();

                summWord = yourString.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (summWord.Length >= 2)
                    break;

                Console.WriteLine("Enter at least 2 words, try again");
            }

            foreach (string s in summWord)
            {
                if (s[0] == 'A' || s[0] == 'a' || s[0] == 'А' || s[0] == 'а') //Русские и Английские буквы
                    summA += 1;
            }

            Console.WriteLine($"Number of words starting with the letter 'A': {summA}\n" +
                              $"Press Enykey");

            Console.ReadKey();
        }
    }
}
