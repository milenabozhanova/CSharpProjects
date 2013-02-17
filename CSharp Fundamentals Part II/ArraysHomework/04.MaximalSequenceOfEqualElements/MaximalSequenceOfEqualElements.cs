using System;

class MaximalSequenceOfEqualElements
{
    static void Main()
    {
        int[] arr = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1, 1};

        int count = 1;
        int currentC = 1;
        int repeatedNumber = 0;

        for (int i = 0; i < arr.Length-1; i++)
        {
            if (arr[i] == arr[i+1])
            {
                currentC++;
            }
            else 
            {
                if (currentC > count)
                {
                    count = currentC;
                    repeatedNumber = arr[i];
                }
                currentC = 1;
            }
        }

        // check the last sequence
        if (currentC > count)
        {
            count = currentC;
            repeatedNumber = arr[arr.Length - 1];
        }

        //check if there just "single" elements
        if (count - 1 == 0)
        {
            Console.WriteLine("The lenght of maximal sequence of equal elements in an array is 1, so all sequence are equal");
        }

       // print the expected result 
        else
        {
            Console.WriteLine("The maximal sequence of equal elements in an array is:");
            for (int i = 0; i < count; i++)
            {
                Console.Write(repeatedNumber + " ");
            }
        }
    }
}
