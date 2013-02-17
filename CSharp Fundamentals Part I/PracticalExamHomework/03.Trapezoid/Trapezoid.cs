using System;

class Trapezoid
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        //first row
        for (int i = 1; i <= n; i++)
        {
            Console.Write('.');
        }
        for (int i = 1; i <= n; i++)
        {
            Console.Write('*');
        }
        Console.WriteLine();

        //middle rows
        for (int row = 1; row < n; row++)
        {
            for (int col = 0; col < 2 * n; col++)
            {
                if (col < n - row)
                {
                    Console.Write(".");
                }
                else if (col == n - row)
                {
                    Console.Write("*");
                }
                else if (col > n - row)
                {
                    if (col == (2 * n) - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
            }
            Console.WriteLine();
        }

        //last row
        for (int i = 1; i <= 2 * n; i++)
        {
            Console.Write('*');
        }
        Console.WriteLine();
    }
}


