﻿using System;
class Program
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        object combined = hello + " " + world;
        string casted = (string)combined;

        Console.WriteLine(casted);
    }
}