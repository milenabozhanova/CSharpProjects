using System;

class MaximalIncreasingSequence
{
    static void Main()
    {
        int[] arr = {0, 1, 2, 3, 4, 2, 9, 14, 15, 16, 17, 18, 30, 32, 33};
        //{ 3, 2, 3, 4, 2, 2, 4};


        int count = 1;
        int currentC = 1;
        int endNumberIndex = 0;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i+1] > arr[i])
            {
                currentC++;

            }
            else
            {
                if (currentC > count)
                {
                    count = currentC;
                    endNumberIndex = i;
                }
                currentC = 1;
            }
        }

        // check the last sequence
        if (currentC > count)
        {
            count = currentC;
            endNumberIndex = arr.Length-1;
        }

        //check if there just "single" elements
        if (count - 1 == 0)
        {
            Console.WriteLine("The lenght of maximal increasing sequence in an array is 1, so all sequence are equal");
        }

       // print the expected result 
        else
        {
            Console.WriteLine("The  maximal increasing sequence in an array is:");
            for (int i = (endNumberIndex - count +1); i <= endNumberIndex; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}

