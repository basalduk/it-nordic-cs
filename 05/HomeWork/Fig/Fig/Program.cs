using System;

namespace Fig
{
    class Program
    {
        enum Figure
        {
         круг=1,
         равносторонний_треугольник,
         прямоугольник,
        }
        static void Main(string[] args)
        {
             while (true)
             {
                try
                {
                    Console.WriteLine("Введите тип фигуры (1 - круг, 2 - равносторонний треугольник, 3 - прямоугольник)");
                    Figure myFig = (Figure)Int32.Parse(Console.ReadLine());

                    switch (myFig)
                    {
                        case Figure.круг:
                            Console.WriteLine("Введите диаметр окружности: ");
                            float D = float.Parse(Console.ReadLine());
                            float Pr = (float)Math.PI * D;
                            float Sr = (float)Math.PI * D * D / 4;
                            Console.WriteLine($"Периметр окружности: {Math.Round(Pr, 2, MidpointRounding.AwayFromZero)}");
                            Console.WriteLine($"Площадь окружности: {Math.Round(Sr, 2, MidpointRounding.AwayFromZero)}");
                            break;

                        case Figure.равносторонний_треугольник:
                            Console.WriteLine("Введите сторону треугольника: ");
                            float St = float.Parse(Console.ReadLine());
                            float Ptr = 3 * St;
                            float Str = (St * St * (float)Math.Sqrt(3)) / 4;
                            Console.WriteLine($"Периметр равностороннего треугольник: {Math.Round(Ptr, 2, MidpointRounding.AwayFromZero)}");
                            Console.WriteLine($"Площадь равностороннего треугольник: {Math.Round(Str, 2, MidpointRounding.AwayFromZero)}");
                            break;

                        case Figure.прямоугольник:
                            Console.WriteLine("Введите ширину прямоугольник: ");
                            float Ap = float.Parse(Console.ReadLine());
                            Console.WriteLine("Введите высоту прямоугольника: ");
                            float Bp = float.Parse(Console.ReadLine());
                            float Pp = 2 * Ap + 2 * Bp;
                            float Sp = Ap * Bp;
                            Console.WriteLine($"Периметр прямоугольника: {Math.Round(Pp, 2, MidpointRounding.AwayFromZero)}");
                            Console.WriteLine($"Площадь прямоугольника: {Math.Round(Sp, 2, MidpointRounding.AwayFromZero)}");
                            break;

                        default:
                            Console.WriteLine("Ошибка! Необходимо вводить 1,2 или 3");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Ошибка! Введено нечисловое значение");
                }
                finally
                {
                    Console.WriteLine("\n");
                }
             }   
        }
    }
}
