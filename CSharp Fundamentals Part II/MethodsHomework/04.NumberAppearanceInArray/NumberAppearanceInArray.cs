using System;
using System.Collections.Generic;

class NumberAppearanceInArray
{

    static void Main()
    {
        Console.Write("Please enter lenght of the set of numbers: ");
        int len = int.Parse(Console.ReadLine());

        int[] numbers = new int[len];

        Console.WriteLine("Please enter {0} numbers, each on a new line:", len);

        for (int i = 0; i < len; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Choose a number from the set: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("{0} appeare: {0} times int the set", number, NumberAppearance(number, numbers));
    }

    static int NumberAppearance(int num, int[] arr)
    {
        int counter = 0;
        
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == num)
            {
                counter++;
            }
        }
        return counter;
    }
}

