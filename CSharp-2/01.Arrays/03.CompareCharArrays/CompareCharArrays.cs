using System;

class CompareCharArrays
{
    static void Main()
    {
        //input
        string firstStr = Console.ReadLine();
        char[] firstArr = firstStr.ToCharArray();
        int count = 0;

        string secondStr = Console.ReadLine();
        char[] secondArr = secondStr.ToCharArray();

        //logic & output
        if (firstArr.Length < secondStr.Length)
        {
            Console.WriteLine('<');
        }
        else if (firstArr.Length > secondStr.Length)
        {
            Console.WriteLine('>');
        }
        else
        {
            for (int i = 0; i < firstArr.Length; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    count++;
                }
                else if (firstArr[i] < secondArr[i])
                {
                    Console.WriteLine('<');
                    break;
                }
                else if (firstArr[i] > secondArr[i])
                {
                    Console.WriteLine('>');
                    break;
                }
            }
            if (count == firstArr.Length)
            {
                Console.WriteLine('=');
            }
        }
    }
}