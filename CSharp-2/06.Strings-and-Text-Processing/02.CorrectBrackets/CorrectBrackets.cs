using System;

class CorrectBrackets
{
    static void Main()
    {
        //input
        string input = Console.ReadLine();
        char[] arr = input.ToCharArray();
        int sum1 = 0;
        int sum2 = 0;

        //logic
        foreach (char symbol in arr)
        {
            if (symbol == '(')
            {
                sum1++;
            }
            if (symbol == ')')
            {
                sum2++;
            }
        }

        //output
        if (sum1 == sum2)
        {
            Console.WriteLine("Correct");
        }
        else
        {
            Console.WriteLine("Incorrect");
        }
    }
}