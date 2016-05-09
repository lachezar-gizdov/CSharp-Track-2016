using System;

class BinarySearch
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];

        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }
        int x = int.Parse(Console.ReadLine());

        int index = Array.BinarySearch(nums, x);

        if (index > 0)
        {
            Console.WriteLine(index);
        }
        else
        {
            Console.WriteLine(-1);
        }
    }
}