using System;

class SumOfNNumbers
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

        //input

        int n = int.Parse(Console.ReadLine());
        double sum = 0;

        //logic

        for (int i = 1; i <= n; i++)
        {
            double num = double.Parse(Console.ReadLine());
            sum += num;
        }

        //output

        Console.WriteLine(sum);
    }
}