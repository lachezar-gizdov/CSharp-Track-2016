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
            int index = 0;

            FirstLarger(n, nums, index);
        }

        static void FirstLarger(int n, int[] nums, int index)
        {
            for (int i = 1; i < n - 1; i++)
            {
                if (nums[i] > nums[i - 1] && nums[i] > nums[i + 1])
                {
                    index = i;
                    break;
                }
            }
            Console.WriteLine(index);
        }
    }
}
