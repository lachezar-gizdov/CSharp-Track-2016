using System;

class SumOf5Numbers
{
    static void Main()
    {
        //input

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());

        //logic

        int sum = a + b + c + d + e;

        //output

        Console.WriteLine(sum);
    }
}