using System;
class Program
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Before Exchange: a=" + a + " ; b=" + b);

        int c = a;
        a = b;
        b = c;
        Console.WriteLine("After Exchange: a=" + a + " ; b=" + b);
    }
}