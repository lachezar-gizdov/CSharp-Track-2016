using System;
class Program
{
    static void Main()
    {
        int? a = null;
        double? b = null;

        Console.WriteLine(a);
        Console.WriteLine(b);

        Console.WriteLine(a + 5);
        Console.WriteLine(b + null);
    }
}