﻿using System;

class ASCIItable
{
    static void Main()
    {
        Console.Write("Decimal".PadRight(10));
        Console.Write("ASCII:".PadRight(10));
        Console.Write("Hex".PadRight(10));
        Console.WriteLine();
        Console.WriteLine();

        int min = 0;
        int max = 128;
        for (int i = min; i < max; i++)
        {
            char c = (char)i;

            string display = string.Empty;
            if (char.IsWhiteSpace(c))
            {
                display = c.ToString();
                switch (c)
                {
                    case '\t':
                        display = "\\t";
                        break;
                    case ' ':
                        display = "space";
                        break;
                    case '\n':
                        display = "\\n";
                        break;
                    case '\r':
                        display = "\\r";
                        break;
                    case '\v':
                        display = "\\v";
                        break;
                    case '\f':
                        display = "\\f";
                        break;
                }
            }
            else if (char.IsControl(c))
            {
                display = "control";
            }
            else
            {
                display = c.ToString();
            }

            Console.Write(i.ToString().PadRight(10));
            Console.Write(display.PadRight(10));
            Console.Write(i.ToString("X2"));
            Console.WriteLine();
        }
    }
}