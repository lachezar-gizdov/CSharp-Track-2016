using System;

namespace BinaryToHexadecimal
{
    class BinaryToHexadecimal
    {
        static void Main()
        {
            string strBinary = Console.ReadLine();
            string hex = Convert.ToInt64(strBinary, 2).ToString("X");

            Console.WriteLine(hex);
        }
    }
}
