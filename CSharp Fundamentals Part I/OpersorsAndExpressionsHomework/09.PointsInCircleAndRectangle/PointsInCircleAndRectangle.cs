using System;

class PointsInCircleAndRectangle
{
    static void Main()
    {
        float circleA = 1f;
        float circleB = 1f;
        float circleRadius = 3f;

        float rectangleX1 = -1f;
        float rectangleX2 = 5f;
        float rectangleY1 = 1f;
        float rectangleY2 = -1f;

        Console.WriteLine("Please enter value for x and y:");
        float x = float.Parse(Console.ReadLine());
        float y = float.Parse(Console.ReadLine());

        if (Math.Pow(x - circleA, 2) + Math.Pow(y - circleB, 2) <= circleRadius * circleRadius)
        {
            if (((x >= rectangleX1) && (x <= rectangleX2)) && ((y <= rectangleY1) && (y >= rectangleY2)))
            {
                Console.WriteLine("The given coordinates are within the circle K and within the rectangle R");
            }
            else
            {
                 Console.WriteLine("The given coordinates are within the circle K and outside the rectangle R");
            }
        }
        else
        {
            
            Console.WriteLine("The given coordinates are outside the circle K");
            
         }
    }
}

