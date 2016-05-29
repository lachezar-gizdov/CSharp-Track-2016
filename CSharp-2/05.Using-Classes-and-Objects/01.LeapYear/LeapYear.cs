using System;

class LeapYear
{
    static void Main()
    {
        //input
        int year = int.Parse(Console.ReadLine());
        string isLeap = string.Empty;

        ////logic
        if (DateTime.IsLeapYear(year))
        {
            isLeap = "Leap";
        }
        else
        {
            isLeap = "Common";
        }

        //output
        Console.WriteLine(isLeap);
    }
}