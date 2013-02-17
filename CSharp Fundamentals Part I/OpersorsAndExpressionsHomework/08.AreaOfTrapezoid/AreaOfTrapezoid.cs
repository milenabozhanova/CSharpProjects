using System;

class AreaOfTrapezoid
{
    static void Main()
    {
        Console.WriteLine("This is a program, which calculates a trapezoid's area. So please enter the rectangle's sides a and b and height h (with digits)");
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("height = ");
        double height = double.Parse(Console.ReadLine());
        
        double area = (((a + b) / 2) * height);
        Console.WriteLine("The area of a trapezoid is: {0} cm", area);
    }
}
