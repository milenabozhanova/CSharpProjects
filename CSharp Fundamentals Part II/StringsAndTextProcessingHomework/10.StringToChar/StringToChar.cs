using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class StringToChar
{
    static void Main()
    {
        string text = Console.ReadLine();

        foreach (var letter in text)
        {
            Console.WriteLine("\\u{0:X4}", (int)letter);
        }
    }
}
