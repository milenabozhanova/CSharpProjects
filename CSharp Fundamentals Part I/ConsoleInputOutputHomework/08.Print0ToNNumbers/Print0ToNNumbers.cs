using System;

class Print0ToNNumbers
{
    static void Main()
    {
        Console.Write("Please enter one positive integer. n = ");
        int n = int.Parse(Console.ReadLine());

        if (n > 0)
        {
            int num = 1;

            while (num <= n)
            {
                Console.WriteLine(num);
                num++;
            }
        }
        else
        {
            Console.WriteLine("Invalid number");
        }
    }
}

