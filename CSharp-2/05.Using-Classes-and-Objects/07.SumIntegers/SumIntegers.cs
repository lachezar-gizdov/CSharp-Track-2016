using System;

class SumIntegers
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] inputSplited = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        long[] inputTolong = Array.ConvertAll(inputSplited, long.Parse);
        long sum = 0;

        for (int i = 0; i < inputTolong.Length; i++)
        {
            sum += inputTolong[i];
        }
        Console.WriteLine(sum);
    }
}