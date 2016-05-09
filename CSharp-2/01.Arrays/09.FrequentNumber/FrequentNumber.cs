using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaximalSequence
{
    static void Main()
    {
        //input
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];
        int count = 1;
        int maxcount = 0;

        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        //logic
        Array.Sort(nums);

        for (int i = 1; i < n; i++)
        {
            if (nums[i] == nums[i - 1])
            {
                count++;
                maxcount = Math.Max(count, maxcount);
            }
            else
            {
                count = 1;
            }
        }

        int count1 = 1;
        int currentIndex = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[currentIndex])
                count1++;
            else
                count1--;
            if (count1 == 0)
            {
                currentIndex = i;
                count1 = 1;
            }
        }

        int mostFreq = nums[currentIndex];

        //output
        Console.WriteLine("{0} ({1} times)", mostFreq, maxcount);
    }
}