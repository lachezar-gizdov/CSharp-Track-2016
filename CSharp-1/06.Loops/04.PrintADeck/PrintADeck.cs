using System;

class PrintADeck
{
    static void Main()
    {

        //input
        char ch = char.Parse(Console.ReadLine());
        int num = ch - '0';
        char j = 'J';
        char q = 'Q';
        char k = 'K';
        char a = 'A';

        //logic & output
        if (num >= 2 && num <= 10)
        {
            for (int i = 2; i <= num; i++)
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
            }
        }
        else if (ch == 'j' || ch == 'J')
        {
            for (int i = 2; i <= 10; i++)
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
            }

            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", j);
        }
        else if (ch == 'q' || ch == 'Q')
        {
            for (int i = 2; i <= 10; i++)
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
            }

            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", j);
            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", q);
        }

        else if (ch == 'k' || ch == 'K')
        {
            for (int i = 2; i <= 10; i++)
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
            }

            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", j);
            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", q);
            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", k);
        }

        else if (ch == 'a' || ch == 'A')
        {
            for (int i = 2; i <= 10; i++)
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
            }

            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", j);
            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", q);
            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", k);
            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", a);
        }
    }
}