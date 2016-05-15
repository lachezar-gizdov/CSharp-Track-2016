using System;

namespace DecimalToHexadecimal
{
    class DecimalToHexadecimal
    {
        static void Main()
        {
            long input = long.Parse(Console.ReadLine());
            string hex = input.ToString("X");

            Console.WriteLine(hex);

        }
    }
}
