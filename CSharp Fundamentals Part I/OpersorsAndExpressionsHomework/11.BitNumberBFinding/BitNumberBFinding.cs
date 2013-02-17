using System;

class BitNumberBFinding
{
    static void Main()
    {
        Console.Write("Please enter a number i= ");
        int i = int.Parse(Console.ReadLine());

        Console.Write("Please enter a number of bit  b= ");
        int b = int.Parse(Console.ReadLine());

        int mask = 1 << b;
        int iAndMask = i & mask;
        int bit = iAndMask >> b;

        Console.WriteLine("value= {0}", bit);
    }
}
