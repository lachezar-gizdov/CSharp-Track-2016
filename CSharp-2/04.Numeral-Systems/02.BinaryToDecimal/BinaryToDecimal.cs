using System;
using System.Numerics;

namespace BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main()
        {

            char[] input = Console.ReadLine().ToCharArray();
            int arrLenght = input.Length;
            BigInteger dec = 0;

            BinToDec(input, arrLenght, dec);
        }

        static void BinToDec(char[] input, int arrLenght, BigInteger dec)
        {
            Array.Reverse(input);


            for (int i = arrLenght - 1; i >= 0; i--)
            {
                dec += (input[i] - '0') * (BigInteger.Pow(2, i));
            }

            Console.WriteLine(dec);
        }
    }
}