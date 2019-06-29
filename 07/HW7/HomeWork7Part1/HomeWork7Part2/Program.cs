using System;

namespace HomeWork7Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string:");

            string yourString;
            string[] arrayWord;
            string yourStringConverted = "";

            while (true)
            {
                yourString = Console.ReadLine();

                arrayWord = yourString.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (arrayWord.Length >= 1)
                    break;

                Console.WriteLine("Your string is empty, try again");
            }


            for (int i = yourString.Length - 1; i >= 0; --i)
            {
                yourStringConverted += (yourString.ToLower())[i];
            }


            Console.WriteLine($"Your string converted: {yourStringConverted}\n" +
                              $"Press Enykey");

            Console.ReadKey();


        }
    }
}
