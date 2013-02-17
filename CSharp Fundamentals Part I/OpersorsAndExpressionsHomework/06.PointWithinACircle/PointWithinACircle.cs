using System;

class PointWithinACircle
{
    static void Main()
    {
        float circleA = 0f;
        float circleB = 0f;
        float circleRadius = 5f;

        Console.WriteLine("Please enter value for x and y:");
        float x = float.Parse(Console.ReadLine());
        float y = float.Parse(Console.ReadLine());

        if (Math.Pow(x - circleA, 2) + Math.Pow(y - circleB, 2) <= circleRadius * circleRadius)
        {
            Console.WriteLine("The given coordinates are within the circle K");
        }
        else
        {
            Console.WriteLine("The given coordinates are outside the circle K");
        }
    }
}

