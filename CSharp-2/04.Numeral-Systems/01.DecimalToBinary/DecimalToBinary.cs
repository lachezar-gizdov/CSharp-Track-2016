using System;

namespace DecimalToBinary
{
    static class DecimalToBinary
    {
        static void Main()
        {
            long dec = long.Parse(Console.ReadLine());
            string bin = String.Empty;

            DecToBin(dec, bin);
        }

        static void DecToBin(long dec, string bin)
        {
            while (dec >= 1)
            {
                if (dec % 2 == 0)
                {
                    bin = bin + "0";
                }
                else
                {
                    bin = bin + "1";
                }
                dec = dec / 2;
            }
            char[] binary = bin.ToCharArray();
            Array.Reverse(binary);
            Console.WriteLine(binary);
        }
    }
}
