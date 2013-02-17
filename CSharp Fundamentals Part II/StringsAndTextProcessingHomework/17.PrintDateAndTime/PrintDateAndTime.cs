using System;
using System.Globalization;

class PrintDateAndTime
{
    static void Main()
    {
        Console.WriteLine("Please enter two dates in format dd.MM.yyyy HH:mm:ss");
        string input = Console.ReadLine();

        DateTime date = DateTime.ParseExact(input, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);

       date = date.AddHours(6.5);

        Console.WriteLine("{0} {1}", date.ToString("dddd", new CultureInfo("bg-BG")), date);
    }
}
