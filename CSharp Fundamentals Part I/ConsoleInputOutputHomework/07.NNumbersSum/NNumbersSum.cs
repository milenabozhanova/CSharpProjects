using System;

class NNumbersSum
{
    static void Main()
    {
        Console.Write("Please enter one integer. n = ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter {0} more integer", n);
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Your next number");
            int nextN = int.Parse(Console.ReadLine());
            sum += nextN;
        } 

        Console.WriteLine("The sum of the integer is = {0}", sum);   
    }


}

