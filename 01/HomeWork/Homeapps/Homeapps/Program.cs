using System;
using System.Threading;

namespace Homeapps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();
            Thread.Sleep(5000);
            Console.WriteLine($"Приветствую, {name}!");
            Thread.Sleep(5000);
            Console.WriteLine($"До скорых встреч, {name}!");
            Console.ReadKey();
        }
    }
}
