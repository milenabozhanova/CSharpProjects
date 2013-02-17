using System;

class FirstBiggerThabNeighbors
{
    static bool IsBiggerThanNeighbors(int index)
    {
        bool isBigger = true;

        if (index > 0 && index < arr.Length - 1)
        {
            if (arr[index - 1] < arr[index] && arr[index] > arr[index + 1])
            {
                return isBigger;
            }
            else
            {
                isBigger = false;
                return isBigger;
            }
        }
        else if (index == 0)
        {
            if (arr[index] > arr[index + 1])
            {
                return isBigger;
            }
            else
            {
                isBigger = false;
                return isBigger;
            }
        }
        else
        {
            if (arr[index] > arr[index - 1])
            {
                return isBigger;
            }
            {
                isBigger = false;
                return isBigger;
            }
        }
    }

    static int FirstBiggerNeighbor()
    {
        for (int i = 0; i < arr.Length; i++)
        {
            bool result = IsBiggerThanNeighbors(i);
            if (result == true)
            {
                return i;
            }
        }
        return -1;
    }

    static int[] arr = { 1, 2, 1, 3, 4, 7, 5, 6, 8, 5, 12 };
    
    static void Main()
    {

        int index = FirstBiggerNeighbor();

        if (index == -1)
        {
            Console.WriteLine("There isn't such element which is bigger than its neighbors");
        }
        else
        {
            Console.WriteLine("The first element in array which is bigger than its neighbors is: {0}, its index is: {1}", arr[index], index);
        }

    }


}