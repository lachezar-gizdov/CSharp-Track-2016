using System;
using System.Linq;

class CompareArrays
{
    static void Main()
    {
        //input
        int n = int.Parse(Console.ReadLine());
        int[] arr1 = new int[n];
        int[] arr2 = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr1[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            arr2[i] = int.Parse(Console.ReadLine());
        }

        //output

        if (arr1.SequenceEqual(arr2))
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not equal");
        }
    }
}