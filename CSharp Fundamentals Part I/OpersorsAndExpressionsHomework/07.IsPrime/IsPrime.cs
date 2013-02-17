using System;

class IsPrime
{
    static void Main()
    {
        Console.Write("Enter a positive integer number n (n ≤ 100) : ");
        byte number = byte.Parse(Console.ReadLine());

        byte divider = 2;
        byte maxDivider = (byte)Math.Sqrt(number);
        bool prime = true;

        while (prime && (divider <= maxDivider))
        {
            if (number % divider == 0)
            {
                prime = false;
            }
            divider++;
        }
        Console.WriteLine(prime ? "The given number is prime" : "The given number isn't prime");
    }
}
