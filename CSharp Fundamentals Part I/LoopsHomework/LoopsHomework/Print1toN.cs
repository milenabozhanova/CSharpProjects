using System;

class Print1toN
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if (i == n)
            {
                Console.Write("{0} ", i);
            }
            else
            {
                Console.Write("{0}, ", i);
            }
        }
    }
}

