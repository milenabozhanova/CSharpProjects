using System;

class GCD
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());

        double r = a % b;

        do
        {
            a = b;
            b = r;
            r = a % b; 
        }
        while (r > 0);

        Console.WriteLine("GCD = {0}", b);
    }
}

