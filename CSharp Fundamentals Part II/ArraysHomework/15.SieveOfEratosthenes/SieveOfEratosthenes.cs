using System;
using System.Collections.Generic;

class SieveOfEratosthenes
{
    static void Main()
    {
        bool[] numbers = new bool[10000000];

        // Sieve of Eratosthenes
        for (int i = 2; i < Math.Sqrt(numbers.Length); i++)
        {
            if (numbers[i] == false)
            {
                for (int j = i * i; j < numbers.Length; j = j + i)
                {
                    numbers[j] = true;
                }
            }
        }

        //print the result (only the "false" numbers)
        for (int i = 2; i < numbers.Length; i++)
        {
            if (numbers[i] == false)
            {
                Console.Write("{0} ", i);
            }
        }
        Console.WriteLine();
    }
}
