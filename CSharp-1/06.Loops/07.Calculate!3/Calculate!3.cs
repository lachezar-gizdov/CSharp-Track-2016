using System;
using System.Numerics;

class Calculate3F
{
    static void Main()
    {
        //input
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        BigInteger factorialN = 1;
        BigInteger factorialK = 1;
        BigInteger factorialNK = 1;

        //logic
        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
        }

        for (int i = 1; i <= k; i++)
        {
            factorialK *= i;
        }

        for (int i = 1; i <= n - k; i++)
        {
            factorialNK *= i;
        }

        BigInteger result = factorialN / (factorialK * factorialNK);

        //output
        Console.WriteLine(result);
    }
}
