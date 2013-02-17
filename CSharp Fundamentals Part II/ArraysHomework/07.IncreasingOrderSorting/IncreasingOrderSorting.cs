using System;
using System.Collections.Generic;

class IncreasingOrderSorting
{  
    static void Main()
    {
        int[] arr = { 9, 2, 1, 3, 5, 1, 8 };
                

        int minValueIndex;
 
        for (int i = 0; i < arr.Length - 1; i++)
        {
            minValueIndex = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[minValueIndex])
                {
                    minValueIndex = j;
                }
            }
 
            // exchange positions
            if (minValueIndex != i)
            {
                int temp = arr[minValueIndex];
                arr[minValueIndex] = arr[i];
                arr[i] = temp;
            }
        }
 
        //print tha sorted array on the console
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}

