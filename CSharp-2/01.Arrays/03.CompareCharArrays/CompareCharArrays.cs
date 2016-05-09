using System;

class CompareCharArrays
{
    static void Main()
    {
        //input
        string firstStr = Console.ReadLine();
        string secondStr = Console.ReadLine();
        bool isEqual = true;

        //logic & output
        if (firstStr.Length < secondStr.Length)
        {
            Console.WriteLine('<');
        }
        else if (firstStr.Length > secondStr.Length)
        {
            Console.WriteLine('>');
        }
        else
        {
            for (int i = 0; i < firstStr.Length; i++)
            {
                if (firstStr[i] > secondStr[i])
                {
                    Console.WriteLine(">");
                    isEqual = false;
                    break;
                }
                else if (firstStr[i] < secondStr[i])
                {
                    Console.WriteLine("<");
                    isEqual = false;
                    break;
                }
                else if (firstStr[i] > secondStr[i])
                {
                    Console.WriteLine('>');
                    break;
                }
            }
            if (isEqual)
            {
                Console.WriteLine('=');
            }
        }
    }
}