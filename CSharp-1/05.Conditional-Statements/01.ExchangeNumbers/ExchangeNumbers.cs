using System;

class ExchangeNumbers
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

        //input

        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = 0;

        //logic & output

        if (a > b)
        {
            c = a;
            a = b;
            b = c;
            Console.WriteLine("{0} {1}", a , b);
        }
        else
        {
            Console.WriteLine("{0} {1}", a, b);
        }
    }
}