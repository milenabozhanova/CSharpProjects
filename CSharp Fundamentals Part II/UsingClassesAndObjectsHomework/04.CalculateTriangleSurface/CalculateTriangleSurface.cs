using System;
class CalculateTriangleSurface
{
    static void Main()
    {
        Console.Write("a= ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b= ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c= ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("h= ");
        double h = double.Parse(Console.ReadLine());
        Console.Write("angle= ");
        double angle = double.Parse(Console.ReadLine());

        Console.WriteLine(CalcSurface(a, h));

        Console.WriteLine(CalcSurface(a, b, c));

        Console.WriteLine(CalcSurfaceByAngle(a, b, angle));
    }

    static double CalcSurface(double a, double h)
    {
        double surface = (a * h) / 2;
        return surface;
    }

    static double CalcSurface(double a, double b, double c)
    {
        double surface = (a + b + c) / 2;

        return Math.Sqrt(surface * (surface - a) * (surface - b) * (surface - c));
    }

    static double CalcSurfaceByAngle(double a, double b, double angle)
    {
        double surface = a * b * Math.Sin(Math.PI * angle / 180) / 2;
        return surface;
    }
}