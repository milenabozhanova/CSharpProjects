using System;

class SignOfProduct
{
    static void Main()
    {
        Console.WriteLine("Please enter three real numbers");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (a > 0 && b > 0 && c > 0)
        {
            Console.WriteLine("The product will be a positive number");
        }
        else if (a > 0 && b < 0 && c < 0)
        {
            Console.WriteLine("The product will be a positive number");
        }
        else if (a < 0 && b < 0 && c > 0)
        {
            Console.WriteLine("The product will be a positive number");
        }
        else if (a < 0 && b > 0 && c < 0)
        {
            Console.WriteLine("The product will be a positive number");
        }
        else if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("The product will be a 0");
        }
        else
        {
            Console.WriteLine("The product will be a negative number");
        }
    }
}

