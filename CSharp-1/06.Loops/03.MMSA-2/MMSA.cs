using System;
using System.Linq;

class MMSA
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

        //input
        int n = int.Parse(Console.ReadLine());
        var nums = new double[n];

        //logic
        for (int i = 0; i < n; i++)
        {
            nums[i] = double.Parse(Console.ReadLine());
        }

        //output
        Console.WriteLine("min={0:F2}", nums.Min());
        Console.WriteLine("max={0:F2}", nums.Max());
        Console.WriteLine("sum={0:F2}", nums.Sum());
        Console.WriteLine("avg={0:F2}", nums.Average());
    }
}