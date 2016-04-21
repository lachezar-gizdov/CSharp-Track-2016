using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        //input

        uint n = uint.Parse(Console.ReadLine());

        //logic & output

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}