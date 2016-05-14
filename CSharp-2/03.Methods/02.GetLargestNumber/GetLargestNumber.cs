using System;

namespace GetLargestNumber
{
    class GetLargestNumber
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] splitInput = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = Array.ConvertAll(splitInput, int.Parse);

            GetMax(numbers);
        }

        static void GetMax(int[] numbers)
        {
            int max = Math.Max(numbers[0], numbers[1]);
            max = Math.Max(max, numbers[2]);
            Console.WriteLine(max);
        }
    }
}
