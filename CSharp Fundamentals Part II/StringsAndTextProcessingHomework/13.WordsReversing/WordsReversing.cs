using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class WordsReversing
{
    static void Main()
    {
        string text = "C# is not C++, not PHP and not Delphi!";

        char[] separators = { ' ', ',', '!', '?', '.'};

        string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        Array.Reverse(words);

        //get the last symbol ('.', '?', '!')
        char lastSymbol = text[text.Length - 1];

        StringBuilder sb = new StringBuilder();
        sb.Append(lastSymbol);

        for (int i = 0; i < words.Length; i++)
        {
            sb.Append(words[i]);
            if (i <= words.Length - 2)
            {
                sb.Append(" ");
            }
        }

        Console.WriteLine(sb.ToString());
    }
}