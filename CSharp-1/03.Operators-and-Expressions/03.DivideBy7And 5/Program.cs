using System;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        if (input % 35 == 0)
        {
            Console.WriteLine("true " + input);
        }
        else
        {
            Console.WriteLine("false " + input);
        }
    }
}