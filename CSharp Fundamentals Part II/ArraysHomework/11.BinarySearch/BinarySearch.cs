using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BinarySearch
{
    static int BinarySearchAlg(int[] array, int value)
    {
        int low = 0, high = array.Length - 1, midpoint = 0;

        while (low <= high)
        {
            midpoint = low + (high - low) / 2;

            // check to see if value is equal to item in array
            if (value == array[midpoint])
            {
                return midpoint;
            }
            else if (value < array[midpoint])
                high = midpoint - 1;
            else
                low = midpoint + 1;
        }
        // item was not found
        return -1;
    }

    static void Main()
    {
        
        int len = int.Parse(Console.ReadLine());
        int[] arr = new int[len];

        for (int i = 0; i < len; i++)
        {
           arr[i] =  int.Parse(Console.ReadLine());
        }

        int number = int.Parse(Console.ReadLine());

        Array.Sort(arr);

        int index = BinarySearchAlg(arr, number);

        if (index != -1)
        {
            Console.WriteLine("The index of {0} is: {1}", number, index);
        }
        else
        {
            Console.WriteLine("{0} is not in the array",number );
        }      
    }
}
