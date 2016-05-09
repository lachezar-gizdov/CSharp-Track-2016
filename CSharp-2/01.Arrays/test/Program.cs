using System;

class Program
{

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var isPrime = new byte[n + 1];
        var result = 0;

        for (int i = 2; i <= n; i++)
        {
            if (isPrime[i] == 0)
            {
                result = i;

                for (int j = i * 2; j <= n; j += i)
                {
                    isPrime[j] = 1;
                }
            }
        }

        Console.WriteLine(result);
    }

}