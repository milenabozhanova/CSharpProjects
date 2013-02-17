using System;
using System.Collections.Generic;

class BiggerThanNeighbors
{
    static bool IsBiggerThanNeighbors(int index)
    {
        bool isBigger = true;

        if (index > 0 && index < arr.Length-1)
        {
            if (arr[index - 1] < arr[index] && arr[index] > arr[index + 1])
            {
                return isBigger;
            }
            else
            {
                isBigger = false;
                return isBigger;
            }
        }
        else if (index == 0)
        {
            if (arr[index] > arr[index + 1])
            {
                return isBigger;
            }
            else
            {
                isBigger = false;
                return isBigger;
            }
        }
        else
        {
            if (arr[index] > arr[index - 1])
            {
                return isBigger;
            }
            {
                isBigger = false;
                return isBigger;
            }
        }
    }
    
    
    static int[] arr = { 1, 2, 1, 3, 4, 7, 5, 6, 8, 5, 12 };
    
    static void Main()
    {
        Console.WriteLine("Please enter index of element from 0 to 10");
        int elIndex = int.Parse(Console.ReadLine());

        bool result = IsBiggerThanNeighbors(elIndex);
        Console.WriteLine("The element is bigger that its (one)two neighbors: {0}", result);

    }
}