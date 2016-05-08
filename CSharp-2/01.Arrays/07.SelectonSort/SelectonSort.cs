using System;

class MaximumKSum
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];

        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(nums);
        foreach (int number in nums)
        {
            Console.WriteLine(number);
        }
    }
}