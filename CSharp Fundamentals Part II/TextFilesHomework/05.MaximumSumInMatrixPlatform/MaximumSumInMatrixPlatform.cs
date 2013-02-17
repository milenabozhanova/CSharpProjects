using System;
using System.Collections.Generic;
using System.IO;

class MaximumSumInMatrixPlatform
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\text1.txt");
        StreamWriter fileWriter = new StreamWriter(@"..\..\result.txt");

        int len = 0;
        int result = 0;
        using (reader)
        {
            string line = reader.ReadLine();
            len = int.Parse(line);
           

            int[,] matrix = new int[len, len];

            line = reader.ReadLine();
            int lineNumber = 0;
            while (line != null)
            {
                lineNumber++;
                string[] matrixNums = line.Split(' ');
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    matrix[lineNumber - 1, i] = int.Parse(matrixNums[i]);
                }

                line = reader.ReadLine();
            }

            result = FindMaxSumInPlatform(matrix);
        }

        using (fileWriter)
        {
            fileWriter.WriteLine(result);
        }
    }

    static int FindMaxSumInPlatform(int[,] matrix)
    {
        int sum = 0;
        int maxSum = int.MinValue;

        for (int r = 0; r <= matrix.GetLength(0) - 2; r++)
        {
            for (int c = 0; c <= matrix.GetLength(1) - 2; c++)
            {
                sum = CalculateSum(r, c, matrix);
                if (sum > maxSum)
                {
                    maxSum = sum;
                }
            }
        }
        return maxSum;
    }

    static int CalculateSum(int row, int col, int[,] matrix)
    {
        int sum = 0;
        for (int i = row; i < row + 2; i++)
        {
            for (int j = col; j < col + 2; j++)
            {
                sum += matrix[i, j];
            }
        }
        return sum;
    }
}
