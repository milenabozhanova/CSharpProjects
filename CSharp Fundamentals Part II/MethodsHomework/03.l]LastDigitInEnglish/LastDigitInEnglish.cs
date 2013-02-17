using System;

class LastDigitInEnglish
{
    static int GetLastDigit(int number)
    {
        int lastDigit = number % 10;
        return lastDigit;
    }

    static string SayLastDigit(int digit)
    {
        string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        return(digits[digit]);
    }
    
    static void Main()
    {
        Console.WriteLine("Please enter one integer");

        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("The last digit is: {0}", SayLastDigit(GetLastDigit(number)));
    }
}

