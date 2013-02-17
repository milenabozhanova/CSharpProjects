using System;

class CalculatingOfRectanglesArea
{
    static void Main()
    {
        Console.WriteLine("This is a program, which calculates a rectangle's area. So please enter the rectangle's hight and width (with digits)");
        Console.Write("height = ");
        int height = int.Parse(Console.ReadLine());

        Console.Write("width = ");
        int width = int.Parse(Console.ReadLine());

        int area = (height * width);
        Console.WriteLine("The area of a rectangle with height = {0} cm and width = {1} cm is: {2} cm", height, width, area);
    }
}
