using System;
using System.Collections.Generic;

class MaxElementInSubarray
{


    static int[] SortArray(int[] arr)
    {
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
        return arr;
    }

    static int GetMaxElement(int index, int[] arr, int len)
    {
        int max = index + len;
        if (max < arr.Length - 1)
        {
            return arr[max];
        }
        else
        {
            return arr[arr.Length - 1];
        }
    }
    
    static void Main()
    {

        int[] arr = {48, 3, 5, 1, 9, 4, 8, 7, 6, 15, 20};
        Console.Write("Please enter an index from 0 to 10: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Please enter the lenght of the subaray: ");
        int len = int.Parse(Console.ReadLine()); // lenght of subarray

        int[] sortArr = SortArray(arr);

        int maxEl = GetMaxElement(start, arr, len);
        Console.WriteLine(maxEl);

    }
}