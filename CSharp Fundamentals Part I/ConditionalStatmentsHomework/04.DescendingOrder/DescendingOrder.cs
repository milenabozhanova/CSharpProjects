using System;

class DescendingOrder
{
    static void Main()
    {
        Console.WriteLine("Please enter three integers");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (a > b && a > c)
        {
            if (b > c)
            {
                Console.WriteLine("{0}, {1}, {2}", a, b, c);
            }
            else if (c > b)
            {
                Console.WriteLine("{0}, {1}, {2}", a, c, b);
            }
        }
        else if (b > a && b > c)
        {
            if (a > c)
            {
                Console.WriteLine("{0}, {1}, {2}", b, a, c);
            }
            else if (c > a)
            {
                Console.WriteLine("{0}, {1}, {2}", b, c, a);
            }
        }
        else if (c > a && c > b)
        {
            if (b > a)
            {
                Console.WriteLine("{0}, {1}, {2}", c, b, a);
            }
            else if (a > b)
            {
                Console.WriteLine("{0}, {1}, {2}", c, a, b);
            }
        }
    }
}

