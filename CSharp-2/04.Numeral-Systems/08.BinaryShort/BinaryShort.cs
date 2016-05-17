using System;

static class BinaryShort
{
    static void Main()
    {
        long dec = long.Parse(Console.ReadLine());
        string bin = String.Empty;
        
        DecToBin(dec, bin);
    }


    static void DecToBin(long dec, string bin)
    {
        string binary = Convert.ToString(dec, 2);
        binary = binary.PadLeft(16, '0');
        Console.WriteLine(binary);
    }
}
