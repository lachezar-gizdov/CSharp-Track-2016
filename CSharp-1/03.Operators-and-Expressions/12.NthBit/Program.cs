using System;

class Program
{
    static void Main()
    {
        int p = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        int nBit = p >> n;
        int result = nBit & 1;
        Console.WriteLine(result);
    }
}