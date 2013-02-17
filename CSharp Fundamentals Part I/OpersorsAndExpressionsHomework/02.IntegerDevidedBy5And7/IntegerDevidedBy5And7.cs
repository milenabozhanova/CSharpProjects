using System;

class IntegerDevidedBy5And7
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        if (n % 5 == 0 && n % 7 == 0)
        {
            Console.WriteLine("The number {0} can be devided (without remainder) by 7 and 5 in the same time.", n);
        }
        else
        {
            Console.WriteLine("The number {0} can't be devided (without remainder) by 7 and 5 in the same time.", n);
        }
    }
}
