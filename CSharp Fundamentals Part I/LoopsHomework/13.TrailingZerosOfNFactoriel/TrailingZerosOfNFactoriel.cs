using System;

class TrailingZerosOfNFactoriel
{
    static void Main()
    {
        Console.WriteLine("Please enter one positive integer");
        Console.Write("n = ");
        uint n = uint.Parse(Console.ReadLine());

        if (n > 0)
        {
            uint zeros = 0;
            uint devider = 1;
            while ((n / devider) > 0)
            {
                devider *= 5;
                zeros += n / devider;
            }
            Console.WriteLine("The trailing zeros in {0}! are  {1}", n, zeros);
        }
        else
        {
            Console.WriteLine("Invalid number!");
        }
    }
}

