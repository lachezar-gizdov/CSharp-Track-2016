using System;

namespace AddingPolynomals
{
    class AddingPolynomals
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string polynomialsOne = Console.ReadLine();
            string[] polyOneSplited = polynomialsOne.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] polyToIntOne = Array.ConvertAll(polyOneSplited, int.Parse);

            string polyTwoSplited = Console.ReadLine();
            string[] splitInput2 = polyTwoSplited.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] polyToIntTwo = Array.ConvertAll(splitInput2, int.Parse);

            int[] result = new int[n];
            for (int i = 0; i < n; i++)
            {
                result[i] = polyToIntOne[i] + polyToIntTwo[i];
            }

            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}