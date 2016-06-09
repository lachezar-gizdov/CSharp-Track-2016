namespace SumIntegers
{
    using System;

    class SumIntegers
    {
        static void Main()
        {
            long[] input = ReadInput();

            long result = SumOfNumbers(input);

            Console.WriteLine(result);
        }

        static long[] ReadInput()
        {
            string input = Console.ReadLine();
            string[] inputSplited = input.Split(' ');
            long[] numbers = Array.ConvertAll(inputSplited, long.Parse);

            return numbers;
        }

        static long SumOfNumbers(long[] numbers)
        {
            long sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}