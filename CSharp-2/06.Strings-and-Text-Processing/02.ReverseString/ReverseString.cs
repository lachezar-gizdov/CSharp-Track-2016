using System;

class ReverseString
{
    static void Main()
    {
        //input
        string input = Console.ReadLine();

        //logic
        char[] arr = input.ToCharArray();
        Array.Reverse(arr);

        //output
        Console.WriteLine(arr);
    }
}