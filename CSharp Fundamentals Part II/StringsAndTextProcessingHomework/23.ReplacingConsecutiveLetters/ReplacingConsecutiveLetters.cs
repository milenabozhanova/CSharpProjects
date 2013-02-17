﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ReplacingConsecutiveLetters
{
    static void Main()
    {
        string text = Console.ReadLine();

        StringBuilder result = new StringBuilder();

        for (int i = 0; i < text.Length - 1; i++)
        {
            if (text[i] != text[i + 1])
            {
                result.Append(text[i]);
            }
        }

        if (text[text.Length-2] != text[text.Length - 1])
        {
            result.Append(text[text.Length-1]);
        }

        Console.WriteLine(result.ToString());
    }
}
