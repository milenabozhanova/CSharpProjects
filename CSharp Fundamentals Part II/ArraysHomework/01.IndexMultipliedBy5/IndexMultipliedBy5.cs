﻿using System;

class IndexMultipliedBy5
{
    static void Main()
    {
        int[] arr = new int[20];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i * 5;
        }

        foreach (var element in arr)
        {
            Console.WriteLine(element);
        }
    }
}

