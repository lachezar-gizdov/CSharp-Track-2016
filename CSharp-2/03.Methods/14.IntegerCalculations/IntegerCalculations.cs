using System;

namespace IntegerCalculations
{
    class IntegerCalculations
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] inputSplited = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] inputToInt = Array.ConvertAll(inputSplited, int.Parse);
            int min = 0;
            int max = 0;
            double avg = 0;
            int sum = 0;
            int product = 1;

            Minimum(inputToInt, min);
            Maximum(inputToInt, max);
            Average(inputToInt, avg);
            Sum(inputToInt, sum);
            Product(inputToInt, product);
        }

        static void Minimum(int[] inputToInt, int min)
        {
            min = inputToInt[0];
            for (int i = 1; i < inputToInt.Length; i++)
            {
                
                min = Math.Min(min, inputToInt[i]);
            }
            Console.WriteLine(min);
        }

        static void Maximum(int[] inputToInt, int max)
        {
            max = inputToInt[0];
            for (int i = 1; i < inputToInt.Length; i++)
            {

                max = Math.Max(max, inputToInt[i]);
            }
            Console.WriteLine(max);
        }

        static void Average(int[] inputToInt, double avg)
        {
            for (int i = 0; i < inputToInt.Length; i++)
            {

                avg += inputToInt[i]; 
            }
            avg /= 5;

            Console.WriteLine("{0:F2}", avg);
        }

        static void Sum(int[] inputToInt, int sum)
        {
            for (int i = 0; i < inputToInt.Length; i++)
            {

                sum += inputToInt[i];
            }

            Console.WriteLine(sum);
        }

        static void Product(int[] inputToInt, int product)
        {
            for (int i = 0; i < inputToInt.Length; i++)
            {

                product *= inputToInt[i];
            }

            Console.WriteLine(product);
        }
    }
}
