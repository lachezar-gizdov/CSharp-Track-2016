using System;

class MMSA
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

        //input
        int n = int.Parse(Console.ReadLine());
        double minNumber = int.MaxValue;
        double maxNumber = int.MinValue;
        double number = 0;
        double sum = 0;
        double avarage = sum / n;

        //logic
        for (int i = 0; i < n; i++)
        {
            number = double.Parse(Console.ReadLine());

            if (number < minNumber)
            {
                minNumber = number;
            }

            if (number > maxNumber)
            {
                maxNumber = number;
            }

            sum += number;
        }

        //output
        Console.WriteLine("min={0:F2}", minNumber);
        Console.WriteLine("max={0:F2}", maxNumber);
        Console.WriteLine("sum={0:F2}", sum);
        Console.WriteLine("avg={0:F2}", avarage);

    }
}