using System;

class Program
{
    static void Main()
    {
        double sideA = double.Parse(Console.ReadLine());
        double sideB = double.Parse(Console.ReadLine());
        double sideH = double.Parse(Console.ReadLine());
        double area = ((sideA + sideB) / 2) * sideH;
        Console.WriteLine("{0:F7}", area);
    }
}