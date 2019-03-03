using System;

namespace HomeWorkNameAge
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = new string[3];
            var age = new int[3];
            Console.WriteLine("Enter the names of 3 people: ");
            for (int i = 0; i < name.Length; i++)
            {
                name[i] = Console.ReadLine();
            }
            Console.WriteLine("Enter the age of these people: ");
            for (int i = 0; i < age.Length; i++)
            {
                age[i] = Int32.Parse(Console.ReadLine())+4;
            }
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine($"NAME: {name[i]}, age in 4 years: {age[i]}");
            }
            Console.ReadKey();
        }
    }
}
