using System;

class JustMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n,n];

        int cnt = 1;
        for (int i = 0; i < (n * 2 - 1); i++)
        {
            int col = 0;
            for (int row = n - 1 - i; row < n; row++, col++)
            {
                if (row >= 0 && col < n)
                {
                    matrix[row, col] = cnt++;
                }
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

