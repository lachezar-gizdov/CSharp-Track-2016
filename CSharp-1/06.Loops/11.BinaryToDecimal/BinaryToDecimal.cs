﻿using System;

class BinaryToDecimal
{
    static void Main()
    {
        string binary = Console.ReadLine();

        long l = Convert.ToInt64(binary, 2);

        Console.WriteLine(l);
    }
}