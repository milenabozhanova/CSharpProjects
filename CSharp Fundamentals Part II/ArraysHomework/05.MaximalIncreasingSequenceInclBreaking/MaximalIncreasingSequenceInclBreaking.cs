using System;
using System.Collections.Generic;

class MaximalIncreasingSequenceInclBreaking
{
    static void Main()
    {
       
        int n = int.Parse(Console.ReadLine()); //array length
        
        int[] arr = new int [n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

       // for quick test int[] arr = {2, 4, 3, 5, 1, 7, 6, 9, 8};

        int[] L = new int [n]; // array for the length of the subsequence
        int[] P = new int[n]; // array for the predecessor 

        int maxLength = 0;
        int bestEnd = 0;

        L[0] = 1;
        P[0] = -1; 

        for (int i = 1; i < n; i++)
        {
            L[i] = 1;
            P[i] = -1;
            for (int j = i - 1; j >= 0; j--)
            {
                if (L[j] + 1 > L[i] && arr[j] < arr[i])
                {
                    L[i] = L[j] + 1;
                    P[i] = j;
                }
            }
            if (L[i] > maxLength)
            {
                bestEnd = i;
                maxLength = L[i];
            }
        }

        Console.WriteLine("The maximal length is: {0}", maxLength);
        Console.Write("Longest subsequence: ");

        int ind = bestEnd;
        List<int> answer = new List<int>();


        while (ind != -1)
        {
            answer.Add( arr[ind]);
            ind = P[ind];
        }

        answer.Reverse(0, answer.Count);

        foreach (int num in answer)
        {
            Console.Write(num + " ");
        }
    }
}

