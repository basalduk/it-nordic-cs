using System;

namespace HomeWork10
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] arrayPerson = new Person[3];

            for (int i = 0; i < 3; ++i)
            {
                arrayPerson[i] = new Person(); 

                Console.WriteLine($"Enter name {i}:");
                arrayPerson[i].Name = Console.ReadLine();

                Console.WriteLine($"Enter Age {i}:");
                arrayPerson[i].Age =  Convert.ToByte(Console.ReadLine());

            }

            for (int i = 0; i < 3; ++i)
            {
                Console.WriteLine(arrayPerson[i].PersonString);
            }

            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
        }
    }
}
