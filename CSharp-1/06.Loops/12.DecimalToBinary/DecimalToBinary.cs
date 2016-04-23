using System;

class DecimalToBinary
{
    static void Main()
    {
        //input
        long dec = long.Parse(Console.ReadLine());
        string bin = "";

        //logic & output
        if (dec == 0)
        {
            Console.WriteLine(0);
        }

        else
        {
            while (dec > 0)
            {
                int remainder = (int)dec % 2;
                bin = remainder + bin;
                dec /= 2;
            }

            Console.WriteLine(bin);
        }
    }
}