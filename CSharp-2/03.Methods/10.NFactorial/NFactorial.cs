using System;
using System.Numerics;

namespace NFactorial
{
    class NFactorial
    {
        static void Main()
        {
            //With checks for negative numbers

            int n = int.Parse(Console.ReadLine());
            BigInteger sum = 1;

            CalculateFactorial(n, sum);
        }

        static void CalculateFactorial(int n, BigInteger sum)
        {
            if (n > 0)
            {


                for (int i = 1; i <= n; i++)
                {
                    sum *= i;
                }

                Console.WriteLine(sum);
            }
            else
            {
                n = Math.Abs(n);
                if (n % 2 == 0)
                {
                    for (int i = 1; i <= n; i++)
                    {
                        sum *= i;
                    }

                    Console.WriteLine(sum);
                }
                else
                {

                    for (int i = 1; i <= n; i++)
                    {
                        sum *= i;
                    }
                    sum *= -1;
                    Console.WriteLine(sum);

                }
            }
        }
    }
}