using System;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        bool isPrime = true;

        if (input < 2)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i <= (int)Math.Sqrt(input); i++)
            {
                if (input % i == 0)
                {
                    isPrime = false;
                }
            }
        }

        if (isPrime)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}