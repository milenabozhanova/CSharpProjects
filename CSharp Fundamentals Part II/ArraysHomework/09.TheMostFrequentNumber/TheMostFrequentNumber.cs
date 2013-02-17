using System;
using System.Collections.Generic;
using System.Linq;

class TheMostFrequentNumber
{
    static void Main()
    {
        int[] arr = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

        List<int> keys = new List<int>();  // which number from array
        List<int> counts = new List<int>(); //how many times is repeated

        for (int i = 0; i < arr.Length; i++)
        {
            if (keys.Contains(arr[i]))
            {
                counts[keys.IndexOf(arr[i])] += 1;
            }
            else
            {
                keys.Add(arr[i]);
                counts.Add(1);
            }

        }

        int index = counts.IndexOf(counts.Max());
        Console.WriteLine("The most frequent number in an array is: {0} ({1} times)", keys[index], counts[index]);   
    }
}

