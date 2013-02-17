using System;
using System.Numerics;

class FirstNMembersOfFibonacciSequence
{
    static void Main()
    {
        Console.Write("n = ");
        sbyte n = sbyte.Parse(Console.ReadLine());

        BigInteger first = 0;
        BigInteger secound = 1;
        BigInteger third = (first + secound);
        int members = 3;
        Console.Write(first + "," + secound + "," + third + ",");

        do
        {
           
            first = secound;
            secound = third;
            third = (first + secound);
            members += 1;
            Console.Write(third + ",");

        }
        while (members <= n);
    }
}

