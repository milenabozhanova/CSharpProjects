using System;

class NtoMMaxAndMin
{
    static void Main()
    {
        Console.Write("Please enter the count of the number in the sequence: n = ");
        int n = int.Parse(Console.ReadLine());

        int min = int.MaxValue;
        int max = int.MinValue;

        Console.WriteLine("Please enter {0} more integer", n);

        for (int i = 0; i < n; i++)
        {
            Console.Write("Your next number: ");
            int num = int.Parse(Console.ReadLine());
            if (num > max)
            {
                max = num;
            }
            if (num < min)
            {
                min = num;
            }
        }
        Console.WriteLine("Min is: {0}, max is: {1}", min,max);
       
        

    }
}

