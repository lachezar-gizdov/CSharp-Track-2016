using System;

class TriangleSurfaceByTwoSidesAndAnAngle
{
    static void Main()
    {
        //input
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double angle = double.Parse(Console.ReadLine());

        //logic
        double area = Convert.ToDouble((a * b * Math.Sin(angle * Math.PI / 180) / 2));

        //output
        Console.WriteLine("{0:F2}", area);
    }
}