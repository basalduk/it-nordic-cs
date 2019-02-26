using System;

namespace CalculatorPro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите одно из предложенных математических действий (+, -, *, /, %, ^): ");
            char x = Convert.ToChar(Console.ReadLine());
            double result;

            if (x == '+') result = a + b;
            else if (x == '-') result = a - b;
            else if (x == '*') result = a * b;
            else if (x == '/') result = a / b;
            else if (x == '%') result = a % b;
            else if (x == '^') result = +Math.Pow(a, b);
            else result = ' ';

            if (result == ' ') Console.WriteLine("Введено некорректное математическое действие");
            else Console.WriteLine($"Результат математических вычислений: {a} {x} {b} = {result}");

            Console.ReadKey();
        }
    }
}
