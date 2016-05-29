using System;

class TriangleSurfaceBySideAndAltitude
{
    static void Main()
    {
        //input
        double side = double.Parse(Console.ReadLine());
        double altitude = double.Parse(Console.ReadLine());

        //logic
        double area = (side * altitude) / 2;

        //output
        Console.WriteLine("{0:F2}", area);
    }
}