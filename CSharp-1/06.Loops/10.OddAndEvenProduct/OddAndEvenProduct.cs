using System;
using System.Numerics;

class OddAndEvenProduct
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string[] nums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        BigInteger oddSum = 1;
        BigInteger evenSum = 1;

        for (int i = 0; i < n; i += 2)
        {
            oddSum *= int.Parse(nums[i]);
        }

        for (int i = 1; i < n; i += 2)
        {
            evenSum *= int.Parse(nums[i]);
        }

        if (oddSum == evenSum)
        {
            Console.WriteLine("yes {0}", oddSum);
        }
        else
        {
            Console.WriteLine("no {0} {1}", oddSum, evenSum);
        }
    }
}