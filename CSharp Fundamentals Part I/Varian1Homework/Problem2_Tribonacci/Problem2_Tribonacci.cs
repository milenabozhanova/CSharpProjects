using System;
using System.Numerics;

class Problem2_Tribonacci
{
    static void Main()
    {
        BigInteger smallest = int.Parse(Console.ReadLine());
        BigInteger middle = int.Parse(Console.ReadLine());
        BigInteger biggest = int.Parse(Console.ReadLine());

        int n = int.Parse(Console.ReadLine());

        if (n >= 4)
        {
            for (int i = 4; i <= n; i++)
            {
                BigInteger next = smallest + middle + biggest;
                smallest = middle;
                middle = biggest;
                biggest = next;
            }
            Console.WriteLine(biggest);
        }
        else
        {
            if (n == 1) Console.WriteLine(smallest);
            if (n == 2) Console.WriteLine(middle);
            if (n == 3) Console.WriteLine(biggest);
        }
    }
}

