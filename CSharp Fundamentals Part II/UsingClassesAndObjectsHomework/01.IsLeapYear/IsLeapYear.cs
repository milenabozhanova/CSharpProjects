using System;

class IsLeapYear
{
    static void Main()
    {
        Console.WriteLine("Please enter a year: ");
        int year = int.Parse(Console.ReadLine());

        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("The entered year is leap!");
        }
        else
        {
            Console.WriteLine("The entered year isn't leap!");
        }
    }
}
