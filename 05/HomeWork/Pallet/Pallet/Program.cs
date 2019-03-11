using System;

namespace Pallet
{
    class Program
    {
        [Flags]

        enum collor : byte
        {
            Non = 0x0,
            Blue=0x1,
            Cyan = 0x1 << 1,
            Grey = 0x1 << 2,
            Green = 0x1 << 3,
            Magenta = 0x1 << 4,
            Red = 0x1 << 5,
            White = 0x1 << 6,
            Yellow = 0x1 << 7,
        }
        static void Main(string[] args)
        {
            

                Console.WriteLine("Введите цвет №1 (Blue, Cyan, Grey, Green, Magenta, Red, White, Yellow):");
                collor LikeCollor = (collor)Enum.Parse(typeof(collor), Console.ReadLine());

                Console.WriteLine("Введите цвет №2 (Blue, Cyan, Grey, Green, Magenta, Red, White, Yellow):");
                collor LikeCollor2 =  LikeCollor | (collor)Enum.Parse(typeof(collor), Console.ReadLine());

                Console.WriteLine("Введите цвет №3 (Blue, Cyan, Grey, Green, Magenta, Red, White, Yellow):");
                collor LikeCollor3 = LikeCollor2 | (collor)Enum.Parse(typeof(collor), Console.ReadLine());

                Console.WriteLine("Введите цвет №4 (Blue, Cyan, Grey, Green, Magenta, Red, White, Yellow):");
                collor LikeCollor4 = LikeCollor3 | (collor)Enum.Parse(typeof(collor), Console.ReadLine());


                Console.WriteLine($"Избранные цвета: {LikeCollor4}");
                collor unLike = ~LikeCollor4;
                Console.WriteLine($"Цвета невошедшие в Избранное: {unLike}");



        }
    }
}
