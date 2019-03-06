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

            Console.WriteLine("Какой объем сока требуется упаковать?");
            float V = float.Parse(Console.ReadLine());
            
            var usedPackageTypes = PackageSizeType.None;

            if (V > 0)
            {

                usedPackageTypes = usedPackageTypes | PackageSizeType.large;

                bool isSmallNonUsed = (usedPackageTypes & PackageSizeType.small)== PackageSizeType.small;
                bool isMediumNonUsed = (usedPackageTypes & PackageSizeType.medium) == PackageSizeType.medium;
                bool isLargeNonUsed = (usedPackageTypes & PackageSizeType.large) == PackageSizeType.large;
            }
            else
            {
                Console.WriteLine("Указан некорректный объем");
            }

        }
    }
}
