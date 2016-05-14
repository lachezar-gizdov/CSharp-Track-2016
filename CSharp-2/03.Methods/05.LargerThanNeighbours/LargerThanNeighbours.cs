using System;

namespace LargerThanNeighbours
{
    class LargerThanNeighbours
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string[] splitInput = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] nums = Array.ConvertAll(splitInput, int.Parse);
            int count = 0;

            Larger(n, nums, count);
        }

        static void Larger(int n, int[] nums, int count)
        {
            for (int i = 1; i < n - 1; i++)
            {
                if (nums[i] > nums[i-1] && nums[i] > nums[i+1])
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
