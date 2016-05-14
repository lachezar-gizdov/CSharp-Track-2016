using System;

namespace NumberAsArray
{
    class NumberAsArray
    {
        static void Main()
        {
            //string input = Console.ReadLine();
            //string[] splitInput = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //int[] numbers = Array.ConvertAll(splitInput, int.Parse);

            string input1 = Console.ReadLine();
            string[] firstArr = input1.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numbers1 = Array.ConvertAll(firstArr, int.Parse);

            string input2 = Console.ReadLine();
            string[] secondArr = input2.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numbers2 = Array.ConvertAll(secondArr, int.Parse);

            int maxLenght = 0;

            if (numbers1.Length < numbers2.Length)
            {
                maxLenght = numbers1.Length;
            }
            else
            {
                maxLenght = numbers2.Length;
            }

            int[] arrSum = new int[maxLenght];

            for (int i = 0; i < maxLenght; i++)
            {
                arrSum[i] = numbers1[i] + numbers2[i];

                if (arrSum[i] >= 10 )
                {

                }
            }

            foreach (var item in arrSum)
            {
                Console.Write(item + " ");
            }
        }
    }
}
