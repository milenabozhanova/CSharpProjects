using System;

class Problem3_FirTree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string firstAndLastLine = new string('.', n - 2) + "*" + new string('.', n - 2);
        Console.WriteLine(firstAndLastLine);

        for (int i = 1; i < n - 1; i++)
        {
            Console.WriteLine(new string('.', n - i - 2) + new string('*', 2 * i + 1) + new string('.', n - i - 2));
        }
        Console.WriteLine(firstAndLastLine);
    }
}

