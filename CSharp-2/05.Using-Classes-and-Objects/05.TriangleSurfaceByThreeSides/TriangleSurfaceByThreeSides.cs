using System;

class TriangleSurfaceByThreeSides
{
    static void Main()
    {
        //input
        double a = int.Parse(Console.ReadLine());
        double b = int.Parse(Console.ReadLine());
        double c = int.Parse(Console.ReadLine());

        //logic
        double s = (a + b + c) / 2;
        double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

        //output
        Console.WriteLine("{0:F2}", area);
    }
}