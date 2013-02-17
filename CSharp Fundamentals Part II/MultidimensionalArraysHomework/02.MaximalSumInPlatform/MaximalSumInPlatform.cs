using System;

class MaximalSumInPlatform
{
    
    static int CalculateSum(int row, int col, int[,] matrix)
    {
        int sum = 0;
        for (int i = row; i < row+3; i++)
        {
            for (int j = col; j < col+3 ; j++)
            {
                sum += matrix[i,j];
            }
        }
        return sum;
    }
    
    static void Main()
    {
        //test
        //int n = 5;
        //int m = 4; 
        //int[,] matrix = 
        //{ { 1, 2, 3, 4},{5,6,7,8}, {8,9,10,10},
        //{9,9,9,9},{10,10,10,10} };
        
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, m];

        //input
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        
        //solution
        int sum = 0;
        int maxSum = int.MinValue;
        int startCol = 0;
        int startRow = 0;

        for (int r = 0; r <= n - 3; r++)
        {
            for (int c = 0; c <= m - 3; c++)
            {
                sum = CalculateSum(r, c, matrix);
                if(sum > maxSum)
                {
                    maxSum = sum;
                    startRow = r;
                    startCol = c;
                }
            }
        }

        //print the result
        Console.WriteLine("The maximal sum is: {0}", maxSum);

        for (int r = startRow; r < startRow+3; r++)
        {
            for (int c = startCol; c < startCol+3; c++)
            {
                Console.Write("{0,3} ", matrix[r, c]);
            }
            Console.WriteLine();
        }

    }
}

