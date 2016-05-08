using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MaximumKSum
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); // 4
        int k = int.Parse(Console.ReadLine()); // 2
        int sum = 0;

        int[] nums = new int[n];

        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(nums);

        for (int j = n - 1; j >= n - k; j--)
        {
            sum += nums[j];
        }
        Console.WriteLine(sum);
    }
}