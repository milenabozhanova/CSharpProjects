using System;


class NumbersDevidedOfFive
{
    static void Main()
    
    {
        Console.WriteLine("Please enter two positive numbers");
        Console.Write("a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("b: ");
        int b = int.Parse(Console.ReadLine());

        int p = 0;

        if (a > 0 && b > a)
        {
            for (int num = a; num <= b; num++)
            {
                if ((num % 5) == 0)
                {
                    p ++;
                }
                else
                    continue;
            }
            Console.WriteLine("The numbers between a and b, which can be devided of five are: {0}", p);
        }
        else
        {
            Console.WriteLine("Invalid range!");
        }
    }
}

