using System;

class NotDivisibleBy3and7
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());


        for (int i = 1; i <= n; i++)
        {
            if (i % 3==0 && i % 7 ==0)
            {
                continue;
            }
            else
            {
                Console.WriteLine("{0} ", i);
            }
        }
    }
}

