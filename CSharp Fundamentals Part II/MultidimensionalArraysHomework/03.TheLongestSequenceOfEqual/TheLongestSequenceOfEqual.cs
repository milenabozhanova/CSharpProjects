using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TheLongestSequenceOfEqual
{
    static int CalculateHorizontal(int row, int col)
    {
        int sum = 1;
        for (int i = row; i < matrix.GetLength(0) - 1; i++)
        {
            if (matrix[i, col].Equals(matrix[i + 1, col]))
            {
                sum += 1;
            }
            else
            {
                return sum;
            }
        }
        return sum;
    }

    static int CalculateVertical(int row, int col)
    {
        int sum = 1;
        for (int i = col; i < matrix.GetLength(1) - 1; i++)
        {
            if (matrix[row, i].Equals(matrix[row, i + 1]))
            {
                sum += 1;
            }
            else
            {
                return sum;
            }
        }
        return sum;
    }

    static int CalculateLeftVertical(int row, int col)
    {
        int sum = 1;
        int min = Math.Min(matrix.GetLength(0), matrix.GetLength(1));
        for (int i = row, j = col; i < min - 1 && j < min - 1; i++, j++)
        {
            if (matrix[i, j].Equals(matrix[i + 1, j + 1]))
            {
                sum += 1;
            }
            else
            {
                return sum;
            }
        }
        return sum;
    }

    static int CalculateRightVertical(int row, int col)
    {
        int sum = 1;
        for (int i = row, j = col; i<matrix.GetLength(0)-1 && j > 0; i++, j--)
        {
            if (matrix[i, j].Equals(matrix[i + 1, j - 1]))
            {
                sum += 1;
            }
            else
            {
                return sum;
            }
        }
        return sum;
    }

    //static string[,] matrix = 
    //{
    //        { "ha", "fifi", "ho", "hi"},
    //        { "fo", "ha", "ba", "xx"},
    //        { "xxx", "ho", "ha", "xx"}
    // };

    //static string[,] matrix = 
    //{
    //        { "do", "re", "mi", "fa"},
    //        { "sol", "sol", "fa", "re"},
    //        { "la", "fa", "do", "si"}
    // };

    static string[,] matrix = 
    {
            { "do", "do", "do", "do"},
            { "do", "sol", "fas", "re"},
            { "do", "fa", "do", "si"}
     };

    static void Main()
    {
       

        int currentS = 0;
        int maxS = int.MinValue;
        string element = "";

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i < matrix.GetLength(0) - 1 && j < matrix.GetLength(1) - 1)
                {
                    currentS = CalculateHorizontal(i, j);
                    if (currentS > maxS)
                    {
                        maxS = currentS;
                        element = matrix[i,j];

                    }
 
                    currentS= CalculateLeftVertical(i, j);
                    if (currentS > maxS)
                    {
                        maxS = currentS;
                        element = matrix[i, j];
                    }
                }
                if (j < matrix.GetLength(1) - 1)
                {
                    currentS = CalculateVertical(i, j);
                      if (currentS > maxS)
                        {
                            maxS = currentS;
                            element = matrix[i, j];
                        }
                }
                if (i < matrix.GetLength(0)-1 && j >0 )
                {
                    currentS = CalculateRightVertical(i, j);
                    if (currentS > maxS)
                    {
                        maxS = currentS;
                        element = matrix[i, j];
                    }
                }
            }
        }

        Console.WriteLine("The maximal sequence of equal elements consist of {0} x \"{1}\"", maxS, element);

    }
}


