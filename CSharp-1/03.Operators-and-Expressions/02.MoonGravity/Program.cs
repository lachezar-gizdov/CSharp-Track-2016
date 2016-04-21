using System;
class Program
{
    static void Main()
    {
        double moonGrav = 0.17;
        double userInput = double.Parse(Console.ReadLine());
        double result = moonGrav * userInput;
        Console.WriteLine(String.Format("{0:0.000}", result));
    }
}