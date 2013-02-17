/*Write a program that finds in given array of integers a sequence of given sum S (if present).
         Example:       {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}*/

using System;
using System.Collections.Generic;
using System.Linq;

class SubsequenceOfGivenSum
{
    static void Main()
    {
        //input
        int len = int.Parse(Console.ReadLine());
        int S = int.Parse(Console.ReadLine());
        int[] arr = new int[len];
        
        // for test int[] arr = {2, 4, 0, 6, -1, 7, 8);
        for (int i = 0; i < len; i++)
		{
			 arr[i] = int.Parse(Console.ReadLine());
		}
        
        //solution
        int sum = 0;
        int count = 0;

        // save the start and end of the subsequence
        List<int> starts = new List<int>(); 
        List<int> ends = new List<int>();

        for (int i = 0; i < arr.Length-1; i++)
		{
            sum = arr[i];
            if (sum == S)
            {
                starts.Add(i);
                ends.Add(i);
                count++;
            }

            for (int j= i +1; j  < arr.Length; j++)
            {
                sum += arr[j];
                if (sum == S)
                {
                    starts.Add(i);
                    ends.Add(j);
                    count++;
                }
                if (sum > S)
                {
                    break;
                }
            }
		}

        //print the result
        if (count == 0)
        {
            Console.WriteLine("There is no sequence of given sum {0} in the array", S);
        }
        else
        {
            Console.WriteLine("There is/are {0} subsequense which sum is: {1}", count, S);

            for (int i = 0; i < count; i++)
			{
                for (int j = starts[i]; j <= ends[i]; j++)
                {
                    Console.Write(arr[j] + " ");
                }
                Console.WriteLine();
             }
        }

    }
}

