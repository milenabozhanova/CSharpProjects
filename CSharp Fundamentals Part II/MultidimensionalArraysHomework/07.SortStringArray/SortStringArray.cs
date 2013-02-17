using System;
using System.Collections.Generic;

class SortStringArray
{
    static void Main(string[] args)
    {
        string[] arr = { "teeeziii", "Ai", "pisna", "nachi", "miiiii", "oooooot", "soooooort", "zadachiiiii" };


        int minValueIndex;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            minValueIndex = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j].Length < arr[minValueIndex].Length)
                {
                    minValueIndex = j;
                }
            }

            // exchange positions
            if (minValueIndex != i)
            {
                string temp = arr[minValueIndex];
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

