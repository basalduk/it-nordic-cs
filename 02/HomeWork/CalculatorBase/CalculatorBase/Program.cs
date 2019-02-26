using System;

namespace CalculatorBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            float b = float.Parse(Console.ReadLine());
            float result1 = a + b;
            float result2 = a - b;
            float result3 = a * b;
            Console.WriteLine("Результаты математических вычислений: ");
            Console.WriteLine("a + b = {0}", result1);
            Console.WriteLine("a - b = {0}", result2);
            Console.WriteLine("a * b = {0}", result3);
            Console.ReadKey();
        }
    }
}
