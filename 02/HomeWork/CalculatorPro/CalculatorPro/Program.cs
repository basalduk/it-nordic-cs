using System;

namespace CalculatorPro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите одно из предложенных математических действий (+, -, *, /, %, ^): ");
            char x = Convert.ToChar(Console.ReadLine());

            switch (x) // решение с помощью оператора Switch
            {
                case '+': Console.WriteLine("Результат математичекого вычисления a + b = {0}", a + b);
                    break;
                case '-': Console.WriteLine("Результат математичекого вычисления a - b = {0}", a - b);
                    break;
                case '*': Console.WriteLine("Результат математичекого вычисления a * b = {0}", a * b);
                    break;
                case '/': Console.WriteLine("Результат математичекого вычисления a / b = {0}", a / b);
                    break;
                case '%': Console.WriteLine("Результат математичекого вычисления a % b = {0}", a % b);
                    break;
                case '^': Console.WriteLine("Результат математичекого вычисления a ^ b = {0}", +Math.Pow(a, b));
                    break;
            }



            //if (x == '+') // решение с помощью оператора if
            //    Console.WriteLine("Результат математичекого вычисления a + b = {0}", a + b);
            //else if (x == '-')
            //    Console.WriteLine("Результат математичекого вычисления a - b = {0}", a - b);
            //else if (x == '*')
            //    Console.WriteLine("Результат математичекого вычисления a * b = {0}", a * b);
            //else if (x == '/')
            //    Console.WriteLine("Результат математичекого вычисления a / b = {0}", a / b);
            //else if (x == '%')
            //    Console.WriteLine("Результат математичекого вычисления a % b = {0}", a % b);
            //else if (x == '^')
            //    Console.WriteLine("Результат математичекого вычисления a ^ b = {0}", +Math.Pow(a, b));


            Console.ReadKey();
        }
    }
}
