using System;

class RandomNumbers
{
    static void Main()
    {
        Random random = new Random();

        for (int i = 0; i < 10; i++)
        {
            int randomNumber = random.Next(100, 200);
            Console.WriteLine(randomNumber);
        }
    }
}
