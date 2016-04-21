using System;

class Program
{
    static void Main()
    {
        uint input = uint.Parse(Console.ReadLine());
        uint thirdBit = input >> 3;
        uint result = thirdBit & 1;

        Console.WriteLine(result);
    }
}