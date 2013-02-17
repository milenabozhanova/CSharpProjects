using System;
using System.Collections.Generic;

class MaximalSumOfKElements
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); //array length
        int k = int.Parse(Console.ReadLine()); // number of elements

        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        if (k < n)
        {
            Array.Sort(arr);
            int sum = 0;
            Console.WriteLine("The {0} elements that have maximal sum are: ", k);
            for (int i = arr.Length-k; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
                sum += arr[i];
            }
            Console.WriteLine();
            Console.WriteLine("The maximal sum is: {0}", sum);
        }
        else
        {
            Console.WriteLine("Invalide numbers. K should be smaller than N");
        }
    }
}

