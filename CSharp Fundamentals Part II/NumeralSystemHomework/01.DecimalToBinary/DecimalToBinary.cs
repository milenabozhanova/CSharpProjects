using System;
using System.Collections.Generic;

class DecimalToBinary
{
    static void Main()
    {
        int decimalN = int.Parse(Console.ReadLine());
        List<int> binaryN = new List <int>();

        while (decimalN > 0)
        {
            binaryN.Add(decimalN % 2);
            decimalN /= 2;
        }

        binaryN.Reverse();

        foreach (var bit in binaryN)
        {
            Console.Write(bit);
        }
    }
}

