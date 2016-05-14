using System;
using System.Numerics;

namespace NFactorial_2
{
    class NFactorial_2
    {
        static void Main()
        {
            //No Checks for negative numbers

            int n = int.Parse(Console.ReadLine());
            BigInteger sum = 1;

            CalculateFactorial(n, sum);
        }

        static void CalculateFactorial(int n, BigInteger sum)
        {
            for (int i = 1; i <= n; i++)
            {
                sum *= i;
            }

            Console.WriteLine(sum);
        }
    }
}