using System;

class SubStringInText
{
    static void Main()
    {
        string pattern = Console.ReadLine();
        string text = Console.ReadLine();
        int count = 0;
        int index = 0;

        while (index < text.Length)
        {
            int found = text.IndexOf(pattern, index);
            if (found < 0)
            {
                break;
            }
            count++;
            index = found + 1;
        }

        Console.WriteLine(count);
    }
}