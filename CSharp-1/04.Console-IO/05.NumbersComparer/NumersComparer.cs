using System;

class NumbersComparer
{
    static void Main()
    {

        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

        //input

        double firstNum = double.Parse(Console.ReadLine());
        double secondNum = double.Parse(Console.ReadLine());

        //logic & output

        if (firstNum > secondNum)
        {
            Console.WriteLine(firstNum);
        }
        else if (firstNum < secondNum)
        {
            Console.WriteLine(secondNum);
        }
        else
        {
            Console.WriteLine(firstNum);
        }
    }
}