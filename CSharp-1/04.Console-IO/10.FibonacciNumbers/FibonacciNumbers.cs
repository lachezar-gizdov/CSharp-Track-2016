using System;

class FibonacciNumbers
{
    static void Main()
    {
        //input

        byte n = byte.Parse(Console.ReadLine());
        ulong a = 0;
        ulong b = 1;
        ulong c = 0;

        if (n <= 1)
        {
            Console.WriteLine(0);
        }
        else
        {

            Console.Write("{0}, {1}", a, b);

            for (int i = 2; i < n; i++)
            {
                c = a + b;
                Console.Write(", {0}", c);
                a = b;
                b = c;
            }

        }
    }
}