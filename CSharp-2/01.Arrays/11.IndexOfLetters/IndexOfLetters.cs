using System;
using System.Linq;

class IndexOfLetters
{
    static void Main()
    {
        char[] alphabet = Enumerable.Range('a', 26).Select(x => (char)x).ToArray();

        string word = Console.ReadLine();
        char[] arr = word.ToCharArray();

        foreach (var item in arr)
        {
            for (int i = 0; i < 26; i++)
            {
                if (item == alphabet[i])
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}