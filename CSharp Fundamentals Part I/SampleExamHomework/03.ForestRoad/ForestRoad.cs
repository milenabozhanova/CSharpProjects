using System;

class ForestRoad
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
 
        for (int row = 1; row <= 2 * n - 1; row++)
        {
            //the way to the right border
            if (row <= n)
            {
                for (int col = 1; col <= n; col++)
                {
                    if (col == row)
                    {
                        Console.Write("*");
                    }
                    else if (col != row)
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
            //the way to the Academy (down left)
            else
            {
                for (int col = n-1; col >= 0; col--)
                {
                    if (col == row-n)
                    {
                        Console.Write("*");
                    }
                    else if (col!= row-n)
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}