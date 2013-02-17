using System;

class PadRight
{
    static void Main()
    {
        string str = Console.ReadLine();

        if (str.Length < 20)
        {
            Console.WriteLine(str.PadRight(20, '*'));
        }
    }
}
