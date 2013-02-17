using System;

class GrestestOf5Variables
{
    static void Main()
    {
        Console.WriteLine("Please enter 5 numbers");
        
        int[] numbers = new int[5];

        for (int i = 0; i < 5; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int max = int.MinValue;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }         
        }

        Console.WriteLine("The greatest number is: {0}", max);
        
    }
}

