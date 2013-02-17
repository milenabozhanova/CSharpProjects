using System;

class CartesianCoordinateSystem
{
    static void Main()
    {
        decimal x = decimal.Parse(Console.ReadLine());
        decimal y = decimal.Parse(Console.ReadLine());

        // check for part 0 and 5
        if (x == 0)
        {
            if (y == 0) Console.WriteLine(0);
            else if (y > 0) Console.WriteLine(5);
        }
        // check for part 6
        else if (y == 0)
        {
            if (x > 0) Console.WriteLine(6);
        }
        // check for part 1 and 4
        else if (x > 0)
        {
            if (y > 0) Console.WriteLine(1);
            else if (y < 0) Console.WriteLine(4);
        }
        // check for part 2 and 3
        else if (x < 0)
        {
            if (y > 0) Console.WriteLine(2);
            else if (y < 0) Console.WriteLine(3);
        }
    }
}

