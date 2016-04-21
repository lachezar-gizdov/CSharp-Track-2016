using System;

class Program
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double area = width * height;
        double perimeter = 2 * (width + height);

        Console.Write(String.Format("{0:0.00}", area));
        Console.Write(" ");
        Console.WriteLine(String.Format("{0:0.00}", perimeter));
    }
}