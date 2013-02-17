using System;


class PrintGreaterNumber
{
    static void Main()
    {
        Console.WriteLine("Please enter two integers");
        Console.Write("a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("b: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine(a > b ? "{0} > {1}" : "{0} <= {1}", a, b);
    }
}
