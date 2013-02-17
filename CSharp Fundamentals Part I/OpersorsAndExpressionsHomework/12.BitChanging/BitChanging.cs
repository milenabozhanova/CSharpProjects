using System;

class BitChanging
{
    static void Main()
    {
        Console.Write("Please enter a number n= ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Please enter a value of bit (0 or 1)  v= ");
        int v = int.Parse(Console.ReadLine());

        while (v != 0 && v != 1)
        {
            Console.Write("Please enter a correct value of bit (0 or 1)  v= ");
            v = int.Parse(Console.ReadLine());
        }

        Console.Write("Please enter a position p= ");
        int p = int.Parse(Console.ReadLine());

        if (v == 0)
        {
            int mask = ~(1 << p);
            int result = n & mask;
            Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
        }
        else
        {
            int mask = 1 << p;          
            int result = n | mask;
            Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));  
        }
    }
}
