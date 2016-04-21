using System;

class BiggestOf5
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

        //input

        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());

        double ab = 0;
        double cd = 0;
        double max1 = 0;

        if (a > b || a == b)
        {
            ab = a;
        }
        else
        {
            ab = b;
        }
        if (c > d || c == d)
        {
            cd = c;
        }
        else
        {
            cd = d;
        }
        if (ab > cd || ab == cd)
        {
            max1 = ab;
        }
        else
        {
            max1 = cd;
        }
        if (max1 > e || max1 == e)
        {
            Console.WriteLine(max1);
        }
        else
        {
            Console.WriteLine(e);
        }
    }
}