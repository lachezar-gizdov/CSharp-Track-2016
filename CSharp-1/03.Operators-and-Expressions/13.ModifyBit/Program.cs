using System;

class Program
{
    static void Main()
    {
        ulong n = ulong.Parse(Console.ReadLine());
        byte p = byte.Parse(Console.ReadLine());
        byte v = byte.Parse(Console.ReadLine());

        if (v == 1)
        {
            ulong setOne = (ulong)1 << p;
            ulong foundBitOne = n | setOne;
            Console.WriteLine(foundBitOne);
        }
        else
        {
            ulong setZero = (ulong)~(1 << p);
            ulong foundBitZero = n & setZero;
            Console.WriteLine(foundBitZero);
        }
    }
}