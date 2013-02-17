using System;
using System.Collections.Generic;

class ReadANumber
{
    static void Main()
    {
        Console.WriteLine("Please enter 10 numbers (n) in a range 1 < n < 100: ");
        for (int i = 0; i < 10; i++)
        {
            try
            {
                ReadNumber(1, 100);
            }
            catch (FormatException form)
            {
                Console.WriteLine(form.Message);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("The number is not in range");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number is too large or too small!");
            }
            catch (ArgumentException argEx)
            {
                Console.WriteLine(argEx.Message);
            }
        }      

    }

    static void ReadNumber(int start, int end)
    {
        int number = int.Parse(Console.ReadLine());
        if (number > start && number < end)
        {
            Console.WriteLine("Correct number");
        }
        else 
        {
            throw new ArgumentOutOfRangeException("The number is not in range");
        }
    }
}