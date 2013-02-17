using System;

class CompareFloatingPointNum
{
    static void Main()
    {
        Console.Write("Enter one real number: ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter another real number: ");
        double secoundNumber = double.Parse(Console.ReadLine());

        bool compare = Math.Round(firstNumber, 6) == Math.Round(secoundNumber, 6);

        if (compare == false)
        {
            if (firstNumber > secoundNumber)
            {
                Console.WriteLine("{0} > {1}", firstNumber, secoundNumber);
            }
            else if (firstNumber < secoundNumber)
            {
                Console.WriteLine("{0} < {1}", firstNumber, secoundNumber);
            }
        }
        else
        {
            Console.WriteLine("The numbers are equal");
        }
    }
}