using System;

class Program
{
    static void Main()
    {
        uint input = uint.Parse(Console.ReadLine());
        uint num = input / 100;
        if (num % 10 == 7)
        {
            Console.WriteLine("true");
        }
        else
        {
            uint thirdNum = num % 10;
            Console.WriteLine("false " + thirdNum);
        }
    }
}