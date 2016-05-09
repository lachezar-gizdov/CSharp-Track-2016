using System;

class MaximumSum2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];
        int totalMax = nums[0];
        int currentMax = nums[0];

        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 1; i < n; i++)
        {
            currentMax = Math.Max(nums[i], nums[i] + currentMax);
            totalMax = Math.Max(totalMax, currentMax);
        }

        Console.WriteLine(totalMax);
    }
}