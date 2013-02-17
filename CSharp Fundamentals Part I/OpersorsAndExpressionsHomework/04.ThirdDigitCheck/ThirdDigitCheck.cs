using System;

class ThirdDigitCheck
{
    static void Main()
    {
        Console.WriteLine("Please enter a three-digit number:");
        int number = int.Parse(Console.ReadLine());
        int devidedNumber = Math.Abs(number) / 100;
 
        if (devidedNumber  % 10 == 7)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }

      
    }
}

