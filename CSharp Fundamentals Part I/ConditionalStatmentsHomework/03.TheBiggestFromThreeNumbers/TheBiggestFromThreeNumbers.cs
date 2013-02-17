using System;

class TheBiggestFromThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter three real numbers");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (a > b)
        {
            if (b > c)
                Console.WriteLine("{0} is the biggest number", a);
        }
        else if (a < b)
        {
            if (b > c)
                Console.WriteLine("{0} is the biggest number", b);
            else if (b < c)
                Console.WriteLine("{0} is the biggest number", c);
        }
    }
}

