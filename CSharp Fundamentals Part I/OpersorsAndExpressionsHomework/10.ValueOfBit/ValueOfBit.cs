using System;

class ValueOfBit
{
    static void Main()
    {
        Console.Write("Please enter a number v= ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Please enter a position p= ");
        int p = int.Parse(Console.ReadLine());

        int mask = 1 << p;
        int nAndMask = number & mask;
        int bit = nAndMask >> p;

        if (bit == 1)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}

