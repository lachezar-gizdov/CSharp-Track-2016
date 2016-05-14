using System;

namespace ReverseNumber
{
    class ReverseNumber
    {
        static void Main()
        {
            string input = Console.ReadLine();

            ReverseNums(input);
        }

        static void ReverseNums(string input)
        {
            foreach (var symbol in input)
            {
                if (symbol == '.')
                {
                    string[] splitInput = input.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
                    char[] numbers = splitInput[0].ToCharArray();
                    Array.Reverse(numbers);

                    char[] numbers1 = splitInput[1].ToCharArray();
                    Array.Reverse(numbers1);

                    foreach (var item in numbers1)
                    {
                        Console.Write(item);
                    }
                    Console.Write(".");
                    foreach (var item1 in numbers)
                    {
                        Console.Write(item1);
                    }
                    Console.WriteLine();
                }
                else
                {
                    char[] numbers = input.ToCharArray();
                    Array.Reverse(numbers);

                    Console.WriteLine(numbers);
                    break;
                }
            }
        }
    }
}
