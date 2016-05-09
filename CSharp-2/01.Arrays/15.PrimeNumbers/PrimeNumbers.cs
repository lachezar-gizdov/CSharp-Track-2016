using System;
using System.Collections.Generic;
using System.Linq;

class PrimeNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var nums = Enumerable.Range(2, n - 1).ToList();

        for (int i = 0; i < nums.Count; i++)
        {
            if (nums[i] % 2 == 0)
            {
                nums.RemoveAt(i);
            }
        }
        for (int i = 0; i < nums.Count; i++)
        {
            if (nums[i] % 3 == 0)
            {
                nums.RemoveAt(i);

            }
        }

        for (int i = 0; i < nums.Count; i++)
        {
            if (nums[i] % 5 == 0)
            {
                nums.RemoveAt(i);

            }
        }

        for (int i = 0; i < nums.Count; i++)
        {
            if (nums[i] % 7 == 0)
            {
                nums.RemoveAt(i);

            }
        }

        for (int i = 0; i < nums.Count; i++)
        {
            if (nums[i] % 11 == 0)
            {
                nums.RemoveAt(i);

            }
        }
        int max = nums.Max();
        Console.WriteLine(max);
    }
}