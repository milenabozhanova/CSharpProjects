using System;
using System.Collections.Generic;
using System.Linq;

class BinSearch
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("K = ");
        int k = int.Parse(Console.ReadLine());
        Array.Sort(arr);

        int index = Array.BinarySearch(arr, k);

        if (index >= 0)
        {
            Console.WriteLine(arr[index]);
        }
        else if (~index <= arr.Length && ~index - 1 >= 0)
        {
            Console.WriteLine(arr[~index - 1]);
        }
        else
        {
            Console.WriteLine("There is no such number which is smaller or equal to k");
        }
    }
}

