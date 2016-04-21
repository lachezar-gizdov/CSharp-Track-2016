using System;

class Circle
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

        //input

        double r = double.Parse(Console.ReadLine());

        //logic

        double p = Math.PI;
        double area = p * (r * r);
        double perimeter = 2 * p * r;

        //output

        Console.WriteLine("{0:F2} {1:F2}", perimeter, area);
    }
}