using System;

class MergeSort
{
    static void Main()
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