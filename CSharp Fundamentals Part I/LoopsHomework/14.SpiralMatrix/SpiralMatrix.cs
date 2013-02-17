using System;


class SpiralMatrix
{
    static void Main()
    {
        Console.WriteLine("Please enter one positive integer so that 0 < n < 20");
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];
        int numberInSpiral = 1;
  
        int maxRowIndex = n-1;
        int maxColIndex = n-1;
        int minRowIndex = 0;
        int minColIndex = 0;
        int currentMaxColIndex = maxColIndex;
        int currentMaxRowIndex = maxRowIndex;
        int currentMinColIndex = minColIndex;
        int currentMinRowIndex = minRowIndex;
            
        //first row
        for (int i = 0; i < n; i++)
        {
            matrix[0, i] = numberInSpiral;
            numberInSpiral++;
        }

        for (int counter = 1; counter <= n-1; counter++)
        {
 
            //down and left
            if (counter % 2 != 0)
            {
                for (int i = 1; i <= 2 * (n - counter); i++)
                {
                    //down
                    if (i <= (n - counter))
                    {
                        matrix[++currentMinRowIndex, maxColIndex] = numberInSpiral;
                        numberInSpiral++;
                    }
                    //left
                    else
                    {
                        matrix[maxRowIndex, --currentMaxColIndex] = numberInSpiral;
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
            //up and right
            else
            {
                for (int j = 1; j <= 2 * (n - counter); j++)
                {
                        
                    //up
                    if (j <= (n - counter))
                    {
                        matrix[currentMaxRowIndex, minColIndex] = numberInSpiral;
                        numberInSpiral++;
                        currentMaxRowIndex--;

                    }
                    //right
                    else
                    {
                        matrix[(currentMinRowIndex + 1), ++currentMinColIndex] = numberInSpiral;
                        numberInSpiral++;
                    }
                }
                minRowIndex++;
                minColIndex++;
                currentMaxRowIndex = maxRowIndex;
                currentMaxColIndex = maxColIndex;
                currentMinRowIndex = minRowIndex;
                currentMinColIndex = minRowIndex;

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

