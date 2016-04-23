using System;

class MatrixOfNumbers
{
    static void Main()
    {
        //input
        int n = int.Parse(Console.ReadLine());

        //logic & output
        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j < i + n; j++)
            {
                Console.Write("{0} ", j);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}