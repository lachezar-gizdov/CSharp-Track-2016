using System;

namespace longegerCalculations
{
    class longegerCalculations
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] inputSplited = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            long[] inputTolong = Array.ConvertAll(inputSplited, long.Parse);
            long min = 0;
            long max = 0;
            double avg = 0;
            long sum = 0;
            long product = 1;

            Minimum(inputTolong, min);
            Maximum(inputTolong, max);
            Average(inputTolong, avg);
            Sum(inputTolong, sum);
            Product(inputTolong, product);
        }

        static void Minimum(long[] inputTolong, long min)
        {
            min = inputTolong[0];
            for (long i = 1; i < inputTolong.Length; i++)
            {
                
                min = Math.Min(min, inputTolong[i]);
            }
            Console.WriteLine(min);
        }

        static void Maximum(long[] inputTolong, long max)
        {
            max = inputTolong[0];
            for (long i = 1; i < inputTolong.Length; i++)
            {

                max = Math.Max(max, inputTolong[i]);
            }
            Console.WriteLine(max);
        }

        static void Average(long[] inputTolong, double avg)
        {
            for (long i = 0; i < inputTolong.Length; i++)
            {

                avg += inputTolong[i]; 
            }
            avg /= 5;

            Console.WriteLine("{0:F2}", avg);
        }

        static void Sum(long[] inputTolong, long sum)
        {
            for (long i = 0; i < inputTolong.Length; i++)
            {

                sum += inputTolong[i];
            }

            Console.WriteLine(sum);
        }

        static void Product(long[] inputTolong, long product)
        {
            for (long i = 0; i < inputTolong.Length; i++)
            {

                product *= inputTolong[i];
            }

            Console.WriteLine(product);
        }
    }
}
