using System;
using System.Collections.Generic;

class CombinationsOfDistinctElements
{

    static void MakeCombinations(int[] arr, int index, int currentNumber, int n)
    {
        if (index == arr.Length)
        {
            PrintArray(arr);
        }
        else
        {
            for (int i = currentNumber; i <= n; i++)
            {
                arr[index] = i;
                MakeCombinations(arr, index + 1, i + 1, n);
            }
        }
    }

    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
    
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        int[] arr = new int[k];
        MakeCombinations(arr, 0, 1, n);
    }
}
