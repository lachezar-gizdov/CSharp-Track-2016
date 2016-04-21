using System;

class BiggestOf3
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

        //input

        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        // logic & output
        Console.WriteLine(Math.Max(a , Math.Max(b, c)));
    }
}