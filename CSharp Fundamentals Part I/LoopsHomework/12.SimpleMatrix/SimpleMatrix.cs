using System;

class SimpleMatrix
{
    static void Main()
    {
        Console.WriteLine("Please enter one positive integer n < 20");
        Console.Write("n = ");
        double n = int.Parse(Console.ReadLine());

        if (n > 0 && n < 20)
        {
            for (int row = 1; row <= n; row++)
            {
                for (int cow = row; cow < row + n; cow++)
                {
                    Console.Write("{0} ", cow);
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid number");
        }
    }
}

