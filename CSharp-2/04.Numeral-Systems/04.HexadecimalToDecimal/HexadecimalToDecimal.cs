using System;

namespace HexadecimalToDecimal
{
    class HexadecimalToDecimal
    {
        static void Main()
        {
            string hex = Console.ReadLine();
            long num = Int64.Parse(hex, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine(num);
        }
    }
}
