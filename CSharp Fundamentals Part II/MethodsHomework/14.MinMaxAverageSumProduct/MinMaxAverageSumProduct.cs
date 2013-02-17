using System;
using System.Collections.Generic;

class MinMaxAverageSumProduct
{
    static void Main()
    {
        Console.Write("Please enter lenght of the set of numbers: ");
        int len = int.Parse(Console.ReadLine());

        int[] numbers = new int[len];

        for (int i = 0; i < len; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Minimum: {0}", CalcMin(numbers));
        Console.WriteLine("Minimum: {0}", CalcMax(numbers));
        Console.WriteLine("Avarage: {0}", CalcSum(numbers)/2);
        Console.WriteLine("Sum: {0}", CalcSum(numbers));
        Console.WriteLine("Product: {0}", CalcProduct(numbers));

    }

    static int CalcMin(int[] numbers)
    {
        int min = int.MaxValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        return min;
    }

    static int CalcMax(int[] numbers)
    {
        int min = int.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > min)
            {
                min = numbers[i];
            }
        }
        return min;
    }

    static int CalcSum(int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }

    static int CalcProduct(int[] numbers)
    {
        int product = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }
        return product;
    }
}
