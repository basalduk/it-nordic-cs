using System;

namespace bank
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите сумму первоначального взноса в рублях: ");
                    var rub = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Введите ежедневный процент дохода в виде десятичной дроби (1% = 0,01): ");
                    var p = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Введите желаемую сумму накопления в рублях: ");
                    var rub2 = decimal.Parse(Console.ReadLine());

                    var day = (int)Math.Ceiling((rub2 - rub) / (p * rub));

                    if (rub2 >= rub)
                    {
                        Console.WriteLine("Необходимое количество дней для накопления желаемой суммы: {0}", day);
                    }
                    else
                    {
                        throw new OverflowException();
                    }

                }
                catch (OverflowException ex1)
                {
                    Console.WriteLine("Ошибка {0} Желаемая сумма накоплений должна быть более первоначального взноса: ", ex1.GetType());
                }
                catch (FormatException ex2)
                {
                    Console.WriteLine("Ошибка {0} Попробуйте еще раз: ", ex2.GetType());
                }

            }
        }
    }
}
