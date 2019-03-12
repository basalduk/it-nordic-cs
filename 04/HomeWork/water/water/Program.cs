using System;

namespace water
{
    class Program
    {
        [Flags]
        enum PackageSizeType : byte
        {
            None = 0x0,
            small = 0x1,
            medium = 0x1 << 1,
            large = 0x1 << 2,
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Какой объем сока требуется упаковать?");
                float V = float.Parse(Console.ReadLine());

                var usedPackageTypes = PackageSizeType.None;

                if (V > 0)
                {
                    float valueLarge = (float)Math.Floor(V / 20);
                    float valueMedium = (float)Math.Floor((V % 20) / 5);
                    float valueSmall = (float)Math.Ceiling(((V % 20) % 5));

                    if (valueLarge > 0) usedPackageTypes = usedPackageTypes | PackageSizeType.large;
                    if (valueMedium > 0) usedPackageTypes = usedPackageTypes | PackageSizeType.medium;
                    if (valueSmall > 0) usedPackageTypes = usedPackageTypes | PackageSizeType.small;

                    bool isSmallUsed = (usedPackageTypes & PackageSizeType.small) == PackageSizeType.small;
                    bool isMediumUsed = (usedPackageTypes & PackageSizeType.medium) == PackageSizeType.medium;
                    bool isLargeUsed = (usedPackageTypes & PackageSizeType.large) == PackageSizeType.large;

                    Console.WriteLine("Вам потребуются следующие контейнеры: ");

                    if (isLargeUsed) Console.WriteLine($"20 л: {valueLarge} шт.");
                    if (isMediumUsed) Console.WriteLine($" 5 л: {valueMedium} шт.");
                    if (isSmallUsed) Console.WriteLine($" 1 л: {valueSmall} шт.");
                }
                else
                {
                    Console.WriteLine("Указан некорректный объем");
                }
            }
        }
    }
}
