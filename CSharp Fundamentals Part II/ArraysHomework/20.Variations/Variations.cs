using System;
using System.Collections.Generic;
using System.Linq;

class Variations
{   
    static void MakeVariations(int index, int[] arr, int n)
    {
        if (index == arr.Length)
        {
            PrintArray(arr);
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                arr[index] = i;
                MakeVariations(index + 1, arr, n);
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

        MakeVariations(0, arr, n);
    }
}
