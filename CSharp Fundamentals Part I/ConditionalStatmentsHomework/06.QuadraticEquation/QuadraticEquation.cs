using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("This is program, which solves quadratic equation. So please enter it's coefficitents");
        Console.Write("a= ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("b= ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("c= ");
        double c = double.Parse(Console.ReadLine());

        double discriminant = (b * b) - (4 * a * c);

        if (a != 0)
        {
            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);

                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("x1 = {0}, x2 = {1}", x1, x2);
            }

            else if (discriminant == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("x = {0}", x);
            }
            else if (discriminant < 0)
            {
                Console.WriteLine("No solution");
            }
        }
        else
        {
            Console.WriteLine("The equation is a linear equation");
        }
         
        
        
    }
}

