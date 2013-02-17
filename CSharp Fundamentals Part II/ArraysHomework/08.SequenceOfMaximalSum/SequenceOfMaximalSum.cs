using System;
using System.Collections.Generic;

class SequenceOfMaximalSum
{
    static void Main()
    {
        //input
        Console.WriteLine("Enter arr length:");
        int length = int.Parse(Console.ReadLine());

        // for test int[] arr = {2, 3, -6, -1, 2, -1, 6, 4, -8, 8};
        int[] arr = new int[length];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        //solution
        int max = arr[0];
        int maxEnd = arr[0];
        int start = 0; 
        int startTemp = 0;
        int end = 0;
        
        for (int i = 1; i < arr.Length; ++i)
        {

            if (arr[i] + maxEnd > arr[i])
            {
                maxEnd = arr[i] + maxEnd;
            }

            else
            {
                maxEnd = arr[i];
                startTemp = i;
            }
            if (maxEnd > max)
            {
                max = maxEnd;
                start = startTemp;
                end = i; 
            }
        }

        //print the subsequence 
        for (int i = start; i <= end; ++i)
        {
            Console.Write("{0} ", arr[i]);
        }
    }
}

