using System;

namespace Chet
{
    class Program
    {
    
        static void Main(string[] args)
        {
           
             while (true)
            {
                Console.WriteLine("Введите положительное натуральное число не более 2 миллиардов: ");
                string a = Console.ReadLine();
                int result = 0;

                try
                {
                    if (Int64.Parse(a) > 0 & Int64.Parse(a) < 2000000000)
                    {

                        foreach (int t in a)
                        {
                            if (t % 2 == 0) result++;
                        }

                        Console.WriteLine($"В числе {a} содержится следующее количество четных цифр: {result} ");

                    }
                    else
                    {
                        throw new OverflowException();
                    }
                }
                catch (FormatException ex1)
                {
                    Console.WriteLine("Ошибка {0} Попробуйте еще раз: ", ex1.GetType());
                }

                catch (OverflowException ex2)
                {
                    Console.WriteLine("Ошибка {0} Попробуйте еще раз: ",ex2.GetType());
                }
            }
        }
    }
}