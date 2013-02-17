using System;
using System.Collections.Generic;

class SquareRootExceptions
{
    static void Main()
    {
        try
        {
            Console.Write("Please enter one integer: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                throw new FormatException();
            }
            double sqr = Math.Sqrt(number);
            Console.WriteLine("The square root is {0}.", sqr);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (OverflowException)
        {
            Console.WriteLine("The number is too large or too small!");
        }
        finally
        {
            Console.WriteLine("Goodbye!");
        }
    }
}
