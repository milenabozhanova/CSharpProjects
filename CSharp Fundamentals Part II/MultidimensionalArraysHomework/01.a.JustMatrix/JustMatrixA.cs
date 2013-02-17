using System;
using System.Collections.Generic;

class JustMatrixA
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int cnt = 1;

        for (int col = 0; col <n; col++)
        {
            for (int row = 0; row < n; row++, cnt++)
            {
                matrix[row, col] = cnt;
            }

        }

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,3}", matrix[row, col]);
            }
            Console.WriteLine();
        }
            

    }
}

