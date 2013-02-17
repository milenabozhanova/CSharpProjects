using System;
using System.Collections.Generic;
using System.Text;

class StringReversing
{
    static void Main()
    {
        string str = Console.ReadLine();
        string reversed = ReverseText(str);    

        Console.WriteLine(reversed);
    }

    static string ReverseText(string text)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = text.Length-1; i >= 0; i--)
        {
            sb.Append(text[i]);
        }
        return sb.ToString();
    }
}
