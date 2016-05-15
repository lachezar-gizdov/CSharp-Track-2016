using System;

namespace HexadecimalToBinary
{
    class HexadecimalToBinary
    {
        static void Main()
        {
            string hex = Console.ReadLine();
            string bin = string.Empty;
            long num = long.Parse(hex, System.Globalization.NumberStyles.HexNumber);

            DecToBin(num, bin);
        }

        static void DecToBin(long num, string bin)
        {
            while (num >= 1)
            {
                if (num % 2 == 0)
                {
                    bin = bin + "0";
                }
                else
                {
                    bin = bin + "1";
                }
                num = num / 2;
            }
            char[] binary = bin.ToCharArray();
            Array.Reverse(binary);
            Console.WriteLine(binary);
        }
    }
}
