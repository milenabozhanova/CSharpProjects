using System;
class ThirdBitCheck
{
    static void Main()
    {
        Console.WriteLine("Please enter a number:");
        int number = int.Parse(Console.ReadLine());
        int mask = 1 << 4;
        int nAndMask = number & mask;
        int bit = nAndMask >> 4;

        if (bit == 1)
        {
            Console.WriteLine("The third bit of {0} is 1", number);
        }
        else
        {
            Console.WriteLine("The third bit of {0} is 0", number);
        }
    }
}

