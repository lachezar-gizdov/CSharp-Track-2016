using System;

class MaximumSum
{
    static void Main()
    {
        //input
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];

        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        int maxSum = int.MinValue;
        int currentSum = 0;
        int tempStart = 0;
        int end = n;
        int start = 0;

        //logic
        for (int j = 0; j != n; ++j)
        {
            currentSum += nums[j];
            end = j;

            if (currentSum > maxSum || (currentSum == maxSum && (end - start) < (j - tempStart)))
            {
                maxSum = currentSum;
                start = tempStart;
                end = j;
            }

            if (currentSum < 0)
            {
                currentSum = 0;
                tempStart = j + 1;
            }
        }

        //output
        Console.WriteLine(maxSum);
    }
}