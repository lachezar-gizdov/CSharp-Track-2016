using System;

namespace SortingArray
{
    class SortingArray
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string[] splitInput = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] nums = Array.ConvertAll(splitInput, int.Parse);
            int maxNum = 0;

            SortedArray(nums);
        }

        static void IndexOfMaxNumber(int[] nums, int n, int maxNum)
        {
            for (int i = 1; i < n; i++)
            {
                if (nums[i - 1] > nums[i])
                {
                    maxNum = i - 1;
                }
                else
                {
                    maxNum = i;
                }
            }
        }

        static void SortedArray(int[] nums)
        {
            Array.Sort(nums);

            foreach (var item in nums)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
