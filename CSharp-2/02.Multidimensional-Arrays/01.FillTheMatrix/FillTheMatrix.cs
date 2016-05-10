using System;

class FillTheMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char symbol = char.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];

        if (symbol == 'a')
        {
            CaseA(matrix, n);
        }
        else if (symbol == 'b')
        {
            CaseB(matrix, n);
        }

        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                Console.Write(matrix[col, row]);
                if (row != n - 1)
                {
                    Console.Write(' ');
                }
            }
            Console.WriteLine();
        }
    }

    static void CaseA(int[,] matrix, int n)
    {
        int count = 1;

        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                matrix[row, col] = count;
                count++;
            }
        }
    }


    static void CaseB(int[,] matrix, int n)
    {
        int count = 1;

        for (int col = 0; col < n; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[row, col] = count;
                    count++;
                }
            }
            else
            {
                for (int row = n - 1; row >= 0; row--)
                {
                    matrix[row, col] = count;
                    count++;
                }
            }

        }
    }

    static void CaseC(int[,] matrix, int n)
    {
        int count = 1;

        for (int col = 0; col < n; col++)
        {

        }
    }
}