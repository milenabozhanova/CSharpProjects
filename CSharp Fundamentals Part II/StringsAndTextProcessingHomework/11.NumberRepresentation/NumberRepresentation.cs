using System;
using System.Threading;
using System.Globalization;

class NumberRepresentation
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Decimal number: {0,15}", number);  

        Console.WriteLine("Hexadecimal number: {0,15:X}", number); 

        Console.WriteLine("Percentage: {0,15:P}", number); 

        Console.WriteLine("In scientific notation: {0,15:E}", number); 
    }
}
