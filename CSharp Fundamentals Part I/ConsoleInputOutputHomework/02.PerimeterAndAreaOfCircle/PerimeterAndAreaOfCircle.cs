using System;

class PerimeterAndAreaOfCircle
{
    static void Main()
    {
        Console.WriteLine("This program calculates the perimeter area of a circle");

        Console.Write("Enter the lenght of the radius: r= ");
        int r = int.Parse(Console.ReadLine());

        Console.WriteLine("The perimeter is: {0:0.000}", (2 * Math.PI * r));
        Console.WriteLine("The area is: {0:0.000}", (Math.PI * (r*r)) );
    }
}
