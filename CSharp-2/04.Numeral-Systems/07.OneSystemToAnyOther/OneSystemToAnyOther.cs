using System;
using System.Collections.Generic;
using System.Numerics;

namespace NumeralSystems4
{

    class OneSystemToAnyOther
    {
        static int firstNrBase = 0;
        static int secondNrBase = 0;
        static string firstNr = "";
        static string secondNr = "";
        static BigInteger firstNrInDec = 0;

        static Dictionary<char, BigInteger> HexInt = new Dictionary<char, BigInteger>
                        {
                            {'0', 0 },
                            {'1', 1 },
                            {'2', 2 },
                            {'3', 3 },
                            {'4', 4 },
                            {'5', 5 },
                            {'6', 6 },
                            {'7', 7 },
                            {'8', 8 },
                            {'9', 9 },
                            {'A', 10 },
                            {'B', 11 },
                            {'C', 12 },
                            {'D', 13 },
                            {'E', 14 },
                            {'F', 15 },
                        };

        static Dictionary<BigInteger, char> IntHex = new Dictionary<BigInteger, char>
                {
                    {0, '0' },
                    {1, '1' },
                    {2, '2' },
                    {3, '3' },
                    {4, '4' },
                    {5, '5' },
                    {6, '6' },
                    {7, '7' },
                    {8, '8' },
                    {9, '9' },
                    {10, 'A' },
                    {11, 'B' },
                    {12, 'C' },
                    {13, 'D' },
                    {14, 'E' },
                    {15, 'F' },
                };

        static void Main()
        {
            Input();
            ConvertOneToDec();
            ConvertDecToOther();
            Output(ref secondNr);
        }

        static void Input()
        {
            firstNrBase = int.Parse(Console.ReadLine());
            firstNr = Console.ReadLine();
            secondNrBase = int.Parse(Console.ReadLine());
        }

        static void ConvertOneToDec()
        {
            char[] firstNrArr = firstNr.ToCharArray();
            for (int i = 0; i < firstNr.Length; i++)
            {
                firstNrInDec = HexInt[firstNrArr[i]] + firstNrInDec * firstNrBase;
            }
        }

        static void ConvertDecToOther()
        {
            do
            {
                BigInteger remainder = firstNrInDec % secondNrBase;
                secondNr = IntHex[remainder] + secondNr;
                firstNrInDec /= secondNrBase;
            } while (firstNrInDec > 0);

        }

        static void Output(ref string number)
        {
            Console.WriteLine(number.TrimStart('0'));
        }
    }
}