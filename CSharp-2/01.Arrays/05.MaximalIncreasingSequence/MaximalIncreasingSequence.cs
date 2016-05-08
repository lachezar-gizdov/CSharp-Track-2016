using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaximalIncreasingSequence
{
    static void Main()
    {
        //input
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];
        int count = 1;
        int maxcount = 0;
        nums[0] = int.Parse(Console.ReadLine());

        //logic
        for (int i = 1; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
            if (nums[i] > nums[i - 1])
            {
                count++;
                maxcount = Math.Max(count, maxcount);
            }
            else
            {
                count = 1;
            }
        }

        //output
        Console.WriteLine(maxcount);
    }
}