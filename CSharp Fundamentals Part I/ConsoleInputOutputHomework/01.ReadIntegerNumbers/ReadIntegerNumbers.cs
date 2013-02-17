using System;


class ReadIntegerNumbers
{
    static void Main()
    {
        Console.Write("Please enter the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Please enter the secound number: ");
        int secoundNumber = int.Parse(Console.ReadLine());

        Console.Write("Please enter the third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("{0} + {1} + {2} = {3}", firstNumber, secoundNumber, thirdNumber, (firstNumber + secoundNumber + thirdNumber));
    }
}
