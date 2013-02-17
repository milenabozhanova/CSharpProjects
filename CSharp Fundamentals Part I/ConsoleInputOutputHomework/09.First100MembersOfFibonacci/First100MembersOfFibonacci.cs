using System;
using System.Numerics;

class First100MembersOfFibonacci
{
    static void Main()
    {
        BigInteger a = 0;
        BigInteger b = 1;
        Console.Write("{0}, {1}", a, b);

        for (int i = 0; i <= 98; i++)
        {
            BigInteger c = a + b;
            Console.Write(", {0}", c);
            a = b;
            b = c;
        }

    }
}

