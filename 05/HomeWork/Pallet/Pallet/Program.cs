using System;

namespace Pallet
{
    class Program
    {
        [Flags]

        enum Mycolor 
        {
            Blue=0x1,
            Cyan = 0x1 << 1,
            Grey = 0x1 << 2,
            Green = 0x1 << 3,
            Magenta = 0x1 << 4,
            Red = 0x1 << 5,
            White = 0x1 << 6,
            Yellow = 0x1 << 7,
            Black = 0x1 <<8
        }
        static void Main(string[] args)
        {

            Mycolor likeColors = (Mycolor)0;
            Mycolor allColors = (Mycolor)511;
            Console.WriteLine("Имеется палитра цветов: Blue, Cyan, Grey, Green, Magenta, Red, White, Yellow, Black");
            for (int i = 1; i < 5; i++)
            {
                while (true)
                { object color;
                    Console.Write($"Введите любимый цвет {i}\n");
                    if (Enum.TryParse(
                        typeof(Mycolor),
                        Console.ReadLine(),
                        true,
                        out color))
                    {
                        likeColors |= (Mycolor)color;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка!");
                    }
                }
            }

            Console.WriteLine($"Избранные цвета: {likeColors}");
            Mycolor unLikeColors = (Mycolor) allColors^likeColors;
            Console.WriteLine($"Цвета невошедшие в Избранное: {unLikeColors}");
            Console.ReadKey();
        }
    }
}
