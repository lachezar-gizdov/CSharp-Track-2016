using System;

namespace SayHello
{
    class SayHello
    {
        static void Main()
        {
            string name = Console.ReadLine();
            Name(name);
        }

        static void Name(string name)
        {
            Console.WriteLine("Hello, {0}! ", name);
        }
    }
}
