using System;

class JustMatrixD
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];
        int numberInSpiral = 1;

        int maxRowIndex = n - 1;
        int maxColIndex = n - 1;
        int minRowIndex = 0;
        int minColIndex = 1;
        int currentMaxColIndex = maxColIndex;
        int currentMaxRowIndex = maxRowIndex;
        int currentMinColIndex = minColIndex;
        int currentMinRowIndex = minRowIndex;

        //first row
        for (int i = 0; i < n; i++)
        {
            matrix[i, 0] = numberInSpiral;
            numberInSpiral++;
        }

        for (int counter = 1; counter <= n - 1; counter++)
        {

            //right and up
            if (counter % 2 != 0)
            {
                for (int j = 1; j <= 2 * (n - counter); j++)
                {
                    //right
                    if (j <= (n - counter))
                    {
                        //minRowIndex + j), maxColIndex
                        matrix[maxRowIndex, currentMinColIndex] = numberInSpiral;
                        numberInSpiral++;
                        currentMinColIndex++;
                    }
                    //up
                    else
                    {
                        matrix[--currentMaxRowIndex, maxColIndex] = numberInSpiral;
                        numberInSpiral++;
                    }
                }
                maxColIndex--;
                maxRowIndex--;
                currentMaxRowIndex = maxRowIndex;
                currentMaxColIndex = maxColIndex;
                currentMinRowIndex = minRowIndex;
                currentMinRowIndex = minRowIndex;

            }
            //uleft and right
            else
            {
                for (int i = 1; i <= 2 * (n - counter); i++)
                {

                    //left
                    if (i <= (n - counter))
                    {
                        matrix[minRowIndex, currentMaxColIndex] = numberInSpiral;
                        numberInSpiral++;
                        currentMaxColIndex--;
                    }
                    //down
                    else
                    {
                        matrix[++currentMinRowIndex, minColIndex] = numberInSpiral;
                        numberInSpiral++;
                    }                         
                }
                minRowIndex++;
                minColIndex++;
                currentMaxRowIndex = maxRowIndex;
                currentMaxColIndex = maxColIndex;
                currentMinRowIndex = minRowIndex;
                currentMinColIndex = minColIndex;
            }
        }

        //print matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,3} ", matrix[row, col]);
            }
            Console.WriteLine();
        }

    }
}

